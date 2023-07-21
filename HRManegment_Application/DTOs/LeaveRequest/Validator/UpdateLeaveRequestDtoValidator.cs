using FluentValidation;
using HRManegment_Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveRequest.Validator
{
    public class UpdateLeaveRequestDtoValidator:AbstractValidator<UpdateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        public UpdateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;

            Include(new ILeaveRequestDtoValidator(_leaveRequestRepository));
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
