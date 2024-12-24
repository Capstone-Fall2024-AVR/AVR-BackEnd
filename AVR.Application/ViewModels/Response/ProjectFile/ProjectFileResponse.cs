using AVR.Application.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.ProjectFile.ProjectFileResponse
{
    public class ProjectFileResponse :  IMapFrom<Domain.Entities.ProjectFile>
    {
        public Guid ProjectFileID { get; set; }
        public string ProjectFileUrl { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
        public Guid ProjectApartmentID { get; set; }
    }
}
