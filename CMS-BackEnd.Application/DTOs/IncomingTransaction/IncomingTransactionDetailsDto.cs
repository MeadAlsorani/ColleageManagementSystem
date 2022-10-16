using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.IncomingTransaction
{
    public class IncomingTransactionDetailsDto : BaseDto
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public IncomingTransactionAmounts? transactionAmounts { get; set; }
    }
}
