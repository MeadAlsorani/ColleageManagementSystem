using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Loan
{
    public class LoanRecordDto:BaseDto
    {
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public StaffListDto Staff { get; set; }
    }
}
