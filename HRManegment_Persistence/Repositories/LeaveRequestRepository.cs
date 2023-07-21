using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Persistence.Repositories
{
    public class LeaveRequestRepository:GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly LeaveManegmentDbContext _context;
        public LeaveRequestRepository(LeaveManegmentDbContext context):base(context)
        {
            _context = context;
        }

        public async Task ChageApprovalStatus(LeaveRequest leaveRequest, bool? approvalStatus)
        {
            leaveRequest.Aproived = approvalStatus;
            await Update(leaveRequest);
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetail()
        {
            var leaveRequests = await _context.LeaveRequests.Include(t => t.LeaveType).ToListAsync();
            return leaveRequests;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetail(int id)
        {
            var leaveRequest = await _context.LeaveRequests.Include(t => t.LeaveType)
                 .Where(l => l.Id == id).FirstOrDefaultAsync();
            return leaveRequest;
        }
    }
}
