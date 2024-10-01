using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace AVR.Application.ViewModels.Request.Apartments
{
    public class CreateApartmentRequest : IMapFrom<Apartment>
    {
        [Required]
        public string ApartmentName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Area { get; set; }

        [Required]
        public string NumberOfRooms { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Direction { get; set; }

        [Required]
        public string PricePerSquareMeter { get; set; }

        [Required]
        public string RecommendedPrice { get; set; }

        [Required]
        public DateTimeOffset ExpiryDate { get; set; }

        [Required]
        public ApartmentStatus ApartmentStatus { get; set; }

        [Required]
        public ApartmentType ApartmentType { get; set; }
    }
}
