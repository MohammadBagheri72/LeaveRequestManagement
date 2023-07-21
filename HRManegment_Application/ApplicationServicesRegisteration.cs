using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace HRManegment_Application
{
    public static class ApplicationServicesRegisteration
    {
        public static void ConfigurApplicatinServices(this IServiceCollection services)
        {
           // services.AddAutoMapper(typeof(MappingProfiles));
           services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
