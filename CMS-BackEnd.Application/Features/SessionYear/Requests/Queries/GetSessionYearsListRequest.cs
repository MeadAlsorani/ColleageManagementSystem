using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.SessionYear;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SessionYear.Requests.Queries
{
    public class GetSessionYearsListRequest : IRequest<PaginationResponse<SessionYearListDto>>
    {
        public ListPaginationRequest? request { get; set; }
    }
}
