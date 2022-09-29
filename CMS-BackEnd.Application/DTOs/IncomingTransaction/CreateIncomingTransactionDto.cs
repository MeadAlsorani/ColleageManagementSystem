using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.IncomingTransaction
{
    public class CreateIncomingTransactionDto
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public int? CourseId { get; set; }
    }
}
