using HRManegment_Application.DTOs.Common;
using System;


namespace HRManegment_Application.DTOs.LeaveRequest
{
    public class CreateLeaveRequestDto:BaseDto,ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequest { get; set; }
        public string RequestComments { get; set; }
        public int LeaveTypeId { get; set; }

       
    }
}
