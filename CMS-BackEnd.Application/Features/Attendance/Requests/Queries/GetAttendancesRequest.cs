using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Requests.Queries
{
    public class GetAttendancesRequest : IRequest<PaginationResponse<AttendancesListDto>>
    {
        public ListPaginationRequest? pagination { get; set; }
    }
}
