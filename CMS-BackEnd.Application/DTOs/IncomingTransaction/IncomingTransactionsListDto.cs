using CMS_BackEnd.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.IncomingTransaction
{
    public class IncomingTransactionsListDto : BaseDto
    {
        public DateOnly Date { get; set; }
        public double Amount { get; set; }
        public string StudentName { get; set; } = "";
        public string CourseName { get; set; } = "";
    }
}
