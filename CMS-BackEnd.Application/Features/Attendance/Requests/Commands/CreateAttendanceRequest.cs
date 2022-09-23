using CMS_BackEnd.Application.DTOs.Attendance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Requests.Commands
{
    public class CreateAttendanceRequest:IRequest<CreateAttendanceDto>
    {
        public CreateAttendanceDto CreateData { get; set; }
    }
}
