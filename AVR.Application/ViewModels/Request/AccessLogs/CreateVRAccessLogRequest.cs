using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.AccessLogs
{
    public class CreateVRAccessLogRequest : IMapFrom<VR_Access_Log>
    {
        public Guid VRExperienceID { get; set; }
    }
}
