using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Queries
{
    public class GetIncomeTransactionAmountsRequest : IRequest<IncomingTransactionAmounts>
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
