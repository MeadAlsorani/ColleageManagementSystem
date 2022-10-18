using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.Repositories
{
    public class DashbordRepository : IDashboardRepository
    {
        private readonly ColleageManagementDbContext context;

        public DashbordRepository(ColleageManagementDbContext context)
        {
            this.context = context;
        }
        public async Task<CountsResponse> Counts()
        {
            CountsResponse counts = new();
            counts.StaffCount = await context.Staffs.CountAsync();
            counts.StudentCount = await context.Students.CountAsync();
            return counts;
        }

        public async Task<Dictionary<string, int>> GetAttendanceCountsToday()
        {
            var attendances = await context.Attendances.AsNoTracking().Where(x => x.Date == DateTime.Now.Date).ToListAsync();
            Dictionary<string, int> pairs = new();
            pairs.Add("students", attendances.Count(x => x.StudentId != null));
            pairs.Add("staffs", attendances.Count(x => x.StaffId != null));
            return pairs;
        }

        public async Task<Dictionary<string, double>> GetIncomesSum()
        {
            var incomes = await context.IncomeTransactions.AsNoTracking().Where(x => x.Date.Year == DateTime.Now.Year).ToListAsync();
            Dictionary<string, double> pairs = new();
            pairs.Add("jan", incomes.Where(x => x.Date.Month == 1).Sum(z => z.Amount));
            pairs.Add("feb", incomes.Where(x => x.Date.Month == 2).Sum(z => z.Amount));
            pairs.Add("march", incomes.Where(x => x.Date.Month == 3).Sum(z => z.Amount));
            pairs.Add("apr", incomes.Where(x => x.Date.Month == 4).Sum(z => z.Amount));
            pairs.Add("may", incomes.Where(x => x.Date.Month == 5).Sum(z => z.Amount));
            pairs.Add("jun", incomes.Where(x => x.Date.Month == 6).Sum(z => z.Amount));
            pairs.Add("jul", incomes.Where(x => x.Date.Month == 7).Sum(z => z.Amount));
            pairs.Add("aug", incomes.Where(x => x.Date.Month == 8).Sum(z => z.Amount));
            pairs.Add("sep", incomes.Where(x => x.Date.Month == 9).Sum(z => z.Amount));
            pairs.Add("oct", incomes.Where(x => x.Date.Month == 10).Sum(z => z.Amount));
            pairs.Add("nov", incomes.Where(x => x.Date.Month == 11).Sum(z => z.Amount));
            pairs.Add("dec", incomes.Where(x => x.Date.Month == 12).Sum(z => z.Amount));
            return pairs;
        }

        public async Task<Dictionary<string, double>> GetIncomesSumByMonth(int month)
        {
            var nowDate = DateTime.Now.Date;
            var first = new DateTime(nowDate.Year, month, 0);
            var last = new DateTime(nowDate.Year, month + 1, -1);
            var sum = await context.IncomeTransactions.AsNoTracking()
                .Where(x => x.Date >= first && x.Date <= last)
                .SumAsync(x => x.Amount);
            var pari = new Dictionary<string, double>();
            pari.Add("total", sum);
            return pari;
        }

        public async Task<Dictionary<string, double>> GetOutcomesSum()
        {
            var outcomes = await context.OutcomeTransactions.AsNoTracking().Where(x => x.Date.Year == DateTime.Now.Year).ToListAsync();

            Dictionary<string, double> pairs = new();
            pairs.Add("jan", outcomes.Where(x => x.Date.Month == 1).Sum(z => z.Amount));
            pairs.Add("feb", outcomes.Where(x => x.Date.Month == 2).Sum(z => z.Amount));
            pairs.Add("march", outcomes.Where(x => x.Date.Month == 3).Sum(z => z.Amount));
            pairs.Add("apr", outcomes.Where(x => x.Date.Month == 4).Sum(z => z.Amount));
            pairs.Add("may", outcomes.Where(x => x.Date.Month == 5).Sum(z => z.Amount));
            pairs.Add("jun", outcomes.Where(x => x.Date.Month == 6).Sum(z => z.Amount));
            pairs.Add("jul", outcomes.Where(x => x.Date.Month == 7).Sum(z => z.Amount));
            pairs.Add("aug", outcomes.Where(x => x.Date.Month == 8).Sum(z => z.Amount));
            pairs.Add("sep", outcomes.Where(x => x.Date.Month == 9).Sum(z => z.Amount));
            pairs.Add("oct", outcomes.Where(x => x.Date.Month == 10).Sum(z => z.Amount));
            pairs.Add("nov", outcomes.Where(x => x.Date.Month == 11).Sum(z => z.Amount));
            pairs.Add("dec", outcomes.Where(x => x.Date.Month == 12).Sum(z => z.Amount));
            return pairs;
        }

        public async Task<Dictionary<string, double>> GetOutcomesSumByMonth(int month)
        {
            var nowDate = DateTime.Now.Date;
            var first = new DateTime(nowDate.Year, month, 0);
            var last = new DateTime(nowDate.Year, month + 1, -1);
            var sum = await context.OutcomeTransactions.AsNoTracking()
                .Where(x => x.Date >= first && x.Date <= last)
                .SumAsync(x => x.Amount);
            var pari = new Dictionary<string, double>();
            pari.Add("total", sum);
            return pari;
        }

    }
}
