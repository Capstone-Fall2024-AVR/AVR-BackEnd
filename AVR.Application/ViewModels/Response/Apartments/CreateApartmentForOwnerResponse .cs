using AVR.Application.Mapper;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Apartments
{
    public class CreateApartmentForOwnerResponse :  IMapFrom<Apartment>
    {
        public Guid ApartmentID { get; set; }
        public string ApartmentName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal Area { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public string Location { get; set; }
        public Direction Direction { get; set; }
        public decimal PricePerSquareMeter { get; set; }
        public decimal RecommendedPrice { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
        public ApartmentStatus ApartmentStatus { get; set; }
        public ApartmentType ApartmentType { get; set; }
        public BalconyDirection BalconyDirection { get; set; }
        public string ProjectApartmentName { get; set; }  // Tên dự án căn hộ
        public List<ApartmentImageResponse> Images { get; set; } = new List<ApartmentImageResponse>();
        

        // Thêm thông tin chủ sở hữu căn hộ (owner)
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }

        // Thêm URL video VR
        public string VRVideoUrl { get; set; }
    }
}
