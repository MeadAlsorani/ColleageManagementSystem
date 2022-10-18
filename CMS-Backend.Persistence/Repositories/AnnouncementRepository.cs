using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
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
