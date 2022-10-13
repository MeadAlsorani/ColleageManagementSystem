using CMS_BackEnd.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Staff
{
    public class StaffListDto : BaseDto
    {
        public string FullName { get; set; } = "";
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; } = "";
        public string Role { get; set; } = "";
    }
    public enum UserRole
    {
        Teacher = 1,
        Admin,
        Employee
    }
}
