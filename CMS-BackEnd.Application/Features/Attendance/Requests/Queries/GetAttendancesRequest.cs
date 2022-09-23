using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Requests.Queries
{
    public class GetAttendancesRequest : IRequest<IReadOnlyList<AttendancesListDto>>
    {
        public ListPaginationRequest pagination { get; set; }
    }
}
