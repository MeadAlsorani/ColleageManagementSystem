using CMS_BackEnd.Application.DTOs.Attendance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Requests.Queries
{
    public class GetStaffAtendancesListRequest:IRequest<IReadOnlyList<StaffAttendanceDto>>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StaffId { get; set; }
    }
}
