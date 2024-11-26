using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.AccessLogs
{
    public class ProjectAccessLogResponse: IMapFrom<ProjectAccessLog>
    {
        public Guid ProjectAccessLogID { get; set; }
        public DateTimeOffset AccessDate { get; set; }
        public Guid ProjectApartmentID { get; set; }
        public string ProjectApartmentName { get; set; } // Thêm tên dự án
    }

}
