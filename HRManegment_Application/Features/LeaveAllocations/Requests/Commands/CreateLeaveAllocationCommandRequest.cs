using HRManegment_Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommandRequest:IRequest<int>
    {
      public CreateLeaveAllocationDto CreateLeaveAllocationDto;
    }
}
