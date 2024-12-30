using AVR.Application.Mapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.ProjectFile.CreateProjectFileRequest
{
    public class CreateProjectFileRequest : IMapFrom<Domain.Entities.ProjectFile>
    {
        [Required]
        public IFormFile ProjectFileUrl { get; set; }

        public string Description { get; set; }
        public DateTimeOffset? ExpiryDate { get; set; }

        [Required]
        public Guid ProjectApartmentID { get; set; }
    }
}
