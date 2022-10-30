using CMS_BackEnd.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Attendance
{
    public class AttendanceDetailsDto : BaseDto
    {
        public AttendanceType Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int StaffStudentId { get; set; }
    }
}
