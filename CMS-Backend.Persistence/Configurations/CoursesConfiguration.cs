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
    public class CoursesConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            int id = 0;
            builder.HasData(
            #region Kindergarten
                new Course
                {
                    ClassId = 1,
                    Name = "KG1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 1,
                    Name = "KG2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 1,
                    Name = "KG3",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }
                #endregion

                #region Program Support
                , new Course
                {
                    ClassId = 2,
                    Name = "Level 1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 2,
                    Name = "Level 2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 2,
                    Name = "Level 3",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 2,
                    Name = "Level 4",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 2,
                    Name = "Level 5",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 2,
                    Name = "Level 6",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 2,
                    Name = "Level 7",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Course
                {
                    ClassId = 2,
                    Name = "Level 8",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }
                #endregion

                #region Music
                , new Course
                {
                    ClassId = 3,
                    Name = "Music",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }
                #endregion

                #region Languages
                , new Course
                {
                    ClassId = 4,
                    Name = "German A1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }
                , new Course
                {
                    ClassId = 4,
                    Name = "German A2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "German B1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "German B2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "German C1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "German C2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "German Conversation Course",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Turkish A1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Turkish A2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Turkish B1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Turkish B2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Turkish C1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Turkish C2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Turkish Conversation Course",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Arabic A1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Arabic A2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "Arabic B1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "French A1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "French A2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "French B1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "French B2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "French C1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "French C2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "English A1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "English A2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "English B1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "English B2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "English C1",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "English C2",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }, new Course
                {
                    ClassId = 4,
                    Name = "English Conversation Course",
                    Price = 0,
                    Id = ++id,
                    StartDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    LessonDuration = 0,
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }
                #endregion
                );
        }
    }
}
