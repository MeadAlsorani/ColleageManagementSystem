using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.Features.Staff.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Staff.Handlers.Queries
{
    public class GetStaffsListRequestHandler : BaseRequestHandler, IRequestHandler<GetStaffsListRequest, PaginationResponse<StaffListDto>>
    {
        public GetStaffsListRequestHandler(IStaffRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<PaginationResponse<StaffListDto>> Handle(GetStaffsListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.Staff> records;

            PaginationResponse<StaffListDto> paginationResponse = new PaginationResponse<StaffListDto>();
            if (request.pagination != null)
            {
                var paginationResult = await repository.GetAllWithPagination(request.pagination);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<StaffListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await repository.GetAll();
                var result = mapper.Map<IReadOnlyList<StaffListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}
