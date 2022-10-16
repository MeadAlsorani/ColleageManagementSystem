using CMS_BackEnd.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.SalaryTemplate
{
    public class SalaryTemplatesListDto:BaseDto
    {
        public string? Staff { get; set; }
        public double SalaryPerHour { get; set; }
        public int TotalDuration { get; set; }
        public int BasicSalary { get; set; }
    }
}
