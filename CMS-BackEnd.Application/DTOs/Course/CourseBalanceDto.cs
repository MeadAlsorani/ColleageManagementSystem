using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Course
{
    public class CourseBalanceDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Remains { get; set; }
        public int Paid { get; set; }
    }
}
