using AVR.Application.Mapper;
using AVR.Application.ViewModels.Response.VRExperiences;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.Apartments
{
    public class CreateApartmentForOwnerResponse : IMapFrom<Apartment>
    {
        public Guid ApartmentID { get; set; }
        public string ApartmentName { get; set; }
        public string ApartmentCode { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public decimal Area { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public string Location { get; set; }
        public string Direction { get; set; }
        public decimal PricePerSquareMeter { get; set; }
        public decimal RecommendedPrice { get; set; }
        public DateTimeOffset EffectiveStartDate { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
        public string ApartmentStatus { get; set; }
        public string ApartmentType { get; set; }
        public string PossessionType { get; set; }
        public BalconyDirection BalconyDirection { get; set; }
        public string ProjectApartmentName { get; set; }
        public Guid ProjectApartmentID { get; set; }
        public string Building { get; set; }  // Tòa nhà
        public int Floor { get; set; } // Tầng
        public int RoomNumber { get; set; } // Số phòng

        public List<ApartmentImageResponse> Images { get; set; } = new List<ApartmentImageResponse>();
        public string OwnerName { get; set; }
        public List<VRResponse> VRVideoUrls { get; set; } // Danh sách các URL video VR
    }

}
