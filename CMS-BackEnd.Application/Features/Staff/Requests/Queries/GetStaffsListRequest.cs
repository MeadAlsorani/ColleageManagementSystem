using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Staff.Requests.Queries
{
    public class GetStaffsListRequest:IRequest<IReadOnlyList<StaffListDto>>
    {
        public ListPaginationRequest? pagination { get; set; }
    }
}
