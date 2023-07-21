using AutoMapper;
using HRManegment_Application.DTOs.LeaveRequest;
using HRManegment_Application.Features.LeaveRequests.Requests.Queries;
using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRManegment_Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private IMapper _mapper;
        public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestWithDetail(request.Id);
            if (leaveRequest==null)
            {
                throw new HRManegment_Application.Exceptions.NotFoundException(nameof(LeaveRequest), request.Id);
            }

            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }
    }
}
