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
    public class IncomingTransactionDetailsRequestHandler
        : BaseRequestHandler, IRequestHandler<IncomingTransactionDetailsRequest, IncomingTransactionDetailsDto>
    {
        public IncomingTransactionDetailsRequestHandler(IIncomingTransactionRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IncomingTransactionDetailsDto> Handle(IncomingTransactionDetailsRequest request, CancellationToken cancellationToken)
        {
            var record = await repository.Get(request.Id);
            return mapper.Map<IncomingTransactionDetailsDto>(record);
        }
    }
}
