using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Handlers
{
    public class BaseRequestHandler
    {
        public readonly IAttendanceRepository attendanceRepository;
        public readonly IMapper mapper;

        public BaseRequestHandler(IAttendanceRepository attendanceRepository, IMapper mapper)
        {
            this.attendanceRepository = attendanceRepository;
            this.mapper = mapper;
        }
    }
}
