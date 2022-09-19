using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Course
{
    public class CourseDetailsDto:BaseDto
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public int LessonDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }
        public IReadOnlyList<StudentDto> Students { get; set; }
    }
}
