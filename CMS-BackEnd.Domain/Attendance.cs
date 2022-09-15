using CMS_BackEnd.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class Attendance : BaseModelClass
    {
        public DateTime Date { get; set; }
        public int? StaffId { get; set; }
        public Staff? Staff { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
