using AVR.Application.Mapper;
using AVR.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.ViewModels.Request.Accounts
{
    public class UpdateAccountRequest : IMapFrom<Account>
    {
        public string? Name { get; set; } // Tên người dùng mới, không bắt buộc
        public string? PhoneNumber { get; set; } // Số điện thoại mới, không bắt buộc
        public string? Avatar { get; set; } // Avatar mới, không bắt buộc
        public bool UnlockAccount { get; set; } // Tùy chọn để mở khóa tài khoản
    }
}
