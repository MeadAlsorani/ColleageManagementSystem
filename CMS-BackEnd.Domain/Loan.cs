using CMS_BackEnd.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class Loan : BaseModelClass
    {
        public double Amount { get; set; }
        public int SalaryTemplateId { get; set; }
        public SalaryTemplate? SalaryTemplate { get; set; }
        public DateTime Date { get; set; }
    }
}
