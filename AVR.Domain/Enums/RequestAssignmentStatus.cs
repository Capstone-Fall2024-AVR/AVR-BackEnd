using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Domain.Enums
{
    public enum RequestAssignmentStatus
    {
        Pending = 1,
        InProgress = 2 ,
        Completed = 3,
        Accepted = 4,
        Rejected = 5,
        Canceled = 6
        // Thêm các trạng thái khác nếu cần
    }


}
