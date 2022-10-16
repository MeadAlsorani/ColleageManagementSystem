using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.SalaryTemplate;
using CMS_BackEnd.Application.Features.SalaryTemplate.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SalaryTemplate.Handlers.Queries
{
    public class GetSalaryTemplatesListRequestHandler : BaseRequestHandler, IRequestHandler<GetSalaryTemplatesListRequest, PaginationResponse<SalaryTemplatesListDto>>
    {
        public GetSalaryTemplatesListRequestHandler(ISalaryTemplateRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<PaginationResponse<SalaryTemplatesListDto>> Handle(GetSalaryTemplatesListRequest request, CancellationToken cancellationToken)
        {
            if (request.pagination is null)
            {
                var records = await repository.GetAll();
                var mappedRecords = mapper.Map<IReadOnlyList<SalaryTemplatesListDto>>(records);
                return new PaginationResponse<SalaryTemplatesListDto> { Count = records.Count, Records = mappedRecords };
            }
            else
            {
                var records = await repository.GetAllWithPagination(request.pagination);
                var mappedRecords = mapper.Map<IReadOnlyList<SalaryTemplatesListDto>>(records.Records);
                return new PaginationResponse<SalaryTemplatesListDto>() { Records = mappedRecords, Count = records.Count };
            }
        }
    }
}
