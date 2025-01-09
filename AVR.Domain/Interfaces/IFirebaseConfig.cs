using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Interfaces
{
    public interface IFirebaseConfig
    {
        Task<string> UploadImage(IFormFile file);
        Task<string> UploadFiles(string filePath);

    }
}
