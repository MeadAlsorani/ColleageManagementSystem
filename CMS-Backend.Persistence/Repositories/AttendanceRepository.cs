using AutoMapper;
using CMS_Backend.Persistence.ExtensionMethods;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
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

        public override async Task<IReadOnlyList<Attendance>> GetAll()
        {
            var records = await dbContext.Attendances.Include(x => x.Student).Include(x => x.Staff).AsNoTracking().ToListAsync();
            return records;
        }
        public override async Task<PaginationResponse<Attendance>> GetAllWithPagination(ListPaginationRequest request)
        {
            var records = await dbContext.Attendances
                .AsNoTracking()
                .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 : (
                x.Student == null ? 1 == 1 : string.Concat(x.Student!.Name).Contains(request.SearchStatement) || string.Concat(x.Student!.NationalId).Contains(request.SearchStatement) ||
                x.Staff == null ? 1 == 1 : string.Concat(x.Staff!.FirstName, " ", x.Staff.LastName).Contains(request.SearchStatement)
                ))
                .ApplyPagination(request)
                .OrderByDescending(x => x.CreationDate)
                .Include(x => x.Student)
                .Include(x => x.Staff).ToListAsync();
            var count = await dbContext.Attendances.AsNoTracking().CountAsync();
            return new PaginationResponse<Attendance> { Count = count, Records = records };
        }
        public async Task<IReadOnlyList<StaffAttendanceDto>> StaffAttendances(int staffId)
        {
            var list = await dbContext.Attendances.Include(x => x.Student).Include(x => x.Staff).AsNoTracking().Where(x => x.StaffId == staffId).ToListAsync();
            var mapped = mapper.Map<List<StaffAttendanceDto>>(list);
            return mapped;
        }

        public async Task<IReadOnlyList<StaffAttendanceDto>> StaffAttendancesByDate(DateTime start, DateTime end, int staffId)
        {
            var records = await StaffAttendances(staffId);
            var list = records.Where(x => x.Date >= start && x.Date <= end).ToList();
            return list;
        }

        public async Task<IReadOnlyList<StudentAttendanceDto>> StudentAttendances(int studentId)
        {
            var list = await dbContext.Attendances.Include(x => x.Student).Include(x => x.Staff).AsNoTracking().Where(x => x.StudentId == studentId).ToListAsync();
            return mapper.Map<List<StudentAttendanceDto>>(list);
        }

        public async Task<IReadOnlyList<StudentAttendanceDto>> StudentAttendancesByDate(DateTime start, DateTime end, int studentId)
        {
            var records = await StudentAttendances(studentId);
            var list = records.Where(x => x.Date >= start && x.Date <= end).ToList();
            return list;
        }
    }
}
