using FluentValidation;
using HRManegment_Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveAllocation.Validators
{
    public class UpdateLeaveAllocationDtoValidator:AbstractValidator<UpdateLeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public UpdateLeaveAllocationDtoValidator(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            Include(new ILeaveAllocatinoDtoValidator(_leaveAllocationRepository));
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
