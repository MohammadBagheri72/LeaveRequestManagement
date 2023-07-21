using HRManegment_Application.DTOs.LeaveType;
using MediatR;

namespace HRManegment_Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommandRequest:IRequest<Unit>
    {
        public UpdateLeaveTypeDto UpdateLeaveTypeDto { get; set; }
    }
}
