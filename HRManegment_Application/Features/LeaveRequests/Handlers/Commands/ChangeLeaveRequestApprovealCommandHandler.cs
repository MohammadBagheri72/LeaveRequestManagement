using AutoMapper;
using HRManegment_Application.Features.LeaveRequests.Requests.Commands;
using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRManegment_Application.Features.LeaveRequests.Handlers.Commands
{
    public class ChangeLeaveRequestApprovealCommandHandler : IRequestHandler<ChangeLeaveRequestApprovealCommandRequest, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private IMapper _mapper;
        public ChangeLeaveRequestApprovealCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(ChangeLeaveRequestApprovealCommandRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.ChangeLeaveRequestApprovealDto.Id);
            if(leaveRequest == null)
            {
                throw new HRManegment_Application.Exceptions.NotFoundException(nameof(LeaveRequest), request.ChangeLeaveRequestApprovealDto.Id);
            }
            await _leaveRequestRepository.ChageApprovalStatus(leaveRequest, request.ChangeLeaveRequestApprovealDto.Aproived);
            return Unit.Value;
        }
    }
}
