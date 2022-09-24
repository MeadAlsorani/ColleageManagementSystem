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
    public class CreateSessionYearRequestHandler : BaseRequestHandler, IRequestHandler<CreateSessionYearRequest, Unit>
    {
        public CreateSessionYearRequestHandler(ISessionYearRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<Unit> Handle(CreateSessionYearRequest request, CancellationToken cancellationToken)
        {
            await repository.Add(mapper.Map<Domain.SessionYear>(request.data));
            return Unit.Value;
        }
    }
}
