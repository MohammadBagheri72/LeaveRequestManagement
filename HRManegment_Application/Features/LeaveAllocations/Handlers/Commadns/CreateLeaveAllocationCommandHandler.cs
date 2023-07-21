using AutoMapper;
using FluentValidation.Results;
using HRManegment_Application.DTOs.LeaveAllocation.Validators;
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
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommandRequest, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private IMapper _mapper;
        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveAllocationCommandRequest request, CancellationToken cancellationToken)
        {
            var validaitor = new CreateLeaveAllocationDtoValidator(_leaveAllocationRepository);
            var validationResult =await validaitor.ValidateAsync(request.CreateLeaveAllocationDto);
            if (validationResult.IsValid == false)
            {
                throw new HRManegment_Application.Exceptions.ValidationException(validationResult);
            }
            var leaveAllocation = _mapper.Map<LeaveAllocation>(request.CreateLeaveAllocationDto);
            leaveAllocation=await _leaveAllocationRepository.Add(leaveAllocation);
            return leaveAllocation.Id;
        }
    }
}
