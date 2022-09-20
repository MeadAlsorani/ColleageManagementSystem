using CMS_Backend.Persistence.Repositories;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.Contracts.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ColleageManagementDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("Base")
                    );
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
            return services;
        }
    }
}
