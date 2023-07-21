using AutoMapper;
using HRManegment_Application.DTOs.LeaveAllocation;
using HRManegment_Application.DTOs.LeaveRequest;
using HRManegment_Application.Features.LeaveAllocations.Requests.Queries;
using HRManegment_Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRManegment_Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private IMapper _mapper;
        public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var leaveAllicationList=await _leaveAllocationRepository.GetLeaveAllocationsWithDetail();
            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllicationList);
        }
    }
}
