using AutoMapper;
using HRManegment_Application.DTOs.LeaveType;
using HRManegment_Application.Features.LeaveTypes.Requests.Queries;
using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRManegment_Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private IMapper _mapper;
        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
           var leaveType = await _leaveTypeRepository.Get(request.Id);
            if(leaveType == null)
            {
                throw new HRManegment_Application.Exceptions.NotFoundException(nameof(LeaveType), request.Id);
            }
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
