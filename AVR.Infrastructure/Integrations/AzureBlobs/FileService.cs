using AVR.Domain.Interfaces;
using SharpCompress.Archives.Rar;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.AzureBlobs
{
    public class FileService : IFileService
    {
        private readonly IAzureBlobService _azureBlobService;

        public FileService(IAzureBlobService azureBlobService)
        {
            _azureBlobService = azureBlobService;
        }

        public async Task<string> ExtractAndUploadAsync(Stream fileStream, string containerName)
        {
            var extractedFileUrl = string.Empty;
            var tempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

            try
            {
                // Tạo thư mục tạm
                Directory.CreateDirectory(tempFolder);

                // Phát hiện định dạng tệp
                var format = DetectFileFormat(fileStream);

                if (format == "ZIP")
                {
                    // Xử lý tệp ZIP
                    using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Read))
                    {
                        foreach (var entry in archive.Entries)
                        {
                            var filePath = Path.Combine(tempFolder, entry.FullName);
                            var directory = Path.GetDirectoryName(filePath);

                            if (!string.IsNullOrEmpty(directory))
                            {
                                Directory.CreateDirectory(directory);
                            }

                            using (var entryStream = entry.Open())
                            using (var fileStreamToWrite = File.Create(filePath))
                            {
                                await entryStream.CopyToAsync(fileStreamToWrite);
                            }
                        }
                    }
                }
                else if (format == "RAR")
                {
                    // Xử lý tệp RAR
                    using (var archive = RarArchive.Open(fileStream))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            var relativePath = entry.Key.Replace("\\", "/");
                            var filePath = Path.Combine(tempFolder, relativePath);
                            var directory = Path.GetDirectoryName(filePath);

                            if (!string.IsNullOrEmpty(directory))
                            {
                                Directory.CreateDirectory(directory);
                            }

                            using (var entryStream = entry.OpenEntryStream())
                            using (var fileStreamToWrite = File.Create(filePath))
                            {
                                await entryStream.CopyToAsync(fileStreamToWrite);
                            }
                        }
                    }
                }
                else
                {
                    throw new InvalidOperationException("Unsupported file format.");
                }

                // Tìm file .html sau khi giải nén
                var htmlFilePaths = Directory.GetFiles(tempFolder, "*.html", SearchOption.AllDirectories);
                if (htmlFilePaths.Length > 0)
                {
                    foreach (var htmlFilePath in htmlFilePaths)
                    {
                        using (var fileStreamToUpload = File.OpenRead(htmlFilePath))
                        {
                            var relativeFilePath = Path.GetRelativePath(tempFolder, htmlFilePath).Replace("\\", "/");
                            extractedFileUrl = await _azureBlobService.UploadFileAsync(fileStreamToUpload, relativeFilePath, "text/html");
                        }
                    }
                }
            }
            finally
            {
                // Dọn dẹp thư mục tạm
                if (Directory.Exists(tempFolder))
                {
                    Directory.Delete(tempFolder, true);
                }
            }

            return extractedFileUrl;
        }

        public string DetectFileFormat(Stream fileStream)
        {
            byte[] buffer = new byte[4];
            fileStream.Read(buffer, 0, 4);
            fileStream.Seek(0, SeekOrigin.Begin); // Đưa stream về vị trí đầu

            string header = BitConverter.ToString(buffer);
            if (header.StartsWith("50-4B-03-04")) // ZIP signature
            {
                return "ZIP";
            }
            else if (header.StartsWith("52-61-72-21")) // RAR signature
            {
                return "RAR";
            }

            return "UNKNOWN";
        }





    }
}
