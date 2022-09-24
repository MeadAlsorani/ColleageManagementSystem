using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.Repositories
{
    public class SessionYearRepository : GenericRepository<SessionYear>, ISessionYearRepository
    {
        public SessionYearRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
        }
    }
}
