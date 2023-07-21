﻿using HRManegment_Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManegment_Domain
{
    public class LeaveRequest: BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequest { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Aproived { get; set; }
        public bool Cancelled { get; set; }

        public int LeaveTypeId { get; set; }

        public LeaveType LeaveType { get; set; }
    }
}
