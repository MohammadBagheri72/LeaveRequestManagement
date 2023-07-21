using AutoMapper;
using HRManegment_Application.DTOs.LeaveRequest.Validator;
using HRManegment_Application.Features.LeaveRequests.Requests.Commands;
using HRManegment_Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRManegment_Application.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommandRequest, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private IMapper _mapper;
        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommandRequest request, CancellationToken cancellationToken)
        {
            var validator=new UpdateLeaveRequestDtoValidator(_leaveRequestRepository);
            var validation = await validator.ValidateAsync(request.UpdateLeaveRequestDto);
            if (!validation.IsValid)
            {
                throw new HRManegment_Application.Exceptions.ValidationException(validation);
            }

            var leaveRequest = await _leaveRequestRepository.Get(request.UpdateLeaveRequestDto.Id);
            _mapper.Map(request.UpdateLeaveRequestDto, leaveRequest);
            await _leaveRequestRepository.Update(leaveRequest);
            return Unit.Value;
        }
    }
}
