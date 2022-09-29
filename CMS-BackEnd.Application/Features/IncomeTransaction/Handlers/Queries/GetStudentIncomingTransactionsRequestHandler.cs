using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using CMS_BackEnd.Application.Features.IncomeTransaction.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.IncomeTransaction.Handlers.Queries
{
    public class GetStudentIncomingTransactionsRequestHandler : BaseRequestHandler,
        IRequestHandler<GetStudentIncomingTransactionRequest, IReadOnlyList<StudentIncomingTransactionsDto>>
    {
        public GetStudentIncomingTransactionsRequestHandler(IIncomingTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IReadOnlyList<StudentIncomingTransactionsDto>> Handle(GetStudentIncomingTransactionRequest request, CancellationToken cancellationToken)
        {
            var records = await repository.GetStudentIncomingTransactions(request.StudentId, request.Start, request.End);
            return records;
        }
    }
}
