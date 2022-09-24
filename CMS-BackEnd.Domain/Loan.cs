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
        public int Amount { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public DateTime Date { get; set; }
    }
}
