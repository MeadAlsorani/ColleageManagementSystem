using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Commands;
using MediatR;
namespace CMS_BackEnd.Application.Features.OutcomeTransaction.Handlers.Commands
{
    public class UpdateOutcomeTransactionRequestHandler : BaseRequestHandler, IRequestHandler<UpdateOutcomeTransactionRequest, Unit>
    {
        public UpdateOutcomeTransactionRequestHandler(IOutcomeTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(UpdateOutcomeTransactionRequest request, CancellationToken cancellationToken)
        {
            await repository.Update(mapper.Map<Domain.OutcomeTransaction>(request.Data));
            return Unit.Value;
        }
    }
}
