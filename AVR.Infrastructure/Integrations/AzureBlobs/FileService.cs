using AVR.Domain.Interfaces;
using SharpCompress.Archives.Rar;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
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
            string htmlFileUrl = null;
            var tempFolder = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        
            try
            {
                Directory.CreateDirectory(tempFolder);
                var format = DetectFileFormat(fileStream);
        
                if (format == "ZIP")
                {
                    using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Read))
                    {
                        foreach (var entry in archive.Entries)
                        {
                            var filePath = Path.Combine(tempFolder, entry.FullName);
                            var directory = Path.GetDirectoryName(filePath);

                            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
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
                    using (var archive = RarArchive.Open(fileStream))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            var relativePath = entry.Key.Replace("\\", "/");
                            var filePath = Path.Combine(tempFolder, relativePath);
                            var directory = Path.GetDirectoryName(filePath);

                            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
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
                    // Nếu định dạng không phải ZIP hoặc RAR, upload trực tiếp file
                    var uploadedFileUrl = await _azureBlobService.UploadFileAsync(fileStream, "direct-upload-file", "application/octet-stream");
                    return uploadedFileUrl; // Trả về URL của file được upload trực tiếp
                }
        
                var allFilePaths = Directory.GetFiles(tempFolder, "*.*", SearchOption.AllDirectories);
                var uploadTasks = new List<Task>();
        
                foreach (var filePath in allFilePaths)
                {
                    uploadTasks.Add(Task.Run(async () =>
                    {
                        using var fileStreamToUpload = File.OpenRead(filePath);
                        var relativeFilePath = Path.GetRelativePath(tempFolder, filePath).Replace("\\", "/");
                        var contentType = GetContentType(filePath);
                        var uploadedFileUrl = await _azureBlobService.UploadFileAsync(fileStreamToUpload, relativeFilePath, contentType);
        
                        if (Path.GetExtension(filePath).ToLower() == ".html")
                        {
                            htmlFileUrl = uploadedFileUrl;
                        }
                    }));
                }
        
                // Chờ tất cả các file được upload
                await Task.WhenAll(uploadTasks);
            }
            finally
            {
                if (Directory.Exists(tempFolder))
                {
                    Directory.Delete(tempFolder, true);
                }
            }
        
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
