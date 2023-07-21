using HRManegment_Application.DTOs.LeaveType;
using MediatR;

namespace HRManegment_Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommandRequest:IRequest<int>
    {
        public CreateLeaveTypeDto CreateLeaveTypeDto { get; set; }
    }
}
