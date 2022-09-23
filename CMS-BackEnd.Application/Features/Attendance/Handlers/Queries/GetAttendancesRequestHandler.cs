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
    public class GetAttendancesRequestHandler : BaseRequestHandler, IRequestHandler<GetAttendancesRequest, IReadOnlyList<AttendancesListDto>>
    {
        public GetAttendancesRequestHandler(IAttendanceRepository attendanceRepository, IMapper mapper) : base(attendanceRepository, mapper)
        {
        }

        public async Task<IReadOnlyList<AttendancesListDto>> Handle(GetAttendancesRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.Attendance> records;
            if (request.pagination != null)
            {
                records = await attendanceRepository.GetAllWithPagination(request.pagination);
            }
            else
            {
                records = await attendanceRepository.GetAll();
            }
            var mappedRecords = mapper.Map<IReadOnlyList<AttendancesListDto>>(records);
            return mappedRecords;
        }
    }
}
