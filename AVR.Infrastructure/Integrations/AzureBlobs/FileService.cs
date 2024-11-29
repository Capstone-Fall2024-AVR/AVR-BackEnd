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
            string htmlFileUrl = null; // Biến để lưu đường dẫn file HTML
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

                // Upload tất cả file đã giải nén lên Azure Blob Storage
                var allFilePaths = Directory.GetFiles(tempFolder, "*.*", SearchOption.AllDirectories);
                foreach (var filePath in allFilePaths)
                {
                    using (var fileStreamToUpload = File.OpenRead(filePath))
                    {
                        var relativeFilePath = Path.GetRelativePath(tempFolder, filePath).Replace("\\", "/");
                        var contentType = GetContentType(filePath);
                        var uploadedFileUrl = await _azureBlobService.UploadFileAsync(fileStreamToUpload, relativeFilePath, contentType);

                        // Kiểm tra nếu là file .html thì lưu lại URL
                        if (Path.GetExtension(filePath).ToLower() == ".html")
                        {
                            htmlFileUrl = uploadedFileUrl;
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

            // Trả về đường dẫn file HTML (hoặc null nếu không có file HTML nào)
            return htmlFileUrl;
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


        private string GetContentType(string filePath)
        {
            var extension = Path.GetExtension(filePath).ToLowerInvariant();
            return extension switch
            {
                ".html" => "text/html",
                ".css" => "text/css",
                ".js" => "application/javascript",
                ".png" => "image/png",
                ".jpg" or ".jpeg" => "image/jpeg",
                ".gif" => "image/gif",
                ".xml" => "application/xml",
                ".json" => "application/json",
                ".txt" => "text/plain",
                _ => "application/octet-stream", // Default content type
            };
        }



    }
}
