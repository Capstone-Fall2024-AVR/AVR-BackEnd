using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Services
{
    public interface IProjectImageService
    {
        Task DeleteProjectImageAsync(Guid projectImageId);
    }
}
