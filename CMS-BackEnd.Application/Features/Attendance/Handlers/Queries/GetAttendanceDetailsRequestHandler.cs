using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.Features.Attendance.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Handlers.Queries
{
    public class GetAttendanceDetailsRequestHandler : BaseRequestHandler, IRequestHandler<GetAttendanceDetailsRequest, CreateAttendanceDto>
    {
        public GetAttendanceDetailsRequestHandler(IAttendanceRepository attendanceRepository, IMapper mapper) : base(attendanceRepository, mapper)
        {
        }

        public async Task<CreateAttendanceDto> Handle(GetAttendanceDetailsRequest request, CancellationToken cancellationToken)
        {
            var record = await attendanceRepository.Get(request.Id);
            return mapper.Map<CreateAttendanceDto>(record);
        }
    }
}
