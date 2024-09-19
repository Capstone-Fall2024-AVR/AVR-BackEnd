using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.AuthRequest
{
    public class LoginGoogleRequest
    {
        [Required]
        public string token { get; set; }
    }
}
