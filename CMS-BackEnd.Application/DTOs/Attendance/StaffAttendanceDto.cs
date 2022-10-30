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
    public class StaffAttendanceDto
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public StaffListDto? Staff { get; set; }
    }
}
