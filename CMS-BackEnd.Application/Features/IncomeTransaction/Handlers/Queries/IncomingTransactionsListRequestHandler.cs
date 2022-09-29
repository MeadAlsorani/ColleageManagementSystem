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
    public class IncomingTransactionsListRequestHandler
        : BaseRequestHandler, IRequestHandler<IncomingTransactionsListRequest, IReadOnlyList<IncomingTransactionsListDto>>
    {
        public IncomingTransactionsListRequestHandler(IIncomingTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IReadOnlyList<IncomingTransactionsListDto>> Handle(IncomingTransactionsListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.IncomeTransaction> records;
            if (request.Pagination == null)
                records = await repository.GetAll();
            else
                records = await repository.GetAllWithPagination(request.Pagination);
            return mapper.Map<IReadOnlyList<IncomingTransactionsListDto>>(records);
        }
    }
}
