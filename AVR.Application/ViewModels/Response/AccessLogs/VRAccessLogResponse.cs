using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.AccessLogs
{
    public class VRAccessLogResponse : IMapFrom<VR_Access_Log>
    {
        public Guid VRAccessLogID { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public Guid VRExperienceID { get; set; }
        public string Video_url_file { get; set; } // Thêm tiêu đề trải nghiệm VR
    }

}
