using HRManegment_Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetail();
        Task<LeaveRequest> GetLeaveRequestWithDetail(int id);
        Task ChageApprovalStatus(LeaveRequest leaveRequest,bool? approvalStatus);
    }
}
