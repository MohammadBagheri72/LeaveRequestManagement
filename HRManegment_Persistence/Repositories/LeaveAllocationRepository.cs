using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Persistence.Repositories
{
    public class LeaveAllocationRepository:GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly LeaveManegmentDbContext _context;
        public LeaveAllocationRepository(LeaveManegmentDbContext context):base(context)
        {
            _context = context;
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetail()
        {
            var leaveAllocations = await _context.LeaveAllocations.Include(t => t.LeaveType).ToListAsync();
            return leaveAllocations;
        }

        public async Task<LeaveAllocation> GetLeaveAllocationWithDetail(int id)
        {
            var leaveAllocation = await _context.LeaveAllocations.Include(t => t.LeaveType)
                .FirstOrDefaultAsync(l=>l.Id == id);
            return leaveAllocation;
        }
    }
}
