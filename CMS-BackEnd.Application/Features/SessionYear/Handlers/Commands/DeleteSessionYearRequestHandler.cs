using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.SessionYear.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SessionYear.Handlers.Commands
{
    public class DeleteSessionYearRequestHandler : BaseRequestHandler, IRequestHandler<DeleteSessionYearRequest, Unit>
    {
        public DeleteSessionYearRequestHandler(ISessionYearRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<Unit> Handle(DeleteSessionYearRequest request, CancellationToken cancellationToken)
        {
            await repository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
