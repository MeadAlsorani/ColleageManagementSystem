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
    public class GetAttendanceCountsRequestHandler : IRequestHandler<GetAttendanceCountsRequest, Dictionary<string, int>>
    {
        private readonly IDashboardRepository repository;

        public GetAttendanceCountsRequestHandler(IDashboardRepository repository)
        {
            this.repository = repository;
        }
        public async Task<Dictionary<string, int>> Handle(GetAttendanceCountsRequest request, CancellationToken cancellationToken)
        {
            return await repository.GetAttendanceCountsToday();
        }
    }
}
