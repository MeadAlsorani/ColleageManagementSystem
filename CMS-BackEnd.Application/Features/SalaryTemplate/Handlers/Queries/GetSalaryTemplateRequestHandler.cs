using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Loan.Handlers;
using CMS_BackEnd.Application.Features.SalaryTemplate.Requests.Queries;
using MediatR;
namespace CMS_BackEnd.Application.Features.SalaryTemplate.Handlers.Queries
{
    public class GetSalaryTemplateRequestHandler : BaseRequestHandler, IRequestHandler<GetSalaryTemplateRequest, Domain.SalaryTemplate>
    {
        public GetSalaryTemplateRequestHandler(ISalaryTemplateRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Domain.SalaryTemplate> Handle(GetSalaryTemplateRequest request, CancellationToken cancellationToken)
        {
            var record = await repository.Get(request.Id);
            var data = mapper.Map<Domain.SalaryTemplate>(record);
            return data;
        }
    }
}
