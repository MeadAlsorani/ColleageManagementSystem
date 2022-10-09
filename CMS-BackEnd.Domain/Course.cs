using CMS_BackEnd.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class Course : BaseModelClass
    {
        public string Name { get; set; }
        public int? StaffId { get; set; }
        public Staff? Staff { get; set; }
        public int LessonDuration { get; set; }
        public int ClassId { get; set; }
        public EducationClass? Class { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
