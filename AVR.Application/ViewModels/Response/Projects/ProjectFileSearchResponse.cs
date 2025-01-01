using AVR.Application.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Projects
{
    public class ProjectFileSearchResponse : IMapFrom<Domain.Entities.ProjectFile>
    {
        public Guid ProjectFileID { get; set; }
        public string ProjectFileUrl { get; set; }
        public string Description { get; set; }
        public string ProjectFileTypes { get; set; }
        public DateTimeOffset? ExpiryDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
       
    }
}
