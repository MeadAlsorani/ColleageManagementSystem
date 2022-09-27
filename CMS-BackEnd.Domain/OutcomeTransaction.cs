using CMS_BackEnd.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class OutcomeTransaction : BaseModelClass
    {
        public double Amount { get; set; }
        public OutcomeType Type { get; set; }
        public string? Description { get; set; }
        public int? StaffId { get; set; }
        public Staff? Staff { get; set; }
        public DateTime Date { get; set; }

    }
    public enum OutcomeType
    {
        Purchase = 1,
        Salary,
        Other
    }
}
