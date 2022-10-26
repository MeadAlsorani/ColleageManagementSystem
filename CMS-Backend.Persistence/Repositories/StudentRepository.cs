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
                .ThenInclude(z => z.Class)
                .AsNoTracking()
                .FirstOrDefaultAsync(z => z.Id == id);
            var student = mapper.Map<StudentCoursesDto>(records);
            student.Coureses = mapper.Map<IReadOnlyList<CourseListDto>>(records?.StudentCourses.Select(z => z.Course));
            return student;
        }
        public override async Task<PaginationResponse<Student>> GetAllWithPagination(ListPaginationRequest request)
        {
            var records = await dbContext.Students.AsNoTracking()
                .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 : (
                string.Concat(x.FirstName, " ", x.LastName).Contains(request.SearchStatement) ||
                (!string.IsNullOrWhiteSpace(x.Address) && x.Address.Contains(request.SearchStatement)) ||
                x.ClassLevel.ToString() == request.SearchStatement ||
                (!string.IsNullOrWhiteSpace(x.PhoneNumber) && x.PhoneNumber.Contains(request.SearchStatement)) ||
                (!string.IsNullOrWhiteSpace(x.GuardianName) && x.GuardianName.Contains(request.SearchStatement)) ||
                (!string.IsNullOrWhiteSpace(x.SchoolName) && x.SchoolName.Contains(request.SearchStatement)) 
                ))
                .ApplyPagination(request)
                .Include(x => x.StudentCourses)
                .ToListAsync();
            var count = await dbContext.Students.CountAsync();
            return new PaginationResponse<Student>() { Count = count, Records = records };
        }
        public override async Task<IReadOnlyList<Student>> GetAll()
        {
            var records = await dbContext.Students.AsNoTracking().Include(x => x.StudentCourses).ToListAsync();
            return records;
        }
        public override async Task<Student> Get(int id)
        {
            var records = await dbContext.Students.AsNoTracking().Include(x => x.StudentCourses).FirstOrDefaultAsync(x => x.Id == id);
            return records;
        }
        public override async Task Update(Student entity)
        {
            var old = dbContext.StudentCourses.Where(x => x.StudentId == entity.Id).AsNoTracking();

            if (old.Count() > 0)
            {
                dbContext.StudentCourses.RemoveRange(old);
                //dbContext.Entry(old).State = EntityState.Deleted;
                await dbContext.SaveChangesAsync();
            }

            dbContext.Update(entity);
            await dbContext.SaveChangesAsync();
            return;
        }
        public override Task Delete(int key)
        {
            var attendances = dbContext.Attendances.Where(x => x.StudentId == key);
            dbContext.RemoveRange(attendances);
            return base.Delete(key);
        }
    }
}
