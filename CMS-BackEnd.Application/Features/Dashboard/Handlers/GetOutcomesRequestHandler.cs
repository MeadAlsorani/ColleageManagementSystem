using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Dashboard.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Dashboard.Handlers
{
    public class GetOutcomesRequestHandler : IRequestHandler<GetOutcomesRequest, IDictionary<string, double>>
    {
        private readonly IDashboardRepository repository;

        public GetOutcomesRequestHandler(IDashboardRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IDictionary<string, double>> Handle(GetOutcomesRequest request, CancellationToken cancellationToken)
        {
            if (request.Month != -1)
            {
                return await repository.GetOutcomesSumByMonth(request.Month);
            }
            else
            {
                return await repository.GetOutcomesSum();
            }
        }
    }
}
