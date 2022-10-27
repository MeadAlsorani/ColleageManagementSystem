using CMS_BackEnd.Identity.Models;
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
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "09dd9295-5477-4818-8755-f73bfa6b6fc9",
                    UserName = "admin@zade.com",
                    Email = "admin@zade.com",
                    EmailConfirmed = true,
                    FirstName = "Application",
                    LastName = "Admin",
                    NormalizedEmail = "ADMIN@ZADE.COM",
                    NormalizedUserName = "ADMIN@ZADE.COM",
                    PasswordHash = hasher.HashPassword(null, "s0r@n!@me@d")
                },
                new ApplicationUser
                {
                    Id = "8afb94e5-e55e-4479-9b40-8116628c3c82",
                    UserName = "manager@zade.com",
                    Email = "manager@zade.com",
                    EmailConfirmed = true,
                    FirstName = "Application",
                    LastName = "Manager",
                    NormalizedEmail = "MANAGER@ZADE.COM",
                    NormalizedUserName = "MANAGER@ZADE.COM",
                    PasswordHash = hasher.HashPassword(null, "me@d@s0r@n!@")
                },
                new ApplicationUser
                {
                    Id = "079b9eeb-d67c-4f53-b14e-cbbf0739e2bc",
                    UserName = "accountant@zade.com",
                    Email = "accountant@zade.com",
                    EmailConfirmed = true,
                    FirstName = "Application",
                    LastName = "Accountant",
                    NormalizedEmail = "ACCOUNTANT@ZADE.COM",
                    NormalizedUserName = "ACCOUNTANT@ZADE.COM",
                    PasswordHash = hasher.HashPassword(null, "mead@sorani")
                },
                new ApplicationUser
                {
                    Id = "4fb55069-1031-49b9-9f43-ee196fb67650",
                    UserName = "reciptionist@zade.com",
                    Email = "reciptionist@zade.com",
                    EmailConfirmed = true,
                    FirstName = "Application",
                    LastName = "Reciptionist",
                    NormalizedEmail = "RECIPTIONIST@ZADE.COM",
                    NormalizedUserName = "RECIPTIONIST@ZADE.COM",
                    PasswordHash = hasher.HashPassword(null, "mead.alsorani")
                });
        }
    }
}
