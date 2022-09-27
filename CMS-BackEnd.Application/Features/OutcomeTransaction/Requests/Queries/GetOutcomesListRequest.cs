using CMS_BackEnd.Application.DTOs.OutcomeTransaction;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.OutcomeTransaction.Requests.Queries
{
    public class GetOutcomesListRequest : IRequest<IReadOnlyList<OutcomeListDto>>
    {
        public ListPaginationRequest? pagination { get; set; }
    }
}
