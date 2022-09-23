using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Contracts.Features
{
    public interface IAttendanceRepository : IGenericRepository<Attendance>
    {
        public Task<IReadOnlyList<StaffAttendanceDto>> StaffAttendances(int staffId);
        public Task<IReadOnlyList<StudentAttendanceDto>> StudentAttendances(int studentId);
        public Task<IReadOnlyList<StudentAttendanceDto>> StudentAttendancesByDate(DateTime start, DateTime end, int studentId);
        public Task<IReadOnlyList<StaffAttendanceDto>> StaffAttendancesByDate(DateTime start, DateTime end, int staffId);

    }
}
