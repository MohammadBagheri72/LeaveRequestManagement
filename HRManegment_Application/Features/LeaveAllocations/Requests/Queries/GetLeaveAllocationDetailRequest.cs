using HRManegment_Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest:IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
