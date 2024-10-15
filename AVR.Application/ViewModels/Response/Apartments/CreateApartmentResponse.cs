using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Apartments
{
    public class CreateApartmentResponse : IMapFrom<Apartment>
    {
        public Guid ApartmentID { get; set; }
        public string ApartmentName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal Area { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public string Location { get; set; }
        public Direction Direction { get; set; } // Enum
        public decimal PricePerSquareMeter { get; set; }
        public decimal RecommendedPrice { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
        public string ApartmentStatus { get; set; } // Enum
        public string ApartmentType { get; set; } // Enum
        public string BalconyDirection { get; set; } // Enum

        // Thêm danh sách hình ảnh
        public List<ApartmentImageResponse> Images { get; set; } = new List<ApartmentImageResponse>();
    }
}

