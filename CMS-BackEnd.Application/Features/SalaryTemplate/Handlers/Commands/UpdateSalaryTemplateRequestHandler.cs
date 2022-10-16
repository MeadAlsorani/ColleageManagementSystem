using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.SalaryTemplate.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SalaryTemplate.Handlers.Commands
{
    public class UpdateSalaryTemplateRequestHandler : BaseRequestHandler, IRequestHandler<UpdateSalaryTemplateRequest, Unit>
    {
        public UpdateSalaryTemplateRequestHandler(ISalaryTemplateRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(UpdateSalaryTemplateRequest request, CancellationToken cancellationToken)
        {
            await repository.Update(request.SalaryTemplate);
            return Unit.Value;
        }
    }
}
