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
    public class UpdateIncomingTransactionRequestHandler : BaseRequestHandler, IRequestHandler<UpdateIncomingTransactionRequest>
    {
        public UpdateIncomingTransactionRequestHandler(IIncomingTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(UpdateIncomingTransactionRequest request, CancellationToken cancellationToken)
        {
            await repository.Update(mapper.Map<Domain.IncomeTransaction>(request.Data));
            return Unit.Value;
        }
    }
}
