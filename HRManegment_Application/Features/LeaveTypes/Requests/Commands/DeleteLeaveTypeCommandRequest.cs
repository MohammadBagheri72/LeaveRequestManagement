using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Features.LeaveTypes.Requests.Commands
{
    public class DeleteLeaveTypeCommandRequest:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
