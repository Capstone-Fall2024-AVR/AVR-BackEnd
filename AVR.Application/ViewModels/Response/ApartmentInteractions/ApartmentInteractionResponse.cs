using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.ApartmentInteractions
{
    public class ApartmentInteractionResponse : IMapFrom<ApartmentInteraction>
    {
        public Guid ApartmentInteractionID { get; set; }
        public DateTimeOffset InteractionDate { get; set; }
        public string InteractionTypes { get; set; }
        public Guid AccountID { get; set; }
        public Guid ApartmentID { get; set; }
    }
}
