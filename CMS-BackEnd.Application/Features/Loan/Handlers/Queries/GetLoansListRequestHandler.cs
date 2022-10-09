using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
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
    public class GetLoansListRequestHandler : BaseRequestHandler, IRequestHandler<GetLoansListRequest, PaginationResponse<LoanListDto>>
    {
        public GetLoansListRequestHandler(ILoanRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<PaginationResponse<LoanListDto>> Handle(GetLoansListRequest request, CancellationToken cancellationToken)
        {
            PaginationResponse<LoanListDto> paginationResponse = new PaginationResponse<LoanListDto>();
            IReadOnlyList<Domain.Loan> records;
            if (request.pagination != null)
            {
                var paginationResult = await repository.GetAllWithPagination(request.pagination);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<LoanListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await repository.GetAll();
                var result = mapper.Map<IReadOnlyList<LoanListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}
