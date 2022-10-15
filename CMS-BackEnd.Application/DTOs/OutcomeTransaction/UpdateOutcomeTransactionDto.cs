using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.OutcomeTransaction
{
    public class UpdateOutcomeTransactionDto : BaseDto
    {
        public double Amount { get; set; }
        public OutcomeType Type { get; set; }
        public int? StaffId { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
    }
}
