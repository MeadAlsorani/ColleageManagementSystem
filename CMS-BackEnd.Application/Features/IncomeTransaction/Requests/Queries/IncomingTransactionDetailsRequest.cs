using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Queries
{
    public class IncomingTransactionDetailsRequest : IRequest<IncomingTransactionDetailsDto>
    {
        public int Id { get; set; }
    }
}
