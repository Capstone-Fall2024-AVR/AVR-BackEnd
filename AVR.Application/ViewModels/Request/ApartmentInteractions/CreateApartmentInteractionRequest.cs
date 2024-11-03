using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.ApartmentInteractions
{
    public class CreateApartmentInteractionRequest : IMapFrom<ApartmentInteraction>
    {
        public Guid AccountID { get; set; }
        public Guid ApartmentID { get; set; }
        public InteractionType InteractionTypes { get; set; }
    }
}
