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
    public class DeleteStaffRequestHandler : BaseRequestHandler, IRequestHandler<DeleteStaffRequest, Unit>
    {
        public DeleteStaffRequestHandler(IStaffRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(DeleteStaffRequest request, CancellationToken cancellationToken)
        {
            await repository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
