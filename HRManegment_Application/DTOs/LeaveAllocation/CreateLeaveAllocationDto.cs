using HRManegment_Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDto:BaseDto,ILevelAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int Priod { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
