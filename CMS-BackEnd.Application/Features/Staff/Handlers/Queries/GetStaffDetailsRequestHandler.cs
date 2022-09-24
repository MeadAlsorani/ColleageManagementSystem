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
    public class GetStaffDetailsRequestHandler : BaseRequestHandler, IRequestHandler<GetStaffDetailsRequest, StaffDetailsDto>
    {
        public GetStaffDetailsRequestHandler(IStaffRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<StaffDetailsDto> Handle(GetStaffDetailsRequest request, CancellationToken cancellationToken)
        {
            var record = await repository.Get(request.Id);
            var mappedRecord = mapper.Map<StaffDetailsDto>(record);
            return mappedRecord;
        }
    }
}
