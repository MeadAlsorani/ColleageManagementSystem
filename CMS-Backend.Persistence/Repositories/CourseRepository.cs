using AutoMapper;
using CMS_Backend.Persistence.ExtensionMethods;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        private readonly IMapper mapper;

        public CourseRepository(ColleageManagementDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public override async Task<IReadOnlyList<Course>> GetAll()
        {
            var records = await dbContext.Courses.AsNoTracking().Include(x => x.Class).Include(x => x.Staff).ToListAsync();
            return records;
        }
        public override async Task<PaginationResponse<Course>> GetAllWithPagination(ListPaginationRequest request)
        {
            var records = await dbContext.Courses
                .AsNoTracking()
                .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 : (
                x.LessonDuration.ToString() == request.SearchStatement ||
                x.Price.ToString() == request.SearchStatement ||
                x.Class!.Name.ToLower().Contains(request.SearchStatement)||
                x.Name.ToLower().Contains(request.SearchStatement)
                ))
                .ApplyPagination(request)
                .Include(x => x.Class)
                .Include(x => x.Staff)
                .ToListAsync();
            var count = await dbContext.Courses.AsNoTracking().CountAsync();
            return new PaginationResponse<Course> { Count = count, Records = records };
        }

        public async Task<IReadOnlyList<ClassListDto>> GetClassList()
        {
            var records = await dbContext.EducationClass.AsNoTracking().ToListAsync();
            return mapper.Map<IReadOnlyList<ClassListDto>>(records);
        }

        public async Task<CourseDetailsDto> GetCourseWithStudents(int courseId)
        {
            var course = await dbContext.Courses.Include(x => x.StudentCourses).Include(x => x.Class).Include(x => x.Staff).AsNoTracking()
                .SingleOrDefaultAsync(z => z.Id == courseId);
            var students = await dbContext.Students.Where(x => course.StudentCourses.Select(z => z.StudentId).Contains(x.Id)).ToListAsync();
            var mappedCourse = mapper.Map<CourseDetailsDto>(course);
            mappedCourse.Students = mapper.Map<List<StudentDto>>(students);
            return mappedCourse;
        }
    }
}
