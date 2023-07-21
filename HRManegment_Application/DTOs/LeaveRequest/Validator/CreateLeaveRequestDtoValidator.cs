using FluentValidation;
using HRManegment_Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.DTOs.LeaveRequest.Validator
{
    public class CreateLeaveRequestDtoValidator:AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public CreateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository=leaveRequestRepository;

            Include(new ILeaveRequestDtoValidator(_leaveRequestRepository));

        }
    }
}
