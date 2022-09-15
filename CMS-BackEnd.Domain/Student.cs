using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GuardianName { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ClassLevel { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public string SchoolName { get; set; }
        public DateTime RegisterationDate { get; set; }
        public bool Approved { get; set; }
    }
}
