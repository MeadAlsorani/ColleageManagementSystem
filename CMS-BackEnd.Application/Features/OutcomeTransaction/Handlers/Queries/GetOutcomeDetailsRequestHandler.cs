using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.OutcomeTransaction;
using CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Queries;
using MediatR;

namespace CMS_BackEnd.Application.Features.OutcomeTransaction.Handlers.Queries
{
    public class GetOutcomeDetailsRequestHandler : BaseRequestHandler, IRequestHandler<GetOutcomeDetailsRequest, OutcomeDetailsDto>
    {
        public GetOutcomeDetailsRequestHandler(IOutcomeTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<OutcomeDetailsDto> Handle(GetOutcomeDetailsRequest request, CancellationToken cancellationToken)
        {
            var record = await repository.Get(request.Id);
            return mapper.Map<OutcomeDetailsDto>(record);
        }
    }
}
