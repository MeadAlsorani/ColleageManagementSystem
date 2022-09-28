using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Loan;
using CMS_BackEnd.Application.Features.Loan.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Loan.Handlers.Queries
{
    public class GetLoansListRequestHandler : BaseRequestHandler, IRequestHandler<GetLoansListRequest, IReadOnlyList<LoanListDto>>
    {
        public GetLoansListRequestHandler(ILoanRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IReadOnlyList<LoanListDto>> Handle(GetLoansListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.Loan> records;
            if (request.pagination != null)
            {
                records = await repository.GetAllWithPagination(request.pagination);
            }
            else
            {
                records = await repository.GetAll();
            }

            return mapper.Map<IReadOnlyList<LoanListDto>>(records);
        }
    }
}
