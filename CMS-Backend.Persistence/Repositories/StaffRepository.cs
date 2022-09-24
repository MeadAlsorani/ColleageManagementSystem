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
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<Staff> Get(int id)
        {
            var record=await dbContext.Staffs.Include(x=>x.Loans).AsNoTracking().FirstOrDefaultAsync(z=>z.Id==id);
            return record;
        }
    }
}
