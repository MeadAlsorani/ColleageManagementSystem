using CMS_BackEnd.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class SalaryTemplate:BaseModelClass
    {
        public int StaffId { get; set; }
        public double OverTimePerHour { get; set; }
        public int TotalDuration { get; set; }

    }
}
