using HRManegment_Application.DTOs.LeaveAllocation;
using MediatR;

namespace HRManegment_Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommandRequest:IRequest<Unit>
    {
        public UpdateLeaveAllocationDto UpdateLeaveAllocationDto { get; set; }
    }
}
