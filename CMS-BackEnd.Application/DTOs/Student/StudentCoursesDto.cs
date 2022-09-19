using CMS_BackEnd.Application.DTOs.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Student
{
    public class StudentCoursesDto : StudentDto
    {
        public IReadOnlyList<CourseListDto> Coureses { get; set; }
    }
}
