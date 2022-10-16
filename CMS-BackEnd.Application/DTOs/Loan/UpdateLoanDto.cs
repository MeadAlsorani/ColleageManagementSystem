using CMS_BackEnd.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Loan
{
    public class UpdateLoanDto : BaseDto
    {
        public double Amount { get; set; }
        public int SalaryTemplateId { get; set; }
        public DateTime Date { get; set; }
    }
}
