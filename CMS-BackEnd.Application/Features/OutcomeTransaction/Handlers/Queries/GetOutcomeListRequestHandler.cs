using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.OutcomeTransaction;
using CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.OutcomeTransaction.Handlers.Queries
{
    public class GetOutcomeListRequestHandler : BaseRequestHandler, IRequestHandler<GetOutcomesListRequest, PaginationResponse<OutcomeListDto>>
    {
        public GetOutcomeListRequestHandler(IOutcomeTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<PaginationResponse<OutcomeListDto>> Handle(GetOutcomesListRequest request, CancellationToken cancellationToken)
        {
            PaginationResponse<OutcomeListDto> paginationResponse = new PaginationResponse<OutcomeListDto>();
            IReadOnlyList<Domain.OutcomeTransaction> records;
            if (request.pagination != null)
            {
                var paginationResult = await repository.GetAllWithPagination(request.pagination);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<OutcomeListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await repository.GetAll();
                var result = mapper.Map<IReadOnlyList<OutcomeListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}
