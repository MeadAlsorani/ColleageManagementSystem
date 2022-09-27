using CMS_BackEnd.Application.DTOs.Common;

namespace CMS_BackEnd.Application.DTOs.OutcomeTransaction
{
    public class OutcomeListDto : BaseDto
    {
        public string Type { get; set; }
        public string Description { get; set; } = "";
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
