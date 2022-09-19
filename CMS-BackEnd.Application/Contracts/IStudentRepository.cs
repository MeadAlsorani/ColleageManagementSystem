using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Contracts
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        public Task<IReadOnlyList<StudentCoursesDto>> GetStudentWithCourses(int id);
        public Task CreateStudentWithCourses(CreateStudentDto student);
    }
}
