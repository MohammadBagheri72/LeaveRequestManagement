using HRManegment_Application.Features.LeaveAllocations.Requests.Commands;
using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRManegment_Application.Features.LeaveAllocations.Handlers.Commadns
{
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommandRequest, Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task<Unit> Handle(DeleteLeaveAllocationCommandRequest request, CancellationToken cancellationToken)
        {
            var leaveAllication = await _leaveAllocationRepository.Get(request.Id);
            if (leaveAllication == null)
            {
                throw new HRManegment_Application.Exceptions.NotFoundException(nameof(LeaveAllocation), request.Id);
            }
            await _leaveAllocationRepository.Delete(leaveAllication);
            return Unit.Value;
        }
    }
}
