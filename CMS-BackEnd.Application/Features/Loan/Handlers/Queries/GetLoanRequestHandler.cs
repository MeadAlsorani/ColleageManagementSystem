using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Loan.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Loan.Handlers.Queries
{
    public class GetLoanRequestHandler : BaseRequestHandler, IRequestHandler<GetLoanRequest, Domain.Loan>
    {
        public GetLoanRequestHandler(ILoanRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public Task<Domain.Loan> Handle(GetLoanRequest request, CancellationToken cancellationToken)
        {
            return repository.Get(request.Id);
        }
    }
}
