using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Queries
{
    public class IncomingTransactionsListRequest : IRequest<IReadOnlyList<IncomingTransactionsListDto>>
    {
        public ListPaginationRequest? Pagination { get; set; }
    }
}
