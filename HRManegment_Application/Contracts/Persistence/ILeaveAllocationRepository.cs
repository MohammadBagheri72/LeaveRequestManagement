using HRManegment_Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Application.Contracts.Persistence
{
    public interface ILeaveAllocationRepository:IGenericRepository<LeaveAllocation>
    {
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetail();
        Task<LeaveAllocation> GetLeaveAllocationWithDetail(int id);
    }
}
