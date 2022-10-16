using CMS_BackEnd.Application.DTOs.Loan;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Loan.Requests.Commands
{
    public class CreateLoanRequest : IRequest<Unit>
    {
        public Domain.Loan Data { get; set; } = null!;
    }
}
