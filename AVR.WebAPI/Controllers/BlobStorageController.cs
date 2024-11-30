using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AVR.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/blob-storage")]
    public class BlobStorageController : ControllerBase
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        public BlobStorageController(IConfiguration configuration)
        {
            _connectionString = configuration["AzureBlobStorage:ConnectionString"]; // Chuỗi kết nối Azure Blob Storage
            _containerName = configuration["AzureBlobStorage:ContainerName"]; // Tên container
        }

        /// <summary>
        /// Upload file lên Azure Blob Storage
        /// </summary>
        /// <param name="file">File được tải lên từ client</param>
        /// <returns>URL của file trên Blob Storage</returns>
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("File không hợp lệ.");
            }

            try
            {
                // Tạo BlobServiceClient và BlobContainerClient
                var blobServiceClient = new BlobServiceClient(_connectionString);
                var containerClient = blobServiceClient.GetBlobContainerClient(_containerName);

                // Tạo container nếu chưa tồn tại
                await containerClient.CreateIfNotExistsAsync();

                // Đặt tên file trên Blob Storage
                var blobName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // Đảm bảo tên file là duy nhất
                var blobClient = containerClient.GetBlobClient(blobName);

                // Upload file lên Blob Storage
                using (var stream = file.OpenReadStream())
                {
                    await blobClient.UploadAsync(stream, true);
                }

                // Trả về URL của file
                var fileUrl = blobClient.Uri.ToString();
                return Ok(new { FileUrl = fileUrl });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi: {ex.Message}");
            }
        }
    }
}
