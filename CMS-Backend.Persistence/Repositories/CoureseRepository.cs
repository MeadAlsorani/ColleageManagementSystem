using AutoMapper;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.Repositories
{
    public class CoureseRepository : GenericRepository<Course>, ICourseRepository
    {
        private readonly IMapper mapper;

        public CoureseRepository(ColleageManagementDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<CourseDetailsDto> GetCourseWithStudents(int courseId)
        {
            var course = await dbContext.Courses.Include(x => x.StudentCourses).AsNoTracking()
                .SingleOrDefaultAsync(z => z.Id == courseId);
            var students = await dbContext.Students.Where(x => course.StudentCourses.Select(z => z.StudentId).Contains(x.Id)).ToListAsync();
            var mappedCourse = mapper.Map<CourseDetailsDto>(course);
            mappedCourse.Students = mapper.Map<List<StudentDto>>(students);
            return mappedCourse;
        }
    }
}
