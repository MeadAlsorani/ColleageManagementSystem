using CMS_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.Configurations
{
    public class EducationClassesConfiguration : IEntityTypeConfiguration<EducationClass>
    {
        public void Configure(EntityTypeBuilder<EducationClass> builder)
        {
            
            builder.HasData(
                new EducationClass
                {
                    CreationDate = DateTime.Now,
                    Id = 1,
                    ModificationDate = DateTime.Now,
                    Name = "Kindergarten"
                },
                new EducationClass
                {
                    CreationDate = DateTime.Now,
                    Id = 2,
                    ModificationDate = DateTime.Now,
                    Name = "Program support"
                },
                new EducationClass
                {
                    CreationDate = DateTime.Now,
                    Id = 3,
                    ModificationDate = DateTime.Now,
                    Name = "Music "
                },
                new EducationClass
                {
                    CreationDate = DateTime.Now,
                    Id = 4,
                    ModificationDate = DateTime.Now,
                    Name = "Languages"
                }
                );
        }
    }
}
