using CMS_BackEnd.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Attendance
{
    public class AttendancesListDto : BaseDto
    {
        public DateTime Date { get; set; }
        public AttendanceType Type { get; set; }
        public string Name { get; set; } = null!;
    }
    public enum AttendanceType
    {
        Student = 1,
        Staff
    }
}
