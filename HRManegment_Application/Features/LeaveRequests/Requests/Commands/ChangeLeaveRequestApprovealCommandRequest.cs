﻿using HRManegment_Application.DTOs.LeaveRequest;
using MediatR;

namespace HRManegment_Application.Features.LeaveRequests.Requests.Commands
{
    public class ChangeLeaveRequestApprovealCommandRequest:IRequest<Unit>
    {
        public ChangeLeaveRequestApprovealDto ChangeLeaveRequestApprovealDto { get; set; }
    }
}
