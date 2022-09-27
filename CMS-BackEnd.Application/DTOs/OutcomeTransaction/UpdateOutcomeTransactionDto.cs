using CMS_BackEnd.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.OutcomeTransaction
{
    public class UpdateOutcomeTransactionDto : BaseDto
    {
        public string Description { get; set; } = "";
        public double Amount { get; set; }
    }
}
