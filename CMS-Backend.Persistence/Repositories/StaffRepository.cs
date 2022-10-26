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
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<PaginationResponse<Staff>> GetAllWithPagination(ListPaginationRequest request)
        {
            var records = await dbContext.Staffs.OrderByDescending(x => x.CreationDate)
                    .AsNoTracking()
                    .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 : (
                    string.Concat(x.FirstName, " ", x.LastName).Contains(request.SearchStatement) ||
                    (!string.IsNullOrWhiteSpace(x.Email) && x.Email.Contains(request.SearchStatement)) ||
                    (!string.IsNullOrWhiteSpace(x.PhoneNumber) && x.PhoneNumber.Contains(request.SearchStatement)) ||
                    (!string.IsNullOrWhiteSpace(x.Address) && x.Address.Contains(request.SearchStatement))
                    ))
                    .ApplyPagination(request)
                    .ToListAsync();
            var count = await dbContext.Staffs.AsNoTracking().CountAsync();
            return new PaginationResponse<Staff> { Count = count, Records = records };
        }
        public override async Task<Staff> Get(int id)
        {
            var record = await dbContext.Staffs.AsNoTracking().FirstOrDefaultAsync(z => z.Id == id);
            return record;
        }
    }
}
