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
    public class SalaryTemplateRepository : GenericRepository<SalaryTemplate>, ISalaryTemplateRepository
    {
        public SalaryTemplateRepository(ColleageManagementDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<PaginationResponse<SalaryTemplate>> GetAllWithPagination(ListPaginationRequest request)
        {
            var records = await dbContext.SalaryTemplates
                .AsNoTracking()
                .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 :
                (
                string.Concat(x.Staff!.FirstName, " ", x.Staff!.LastName).Contains(request.SearchStatement) ||
                x.BasicSalary.ToString().Contains(request.SearchStatement) ||
                x.SalaryPerHour.ToString().Contains(request.SearchStatement) ||
                x.TotalDuration.ToString() == request.SearchStatement
                ))
                .ApplyPagination(request)
                .Include(x => x.Staff)
                .Include(x => x.Loans)
                .ToListAsync();
            foreach (var record in records)
            {
                record.BasicSalary = record.BasicSalary - Convert.ToInt32(record.Loans?.Sum(x => x.Amount) ?? 0);
            }
            var count = await dbContext.SalaryTemplates.CountAsync();
            return new PaginationResponse<SalaryTemplate>() { Count = count, Records = records };
        }

        public override async Task<IReadOnlyList<SalaryTemplate>> GetAll()
        {
            var records = await dbContext.SalaryTemplates.AsNoTracking().Include(x => x.Staff).ToListAsync();
            foreach (var record in records)
            {
                record.BasicSalary = record.BasicSalary - Convert.ToInt32(record.Loans?.Sum(x => x.Amount) ?? 0);
            }
            return records;
        }
    }
}
