using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Apartments
{
    public class ApartmentImageResponse : IMapFrom<ApartmentImage>
    {
        public Guid ApartmentImageID { get; set; }
        public string ImageUrl { get; set; } // URL hình ảnh trên Firebase
        public string Description { get; set; } // Mô tả hình ảnh
    }
}
