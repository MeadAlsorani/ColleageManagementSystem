using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Attendance
{
    public class AttendanceDto : BaseDto
    {
        public DateTime Date { get; set; }
        public StaffListDto? Staff { get; set; }
        public StudentDto? Student { get; set; }
    }
}
