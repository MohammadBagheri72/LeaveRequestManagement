using HRManegment_Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Persistence.Configurations.Entities
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData(
                new LeaveType()
                {
                    Id = 1,
                    DefaultDay = 10,
                    Name = "Vacation"
                },
               new LeaveType()
                {
                    Id = 2,
                    DefaultDay = 12,
                    Name = "Sick"
  }
                );
        }
    }
}
