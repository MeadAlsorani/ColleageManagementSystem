using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.SessionYear;
using CMS_BackEnd.Application.Features.SessionYear.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SessionYear.Handlers.Queries
{
    public class GetSessionYearsListRequestHandler : BaseRequestHandler, IRequestHandler<GetSessionYearsListRequest, IReadOnlyList<SessionYearListDto>>
    {
        public GetSessionYearsListRequestHandler(ISessionYearRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<IReadOnlyList<SessionYearListDto>> Handle(GetSessionYearsListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.SessionYear> records;
            if (request.request != null)
            {
                records = await repository.GetAllWithPagination(request.request);
            }
            else
            {
                records = await repository.GetAll();
            }

            var result = mapper.Map<IReadOnlyList<SessionYearListDto>>(records);
            return result;
        }
    }
}
