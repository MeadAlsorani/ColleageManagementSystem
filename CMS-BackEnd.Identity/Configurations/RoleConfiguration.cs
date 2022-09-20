using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "8a0cc8f0-7259-4684-8b1f-9af5ee16e3bd",
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                },
                new IdentityRole
                {
                    Id = "6ebd984a-45cf-4fcd-b48d-ad6ae71846b1",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = "252c11a8-7035-423e-be2c-85b006a8a8c4",
                    Name = "Accountant",
                    NormalizedName = "ACCOUNTANT"
                },
                new IdentityRole
                {
                    Id = "dde1228b-9b59-42eb-90cb-a480ff5910a7",
                    Name = "Reciptionist",
                    NormalizedName = "RECIPTIONIST"
                }
                );
        }
    }
}
