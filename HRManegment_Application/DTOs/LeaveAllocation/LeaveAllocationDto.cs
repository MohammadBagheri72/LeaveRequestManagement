using HRManegment_Application.DTOs.Common;
using HRManegment_Application.DTOs.LeaveType;
using HRManegment_Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto,ILevelAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int Priod { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
    }
}
