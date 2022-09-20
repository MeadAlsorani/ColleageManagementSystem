using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    // Manager
                    RoleId= "8a0cc8f0-7259-4684-8b1f-9af5ee16e3bd",
                    UserId= "8afb94e5-e55e-4479-9b40-8116628c3c82"
                },
                new IdentityUserRole<string>
                {
                    //Admin
                    RoleId = "6ebd984a-45cf-4fcd-b48d-ad6ae71846b1",
                    UserId = "09dd9295-5477-4818-8755-f73bfa6b6fc9"
                },
                new IdentityUserRole<string>
                {
                    //Accountant
                    RoleId = "252c11a8-7035-423e-be2c-85b006a8a8c4",
                    UserId = "079b9eeb-d67c-4f53-b14e-cbbf0739e2bc"
                },
                new IdentityUserRole<string>
                {
                    //Reciptionist
                    RoleId = "dde1228b-9b59-42eb-90cb-a480ff5910a7",
                    UserId = "4fb55069-1031-49b9-9f43-ee196fb67650"
                });
        }
    }
}
