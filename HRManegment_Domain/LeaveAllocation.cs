using HRManegment_Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Domain
{
    public class LeaveAllocation: BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public int Priod { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }
    }
}
