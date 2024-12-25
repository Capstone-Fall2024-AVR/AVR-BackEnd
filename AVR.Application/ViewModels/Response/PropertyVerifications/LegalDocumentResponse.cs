using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Response.PropertyVerifications
{
    public class LegalDocumentResponse : IMapFrom<LegalDocument>
    {
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
    }
}
