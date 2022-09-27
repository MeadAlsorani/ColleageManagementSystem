using CMS_BackEnd.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.OutcomeTransaction
{
    public class OutcomeDetailsDto : BaseDto
    {
        public double Amount { get; set; }
        public string Type { get; set; } = "";
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
