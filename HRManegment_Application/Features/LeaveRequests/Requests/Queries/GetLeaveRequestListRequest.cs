using HRManegment_Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestListRequest:IRequest<List<LeaveRequestListDto>>
    {
    }
}
