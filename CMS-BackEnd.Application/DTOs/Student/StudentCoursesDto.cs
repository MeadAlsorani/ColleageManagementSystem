using CMS_BackEnd.Application.DTOs.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Student
{
    public class StudentCoursesDto 
    {
        public string FullName { get; set; }
        public string GuardianName { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ClassLevel { get; set; }
        public string SchoolName { get; set; }
        public DateTime RegisterationDate { get; set; }
        public string Approved { get; set; } = "";
        public IReadOnlyList<CourseListDto> Coureses { get; set; }
    }
}
