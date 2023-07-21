using FluentValidation;
using HRManegment_Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveRequest.Validator
{
    public class ILeaveRequestDtoValidator:AbstractValidator<ILeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public ILeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;
            RuleFor(p => p.StartDate)
               .LessThan(p => p.EndDate)
               .WithMessage("{PropertyName} must be less than {ComprisonProperty}");
            RuleFor(p => p.EndDate)
                .GreaterThan(p => p.StartDate)
                .WithMessage("{PropertyName} must be after than {ComprisonProperty}");
            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var leaveRequest = await _leaveRequestRepository.Exist(id);
                    return !leaveRequest;
                })
                .WithMessage("{PropertyName} must be exist");

        }
    }
}
