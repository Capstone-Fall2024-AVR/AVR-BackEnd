using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Entities
{
    [Table("ApiLogs")]
    public class ApiLog
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Path { get; set; }

        [Required]
        public string Method { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }
    }

}
