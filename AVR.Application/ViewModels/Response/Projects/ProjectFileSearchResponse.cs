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
        public string ProjectFileUrl { get; set; }
        public string Description { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
       
    }
}
