using FluentValidation;
using HRManegment_Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationDtoValidator:AbstractValidator<CreateLeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public CreateLeaveAllocationDtoValidator(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository= leaveAllocationRepository;
            Include(new ILeaveAllocatinoDtoValidator(_leaveAllocationRepository));
        }
    }
}
