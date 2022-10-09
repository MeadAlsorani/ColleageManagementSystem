using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Loan;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Loan.Requests.Queries
{
    public class GetLoansListRequest : IRequest<PaginationResponse<LoanListDto>>
    {
        public ListPaginationRequest? pagination { get; set; }
    }
}
