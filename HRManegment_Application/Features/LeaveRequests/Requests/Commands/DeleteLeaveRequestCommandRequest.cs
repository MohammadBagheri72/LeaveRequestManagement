using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Features.LeaveRequests.Requests.Commands
{
    public class DeleteLeaveRequestCommandRequest:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
