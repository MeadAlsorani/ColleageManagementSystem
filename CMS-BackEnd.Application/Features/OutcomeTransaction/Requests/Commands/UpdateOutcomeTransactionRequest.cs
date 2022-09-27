using CMS_BackEnd.Application.DTOs.OutcomeTransaction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Commands
{
    public class UpdateOutcomeTransactionRequest : IRequest<Unit>
    {
        public UpdateOutcomeTransactionDto Data { get; set; } = null!;
    }
}
