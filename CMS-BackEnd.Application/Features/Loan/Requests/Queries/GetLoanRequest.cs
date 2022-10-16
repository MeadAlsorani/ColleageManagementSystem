using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Loan.Requests.Queries
{
    public class GetLoanRequest:IRequest<Domain.Loan>
    {
        public int Id { get; set; }
    }
}
