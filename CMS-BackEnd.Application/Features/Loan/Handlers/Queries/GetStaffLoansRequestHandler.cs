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
    public class GetStaffLoansRequestHandler : BaseRequestHandler, IRequestHandler<GetStaffLoansRequest, IReadOnlyList<LoanRecordDto>>
    {
        public GetStaffLoansRequestHandler(ILoanRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IReadOnlyList<LoanRecordDto>> Handle(GetStaffLoansRequest request, CancellationToken cancellationToken)
        {
            var records = await repository.GetStaffLoans(request.StaffId);
            return records;
        }
    }
}
