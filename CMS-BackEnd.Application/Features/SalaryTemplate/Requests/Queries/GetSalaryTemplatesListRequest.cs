using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.SalaryTemplate;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SalaryTemplate.Requests.Queries
{
    public class GetSalaryTemplatesListRequest : IRequest<PaginationResponse<SalaryTemplatesListDto>>
    {
        public ListPaginationRequest? pagination { get; set; }
    }
}
