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
    public class CreateLoanRequestHandler : BaseRequestHandler, IRequestHandler<CreateLoanRequest, Unit>
    {
        public CreateLoanRequestHandler(ILoanRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(CreateLoanRequest request, CancellationToken cancellationToken)
        {
            var rawRecord = mapper.Map<Domain.Loan>(request.Data);
            await repository.Add(rawRecord);
            return Unit.Value;
        }
    }
}
