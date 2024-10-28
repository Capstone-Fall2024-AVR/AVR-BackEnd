using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Projects
{
    public class ProjectImageResponse : IMapFrom<ProjectImage>
    {
        public Guid ProjectImageID { get; set; } // ID của ảnh dự án
        public string Description { get; set; } // Mô tả của ảnh
        public string Url { get; set; } // Đường dẫn đến ảnh (URL)
    }
}

