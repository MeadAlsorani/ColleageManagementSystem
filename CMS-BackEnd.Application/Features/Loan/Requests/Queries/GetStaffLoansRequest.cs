using CMS_BackEnd.Application.DTOs.Loan;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Loan.Requests.Queries
{
    public class GetStaffLoansRequest : IRequest<IReadOnlyList<LoanRecordDto>>
    {
        public int StaffId { get; set; }
    }
}
