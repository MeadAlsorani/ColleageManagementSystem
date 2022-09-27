using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.OutcomeTransaction.Handlers.Commands
{
    public class CreateOutcomeTransactionRequestHandler : BaseRequestHandler, IRequestHandler<CreateOutcomeTransactionRequest, Unit>
    {
        public CreateOutcomeTransactionRequestHandler(IOutcomeTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(CreateOutcomeTransactionRequest request, CancellationToken cancellationToken)
        {
            await repository.Add(mapper.Map<Domain.OutcomeTransaction>(request.Data));
            return Unit.Value;
        }
    }
}
