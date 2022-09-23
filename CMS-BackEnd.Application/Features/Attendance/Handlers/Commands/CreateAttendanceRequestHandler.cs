using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.Features.Attendance.Requests.Commands;
using CMS_BackEnd.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Handlers.Commands
{
    public class CreateAttendanceRequestHandler : BaseRequestHandler, IRequestHandler<CreateAttendanceRequest, CreateAttendanceDto>
    {
        public CreateAttendanceRequestHandler(IAttendanceRepository attendanceRepository, IMapper mapper) : base(attendanceRepository, mapper)
        {
        }

        public async Task<CreateAttendanceDto> Handle(CreateAttendanceRequest request, CancellationToken cancellationToken)
        {
            Domain.Attendance attendance = new Domain.Attendance()
            {
                Date = request.CreateData.Date
            };
            if (request.CreateData.Type == AttendanceType.Staff)
            {
                attendance.StaffId = request.CreateData.StaffStudentId;
            }
            else
            {
                attendance.StudentId = request.CreateData.StaffStudentId;
            }
            var rawRecords =await  attendanceRepository.Add(attendance);
            return mapper.Map<CreateAttendanceDto>(rawRecords);
        }
    }
}
