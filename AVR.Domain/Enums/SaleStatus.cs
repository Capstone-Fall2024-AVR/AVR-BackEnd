using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Enums
{
    public enum SaleStatus
    {
        DangMoBan = 1,   // Đang mở bán cho căn hộ mới
        DaBanGiao = 2,   // Đã bàn giao cho khách hàng (đã có chủ sở hữu)
        ChuaBan = 3,     // Căn hộ vẫn còn trong dự án nhưng chưa được bán
    }

}
