using HRManegment_Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto,ILeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
