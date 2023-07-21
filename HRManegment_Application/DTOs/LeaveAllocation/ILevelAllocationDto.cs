using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveAllocation
{
    public interface ILevelAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int Priod { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
