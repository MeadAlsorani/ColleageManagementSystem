using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Queries
{
    public class GetStudentIncomingTransactionRequest : IRequest<IReadOnlyList<StudentIncomingTransactionsDto>>
    {
        public int StudentId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
