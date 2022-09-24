using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
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
    public class GetStaffsListRequestHandler : BaseRequestHandler, IRequestHandler<GetStaffsListRequest, IReadOnlyList<StaffListDto>>
    {
        public GetStaffsListRequestHandler(IStaffRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IReadOnlyList<StaffListDto>> Handle(GetStaffsListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.Staff> records;

            if (request.pagination!=null)
            {
                records = await repository.GetAllWithPagination(request.pagination);
            }
            else
            {
                records = await repository.GetAll();
            }

            return mapper.Map<IReadOnlyList<StaffListDto>>(records);
        }
    }
}
