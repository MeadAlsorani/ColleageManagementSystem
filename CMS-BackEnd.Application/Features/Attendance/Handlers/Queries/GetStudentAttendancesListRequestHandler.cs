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
    public class GetStudentAttendancesListRequestHandler
        : BaseRequestHandler, IRequestHandler<GetStudentAttendancesListRequest, IReadOnlyList<StudentAttendanceDto>>
    {
        public GetStudentAttendancesListRequestHandler(IAttendanceRepository attendanceRepository, IMapper mapper)
            : base(attendanceRepository, mapper)
        {
        }

        public async Task<IReadOnlyList<StudentAttendanceDto>> Handle(GetStudentAttendancesListRequest request, CancellationToken cancellationToken)
        {
            var records =await attendanceRepository.StaffAttendancesByDate(request.StartDate, request.EndDate, request.StudentId);
            var mappedRecords = mapper.Map<IReadOnlyList<StudentAttendanceDto>>(records);
            return mappedRecords;
        }
    }
}
