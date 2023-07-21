using HRManegment_Application.DTOs.LeaveRequest;
using HRManegment_Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommandRequest:IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto CreateLeaveRequestDto { get; set; }
    }
}
