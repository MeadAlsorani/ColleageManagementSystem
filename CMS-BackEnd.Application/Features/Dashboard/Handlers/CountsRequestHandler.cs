using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.Features.Dashboard.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Dashboard.Handlers
{
    public class CountsRequestHandler : IRequestHandler<CountsRequest, CountsResponse>
    {
        private readonly IDashboardRepository repository;

        public CountsRequestHandler(IDashboardRepository repository)
        {
            this.repository = repository;
        }
        public async Task<CountsResponse> Handle(CountsRequest request, CancellationToken cancellationToken)
        {
            var counts = await repository.Counts();
            return counts;
        }
    }
}
