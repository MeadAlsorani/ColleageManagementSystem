using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Loan.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Loan.Handlers.Commands
{
    public class UpdateLoanRequestHandler : BaseRequestHandler, IRequestHandler<UpdateLoanRequest, Unit>
    {
        public UpdateLoanRequestHandler(ILoanRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(UpdateLoanRequest request, CancellationToken cancellationToken)
        {
            var rawRecord = mapper.Map<Domain.Loan>(request.Data);
            await repository.Update(rawRecord);
            return Unit.Value;
        }
    }
}
