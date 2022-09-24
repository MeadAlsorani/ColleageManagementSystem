using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.Features.Staff.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Staff.Handlers.Commands
{
    public class CreateStaffRequestHandler : BaseRequestHandler, IRequestHandler<CreateStaffRequest, CreateStaffDto>
    {
        public CreateStaffRequestHandler(IStaffRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<CreateStaffDto> Handle(CreateStaffRequest request, CancellationToken cancellationToken)
        {
            Domain.Staff staff = mapper.Map<Domain.Staff>(request.Staff);
            var record = await repository.Add(staff);
            var resultRecord = mapper.Map<CreateStaffDto>(record);
            return resultRecord;
        }
    }
}
