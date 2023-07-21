using HRManegment_Application.DTOs.LeaveRequest;
using MediatR;

namespace HRManegment_Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommandRequest:IRequest<Unit>
    {
        public UpdateLeaveRequestDto UpdateLeaveRequestDto { get; set; }
    }
}
