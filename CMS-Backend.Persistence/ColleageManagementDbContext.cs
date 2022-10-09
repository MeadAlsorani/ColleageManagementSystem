using CMS_Backend.Persistence.Configurations;
using CMS_BackEnd.Domain;
using CMS_BackEnd.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence
{
    public class ColleageManagementDbContext : DbContext
    {
        public ColleageManagementDbContext(DbContextOptions<ColleageManagementDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ColleageManagementDbContext).Assembly);
            modelBuilder.ApplyConfiguration(new EducationClassesConfiguration());
            modelBuilder.ApplyConfiguration(new CoursesConfiguration());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseModelClass>()
                .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified))
            {
                entry.Entity.ModificationDate = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreationDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<IncomeTransaction> IncomeTransactions { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<OutcomeTransaction> OutcomeTransactions { get; set; }
        public DbSet<SalaryTemplate> SalaryTemplates { get; set; }
        public DbSet<SessionYear> SessionYears { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

    }
}
