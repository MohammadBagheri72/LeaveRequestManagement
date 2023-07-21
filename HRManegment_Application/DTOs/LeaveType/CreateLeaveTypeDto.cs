using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveType
{
    public class CreateLeaveTypeDto:ILeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
