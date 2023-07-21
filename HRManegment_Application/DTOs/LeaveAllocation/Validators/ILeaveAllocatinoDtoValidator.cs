using FluentValidation;
using HRManegment_Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveAllocation.Validators
{
    public class ILeaveAllocatinoDtoValidator:AbstractValidator<ILevelAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public ILeaveAllocatinoDtoValidator(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository=leaveAllocationRepository;

            RuleFor(p => p.Priod)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .GreaterThan(0).WithMessage("{PropertyName} is leasted 1");
            RuleFor(p=>p.NumberOfDays)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .GreaterThan(0).WithMessage("{PropertyName} is leasted 1");
            RuleFor(p => p.LeaveTypeId)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .GreaterThan(0).WithMessage("{PropertyName} is leasted 1")
                .MustAsync(async (id, token) =>
                {
                    var leaveallocation = await _leaveAllocationRepository.Exist(id);
                    return !leaveallocation;
                });
        }
    }
}
