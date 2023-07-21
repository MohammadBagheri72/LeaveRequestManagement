using HRManegment_Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovealDto:BaseDto
    {
        public bool? Aproived { get; set; }
    }
}
