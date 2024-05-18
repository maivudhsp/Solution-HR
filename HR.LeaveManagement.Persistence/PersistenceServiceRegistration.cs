using HR.LeaveManagement.Application.Contacts;
using HR.LeaveManagement.Persistence.DatabaseContext;
using HR.LeaveManagement.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServies(this IServiceCollection services,
            IConfiguration configuration) 
        {
            services.AddDbContext<HrDatabaseContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("HrDatabaseConnectionString"));
            });
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            return services;
        }
    }
}
