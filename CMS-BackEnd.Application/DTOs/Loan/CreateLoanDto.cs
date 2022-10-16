using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Loan
{
    public class CreateLoanDto
    {
        public double Amount { get; set; }
        public int salaryTemplateId { get; set; }
        public DateTime Date { get; set; }
    }
}
