using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.IncomeTransaction.Handlers.Commands
{
    public class CreateIncomingTranasctionRequestHandler : BaseRequestHandler, IRequestHandler<CreateIncomingTransactionRequest>
    {
        public CreateIncomingTranasctionRequestHandler(IIncomingTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(CreateIncomingTransactionRequest request, CancellationToken cancellationToken)
        {
            await repository.Add(mapper.Map<Domain.IncomeTransaction>(request.Data));
            return Unit.Value;
        }
    }
}
