using HRManegment_Application.DTOs.Common;
using HRManegment_Application.DTOs.LeaveType;
using HRManegment_Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto : BaseDto,ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequest { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Aproived { get; set; }
        public bool Cancelled { get; set; }

        public int LeaveTypeId { get; set; }

        public LeaveTypeDto LeaveType { get; set; }
    }
}
