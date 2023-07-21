using HRManegment_Application.DTOs.Common;
using HRManegment_Application.DTOs.LeaveType;
using System;

namespace HRManegment_Application.DTOs.LeaveRequest
{
    public class UpdateLeaveRequestDto:BaseDto,ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RequestComments { get; set; }
        public bool Cancelled { get; set; }

        public int LeaveTypeId { get; set; }
    }
}
