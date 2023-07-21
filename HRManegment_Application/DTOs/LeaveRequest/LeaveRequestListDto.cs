using HRManegment_Application.DTOs.Common;
using HRManegment_Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto:BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public bool? Aproived { get; set; }
        public DateTime DateRequest { get; set; }
    }
}
