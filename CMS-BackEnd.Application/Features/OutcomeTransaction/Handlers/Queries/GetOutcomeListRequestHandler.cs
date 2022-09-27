using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
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
    public class GetOutcomeListRequestHandler : BaseRequestHandler, IRequestHandler<GetOutcomesListRequest, IReadOnlyList<OutcomeListDto>>
    {
        public GetOutcomeListRequestHandler(IOutcomeTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IReadOnlyList<OutcomeListDto>> Handle(GetOutcomesListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.OutcomeTransaction> records;
            if (request.pagination == null)
                records = await repository.GetAll();
            else
                records = await repository.GetAllWithPagination(request.pagination);

            return mapper.Map<IReadOnlyList<OutcomeListDto>>(records);
        }
    }
}
