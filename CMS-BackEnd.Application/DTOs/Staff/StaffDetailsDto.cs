using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Staff
{
    public class StaffDetailsDto:BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public UserRole Role { get; set; }
        public int Salary { get; set; }
    }
}
