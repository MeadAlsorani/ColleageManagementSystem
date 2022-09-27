using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;

namespace CMS_Backend.Persistence.Repositories
{
    public class OutcomeTransactionRepository : GenericRepository<OutcomeTransaction>, IOutcomeTransactionRepository
    {
        public OutcomeTransactionRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
        }

        public Task<double> GetTotalOutcome(int? month)
        {
            double totalOutcome = 0;
            if (month is not null && month>0)
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
