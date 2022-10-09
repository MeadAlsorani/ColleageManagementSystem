using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
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
    public class GetSessionYearsListRequestHandler : BaseRequestHandler, IRequestHandler<GetSessionYearsListRequest, PaginationResponse<SessionYearListDto>>
    {
        public GetSessionYearsListRequestHandler(ISessionYearRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<PaginationResponse<SessionYearListDto>> Handle(GetSessionYearsListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.SessionYear> records;
            PaginationResponse<SessionYearListDto> paginationResponse = new PaginationResponse<SessionYearListDto>();
            if (request.request != null)
            {
                var paginationResult = await repository.GetAllWithPagination(request.request);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<SessionYearListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await repository.GetAll();
                var result = mapper.Map<IReadOnlyList<SessionYearListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}
