using CMS_BackEnd.Application.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Attendance
{
    public class StudentAttendanceDto
    {
        public DateTime Date { get; set; }
        public StudentDto Student { get; set; }
    }
}
