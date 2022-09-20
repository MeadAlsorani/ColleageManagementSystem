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
    }
}
