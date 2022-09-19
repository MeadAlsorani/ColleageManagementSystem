using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts;
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
        private readonly DbContext dbContext;

        public StudentRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task CreateStudentWithCourses(CreateStudentDto student)
        {

            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<StudentCoursesDto>> GetStudentWithCourses(int id)
        {
            throw new NotImplementedException();
        }
    }
}
