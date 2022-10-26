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
    public class SessionYearRepository : GenericRepository<SessionYear>, ISessionYearRepository
    {
        public SessionYearRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<PaginationResponse<SessionYear>> GetAllWithPagination(ListPaginationRequest request)
        {

            var records = await dbContext.SessionYears.OrderByDescending(x => x.CreationDate)
                    .AsNoTracking()
                    .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 : (
                    x.Title.Contains(request.SearchStatement)
                    ))
                    .ApplyPagination(request)
                    .ToListAsync();
            var count = await dbContext.SessionYears.AsNoTracking().CountAsync();
            return new PaginationResponse<SessionYear> { Count = count, Records = records };

        }
    }
}
