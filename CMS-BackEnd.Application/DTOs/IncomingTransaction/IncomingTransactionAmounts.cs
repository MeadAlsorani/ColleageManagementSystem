using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.IncomingTransaction
{
    public class IncomingTransactionAmounts
    {
        public int AgreedAmount { get; set; }
        public int PaidToDate { get; set; }
        public int RemainingAmount { get; set; }
    }
}
