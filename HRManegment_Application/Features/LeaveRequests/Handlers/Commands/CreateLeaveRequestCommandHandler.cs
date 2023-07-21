using AutoMapper;
using HRManegment_Application.DTOs.LeaveRequest.Validator;
using HRManegment_Application.Features.LeaveRequests.Requests.Commands;
using HRManegment_Application.Contracts.Persistence;
using HRManegment_Application.Responses;
using HRManegment_Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HRManegment_Application.Contracts.Infrastructure;
using HRManegment_Application.Models;

namespace HRManegment_Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommandRequest, BaseCommandResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private IMapper _mapper;
        private IEmailSender _emailSender;
        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper,IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveRequestCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var validator=new CreateLeaveRequestDtoValidator(_leaveRequestRepository);
            var validation = await validator.ValidateAsync(request.CreateLeaveRequestDto);
            if (!validation.IsValid)
            {
                // throw new HRManegment_Application.Exceptions.ValidationException(validation);
                response.Succses = false;
                response.Message = "Creation Failed";
                response.Errors=validation.Errors.Select(e => e.ErrorMessage).ToList();
            }

            var leaveRequest = _mapper.Map<LeaveRequest>(request.CreateLeaveRequestDto);
            leaveRequest=await _leaveRequestRepository.Add(leaveRequest);

            response.Succses = true;
            response.Message = "Creation Success";
            response.Id = leaveRequest.Id;

            var email = new Email()
            {
                To="mohammad.bageri7@gmail.com",
                Subject="Creation",
                Body=$"Your Request From {leaveRequest.StartDate} "+
                $"To {leaveRequest.EndDate} "+
                $"Created Success"
            };
            try
            {
                await _emailSender.SendEmail(email);
            }
            catch (Exception)
            {
                //log
                throw;
            }

            return response;
        }
    }
}
