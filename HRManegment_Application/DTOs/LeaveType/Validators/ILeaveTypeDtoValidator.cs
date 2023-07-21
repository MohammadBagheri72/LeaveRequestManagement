using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveType.Validators
{
    public class ILeaveTypeDtoValidator:AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(l => l.Name).NotEmpty().WithMessage("{ProprtyName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{ProprtyName} is maximum50");
            RuleFor(l => l.DefaultDay)
                .NotEmpty().WithMessage("{ProprtyName} is required")
                .GreaterThan(0)
                .LessThan(100);
        }
    }
}
