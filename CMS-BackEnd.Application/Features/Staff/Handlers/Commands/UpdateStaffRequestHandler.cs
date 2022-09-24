using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Staff.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Staff.Handlers.Commands
{
    public class UpdateStaffRequestHandler : BaseRequestHandler, IRequestHandler<UpdateStaffRequest, Unit>
    {
        public UpdateStaffRequestHandler(IStaffRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(UpdateStaffRequest request, CancellationToken cancellationToken)
        {
            var staff = mapper.Map<Domain.Staff>(request.Staff);
            await repository.Update(staff);
            return Unit.Value;
        }
    }
}
