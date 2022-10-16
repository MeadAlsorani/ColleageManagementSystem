using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.IncomeTransaction.Handlers.Queries
{
    public class GetIncomeTransactionAmountsRequestHandler : BaseRequestHandler, IRequestHandler<GetIncomeTransactionAmountsRequest, IncomingTransactionAmounts>
    {
        public GetIncomeTransactionAmountsRequestHandler(IIncomingTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IncomingTransactionAmounts> Handle(GetIncomeTransactionAmountsRequest request, CancellationToken cancellationToken)
        {
            var amounts = await repository.GetIncomingTransactionAmounts(request.StudentId, request.CourseId);
            return amounts;
        }
    }
}
