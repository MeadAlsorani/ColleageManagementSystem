using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Contracts.Features
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        public Task<StudentCoursesDto> GetStudentWithCourses(int id);
        public Task CreateStudentWithCourses(CreateStudentDto student);
        public Task ApproveStudent(int id);
        public Task<IReadOnlyList<CourseBalanceDto>> GetCourseBalances(int id);
    }
}
