using AVR.Application.Mapper;
using AVR.Domain.Entities;
using AVR.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.ProjectProviders
{
    public class CreateAgreementUpdateRequest : IMapFrom<AgreementUpdateRequest>
    {
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề.")]
        public string RequestTitle { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập chi tiết yêu cầu.")]
        public string RequestDetails { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại cập nhật.")]
        public AgreementUpdateType AgreementUpdateType { get; set; }

        public Guid AccountID { get; set; }
    }
}
