using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.OutcomeTransaction.Handlers.Queries
{
    public class GetOutcomeTotalsRequestHandler : BaseRequestHandler, IRequestHandler<GetOutcomeTotalsRequest, double>
    {
        public GetOutcomeTotalsRequestHandler(IOutcomeTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<double> Handle(GetOutcomeTotalsRequest request, CancellationToken cancellationToken)
        {
            return await repository.GetTotalOutcome(request.Month);
        }
    }
}
