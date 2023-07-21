using AutoMapper;
using HRManegment_Application.DTOs.LeaveType.Validators;
using HRManegment_Application.Features.LeaveTypes.Requests.Commands;
using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HRManegment_Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommandRequest, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private IMapper _mapper;
        public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommandRequest request, CancellationToken cancellationToken)
        {
            var validator = new UpdateLeaveTypeDtoValidator();
            var validationResult =await validator.ValidateAsync(request.UpdateLeaveTypeDto);

            if (!validationResult.IsValid)
            {
                throw new HRManegment_Application.Exceptions.ValidationException(validationResult);
            }

            var leaveType = await _leaveTypeRepository.Get(request.UpdateLeaveTypeDto.Id);

            if (leaveType==null)
            {
                throw new HRManegment_Application.Exceptions.NotFoundException(nameof(LeaveType), request.UpdateLeaveTypeDto.Id);
            }

            _mapper.Map(request.UpdateLeaveTypeDto, leaveType);
            await _leaveTypeRepository.Update(leaveType);
            return Unit.Value;
        }
    }
}
