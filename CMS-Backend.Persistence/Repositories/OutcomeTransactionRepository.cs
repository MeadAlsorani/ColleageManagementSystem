using CMS_Backend.Persistence.ExtensionMethods;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.Features.Common;
using CMS_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;

namespace CMS_Backend.Persistence.Repositories
{
    public class OutcomeTransactionRepository : GenericRepository<OutcomeTransaction>, IOutcomeTransactionRepository
    {
        public OutcomeTransactionRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<PaginationResponse<OutcomeTransaction>> GetAllWithPagination(ListPaginationRequest request)
        {
            List<OutcomeTransaction> records = await dbContext.OutcomeTransactions
                .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 :
                (
                x.Amount.ToString().Contains(request.SearchStatement) || x.Description.Contains(request.SearchStatement)
                ))
                .OrderByDescending(x => x.CreationDate)
                    .AsNoTracking()
                    .ApplyPagination(request)
                    .ToListAsync();
            var count = await dbContext.OutcomeTransactions.AsNoTracking().CountAsync();
            return new PaginationResponse<OutcomeTransaction> { Count = count, Records = records };
        }
        public Task<double> GetTotalOutcome(int? month)
        {
            double totalOutcome = 0;
            if (month is not null && month > 0)
            {
                totalOutcome = dbContext.OutcomeTransactions.AsNoTracking().Where(z => z.Date.Month == month).Sum(x => x.Amount);
            }
            else
            {
                totalOutcome = dbContext.OutcomeTransactions.AsNoTracking().Sum(x => x.Amount);
            }
            return Task.FromResult(totalOutcome);
        }
    }
}
