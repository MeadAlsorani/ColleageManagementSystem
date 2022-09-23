using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Attendance.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Handlers.Commands
{
    public class DeleteAttendanceRequestHandler : BaseRequestHandler, IRequestHandler<DeleteAttendanceRequest, Unit>
    {
        public DeleteAttendanceRequestHandler(IAttendanceRepository attendanceRepository, IMapper mapper) : base(attendanceRepository, mapper)
        {
        }

        public async Task<Unit> Handle(DeleteAttendanceRequest request, CancellationToken cancellationToken)
        {
            await attendanceRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
