using HRManegment_Application.Contracts.Persistence;
using HRManegment_Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Persistence.Repositories
{
    public class LeaveTypeRepository:GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManegmentDbContext _context;
        public LeaveTypeRepository(LeaveManegmentDbContext context):base(context)
        {
            _context = context;
        }
    }
}
