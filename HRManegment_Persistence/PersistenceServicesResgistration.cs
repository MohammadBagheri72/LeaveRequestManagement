using HRManegment_Application.Contracts.Persistence;
using HRManegment_Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManegment_Persistence
{
    public static class PersistenceServicesResgistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<LeaveManegmentDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LeaveManegmentConnectionString"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveRequestRepository,LeaveRequestRepository>();
            services.AddScoped<ILeaveAllocationRepository,LeaveAllocationRepository>();

            return services;
        }
    }
}
