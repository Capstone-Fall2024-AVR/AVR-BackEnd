using AVR.Domain.Interfaces;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Configuration;
using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Infrastructure.Integrations.AzureBlobs
{
    public class AzureBlobService: IAzureBlobService
    {
        private readonly IConfiguration _configuration;
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _containerName;

        public AzureBlobService(IConfiguration configuration)
        {
            _configuration = configuration;
            var connectionString = configuration["AzureBlobStorage:ConnectionString"];
            _containerName = configuration["AzureBlobStorage:ContainerName"];
            _blobServiceClient = new BlobServiceClient(connectionString);
        }

        public async Task<string> UploadFileAsync(Stream fileStream, string fileName, string contentType)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient(_containerName);
        
            // Tạo container nếu chưa tồn tại
            await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);
        
            var blobClient = containerClient.GetBlockBlobClient(fileName);
        
            // Kích thước của mỗi block (4 MB trong ví dụ này)
            const int blockSize = 4 * 1024 * 1024;
            var blockList = new List<string>();
            byte[] buffer = new byte[blockSize];
            int bytesRead;
            int blockNumber = 0;
        
            while ((bytesRead = await fileStream.ReadAsync(buffer, 0, blockSize)) > 0)
            {
                var blockId = Convert.ToBase64String(Encoding.UTF8.GetBytes($"block-{blockNumber:D5}"));
                using var memoryStream = new MemoryStream(buffer, 0, bytesRead);
        
                // Upload block lên Blob Storage
                await blobClient.StageBlockAsync(blockId, memoryStream);
                blockList.Add(blockId);
                blockNumber++;
            }
        
            // Commit các block đã upload
            await blobClient.CommitBlockListAsync(blockList, new BlobHttpHeaders
            {
                ContentType = contentType
            });
        
            // Trả về URL của file đã upload
            return blobClient.Uri.ToString();
        }




    }
}
