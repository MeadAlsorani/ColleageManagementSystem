using AutoMapper;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.Repositories
{
    public class AttendanceRepository : GenericRepository<Attendance>, IAttendanceRepository
    {
        private readonly IMapper mapper;

        public AttendanceRepository(ColleageManagementDbContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }

        public IReadOnlyList<StaffAttendanceDto> StaffAttendances(int staffId)
        {
            var list = dbContext.Attendances.Where(x => x.StaffId == staffId).ToList();
            return mapper.Map<List<StaffAttendanceDto>>(list);
        }

        public IReadOnlyList<StaffAttendanceDto> StaffAttendancesByDate(DateTime start, DateTime end,int staffId)
        {
            var list = StaffAttendances(staffId).Where(x => x.Date >= start && x.Date <= end).ToList();
            return list;
        }

        public IReadOnlyList<StudentAttendanceDto> StudentAttendances(int studentId)
        {
            var list = dbContext.Attendances.Where(x => x.StaffId == studentId).ToList();
            return mapper.Map<List<StudentAttendanceDto>>(list);
        }

        public IReadOnlyList<StudentAttendanceDto> StudentAttendancesByDate(DateTime start, DateTime end,int studentId)
        {
            var list = StudentAttendances(studentId).Where(x => x.Date >= start && x.Date <= end).ToList();
            return list;
        }
    }
}
