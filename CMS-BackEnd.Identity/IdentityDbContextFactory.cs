using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Identity
{
    public class IdentityDbContextFactory : IDesignTimeDbContextFactory<CmsIdentityContext>
    {
        public CmsIdentityContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<CmsIdentityContext>();
            var connectionString = configuration.GetConnectionString("Identity");
            builder.UseSqlServer(connectionString);

            return new CmsIdentityContext(builder.Options);
        }
    }
}
