using AutoMapper;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
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
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly IMapper mapper;

        public StudentRepository(ColleageManagementDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task ApproveStudent(int id)
        {
            var student = await dbContext.Students.FindAsync(id);
            if (student == null)
            {
                throw new KeyNotFoundException("Student is not exists");
            }
            student.Approved = true;
            await dbContext.SaveChangesAsync();
        }

        public async Task CreateStudentWithCourses(CreateStudentDto student)
        {
            var record = mapper.Map<Student>(student);
            dbContext.Add(record);
            await dbContext.SaveChangesAsync();
        }

        public async Task<StudentCoursesDto> GetStudentWithCourses(int id)
        {
            var records = await dbContext.Students
                .Include(x => x.StudentCourses)
                .ThenInclude(v => v.Course)
                .AsNoTracking()
                .FirstOrDefaultAsync(z => z.Id == id);
            var student = mapper.Map<StudentCoursesDto>(records);
            student.Coureses = mapper.Map<IReadOnlyList<CourseListDto>>(records?.StudentCourses.Select(z => z.Course));
            return student;
        }

        public override Task Update(Student entity)
        {
            return base.Update(entity);
        }
    }
}
