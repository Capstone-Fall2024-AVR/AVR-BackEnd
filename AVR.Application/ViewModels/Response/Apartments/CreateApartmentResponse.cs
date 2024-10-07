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
        public string Area { get; set; }
        public string NumberOfRooms { get; set; }
        public string Location { get; set; }
        public string Direction { get; set; }
        public string PricePerSquareMeter { get; set; }
        public string RecommendedPrice { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public DateTimeOffset ExpiryDate { get; set; }
        public ApartmentStatus ApartmentStatus { get; set; }
        public ApartmentType ApartmentType { get; set; }
    }
}
