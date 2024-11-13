using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Utils.GenerateCode
{
    public interface IGenerateCode
    {
        public string GenerateAptOwnerCode();
        Task<string> GenerateApartmentCode(Guid apartmentID);
        Task<string> GenerateProjectCode(Guid ProjectID);
    }
}
