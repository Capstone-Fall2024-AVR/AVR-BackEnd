using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Interfaces
{
    public interface IFileService
    {
        Task<string> ExtractAndUploadAsync(Stream rarStream, string containerName);
    }

}
