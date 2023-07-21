using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Features.LeaveAllocations.Requests.Commands
{
    public class DeleteLeaveAllocationCommandRequest:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
