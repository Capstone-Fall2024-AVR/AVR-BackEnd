using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.AuthRequest
{
    public class LoginRequest : IMapFrom<Account>
    {
        [Required, EmailAddress]
        public string? Email { get; set; } = string.Empty;
        [Required]
        public string? Password { get; set; } = string.Empty;
    }
}
