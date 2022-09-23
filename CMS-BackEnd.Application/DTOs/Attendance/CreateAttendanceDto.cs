using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Attendance
{
    public class CreateAttendanceDto
    {
        public AttendanceType Type { get; set; }
        public DateTime Date { get; set; }
        public int StaffStudentId { get; set; }
    }
}
