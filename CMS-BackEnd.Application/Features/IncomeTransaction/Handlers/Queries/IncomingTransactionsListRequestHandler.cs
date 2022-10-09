using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
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
        : BaseRequestHandler, IRequestHandler<IncomingTransactionsListRequest, PaginationResponse<IncomingTransactionsListDto>>
    {
        public IncomingTransactionsListRequestHandler(IIncomingTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<PaginationResponse<IncomingTransactionsListDto>> Handle(IncomingTransactionsListRequest request, CancellationToken cancellationToken)
        {
            PaginationResponse<IncomingTransactionsListDto> paginationResponse = new PaginationResponse<IncomingTransactionsListDto>();
            IReadOnlyList<Domain.IncomeTransaction> records;
            if (request.Pagination != null)
            {
                var paginationResult = await repository.GetAllWithPagination(request.Pagination);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<IncomingTransactionsListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await repository.GetAll();
                var result = mapper.Map<IReadOnlyList<IncomingTransactionsListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}

