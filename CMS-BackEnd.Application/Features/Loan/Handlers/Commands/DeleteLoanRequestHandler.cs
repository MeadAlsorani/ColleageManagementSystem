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
    public class DeleteLoanRequestHandler : BaseRequestHandler, IRequestHandler<DeleteLoanRequest, Unit>
    {
        public DeleteLoanRequestHandler(ILoanRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(DeleteLoanRequest request, CancellationToken cancellationToken)
        {
            await repository.DeleteSalaryTemplate(request.Id);
            return Unit.Value;
        }
    }
}
