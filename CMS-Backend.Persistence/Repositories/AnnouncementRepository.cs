using CMS_Backend.Persistence.ExtensionMethods;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
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
    public class AnnouncementRepository : GenericRepository<Announcement>, IAnnouncementRepository
    {
        public AnnouncementRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<PaginationResponse<Announcement>> GetAllWithPagination(ListPaginationRequest request)
        {
            List<Announcement> records = await dbContext.Announcements
                .OrderByDescending(x => x.CreationDate)
                .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 : (x.Id.ToString() == request.SearchStatement || x.Message == request.SearchStatement || x.Title == request.SearchStatement))
                    .AsNoTracking()
                    .ApplyPagination(request)
                    .ToListAsync();
            var count = await dbContext.Announcements.AsNoTracking().CountAsync();
            return new PaginationResponse<Announcement> { Count = count, Records = records };
        }
        public async Task<IReadOnlyList<Announcement>> GetByMonth(int month)
        {
            var nowDate = DateTime.Now;
            var first = new DateTime(nowDate.Year, month, 1);
            var last = first.AddMonths(1).AddDays(-1);
            var records = await dbContext.Announcements.AsNoTracking().Where(x => x.Date <= last && x.Date >= first).ToListAsync();
            return records;
        }
    }
}
