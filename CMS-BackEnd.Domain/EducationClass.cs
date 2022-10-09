using CMS_BackEnd.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class EducationClass : BaseModelClass
    {
        public string Name { get; set; }
        ICollection<Course> Courses { get; set; }
    }
}
