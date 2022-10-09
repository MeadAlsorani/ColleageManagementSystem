using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.Features.Attendance.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Handlers.Queries
{
    public class GetAttendancesRequestHandler : BaseRequestHandler, IRequestHandler<GetAttendancesRequest, PaginationResponse<AttendancesListDto>>
    {
        public GetAttendancesRequestHandler(IAttendanceRepository attendanceRepository, IMapper mapper) : base(attendanceRepository, mapper)
        {
        }

        public async Task<PaginationResponse<AttendancesListDto>> Handle(GetAttendancesRequest request, CancellationToken cancellationToken)
        {
            PaginationResponse<AttendancesListDto> paginationResponse = new PaginationResponse<AttendancesListDto>();
            IReadOnlyList<Domain.Attendance> records;
            if (request.pagination != null)
            {

                var paginationResult = await attendanceRepository.GetAllWithPagination(request.pagination);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<AttendancesListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await attendanceRepository.GetAll();
                var result = mapper.Map<IReadOnlyList<AttendancesListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}
