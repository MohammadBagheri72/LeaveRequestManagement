using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveType.Validators
{
    public class UpdateLeaveTypeDtoValidator:AbstractValidator<UpdateLeaveTypeDto>
    {
        public UpdateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
