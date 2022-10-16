using AutoMapper;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Loan;
using CMS_BackEnd.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly ColleageManagementDbContext dbContext;
        private readonly IMapper mapper;

        public LoanRepository(ColleageManagementDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task DeleteSalaryTemplate(int id)
        {
            var loan = dbContext.Loans.FirstOrDefault(x => x.Id == id);
            dbContext.Loans.Remove(loan);
            await dbContext.SaveChangesAsync();
        }

        public Task<Loan> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Loan>> GetAll(int salaryTemplateId)
        {
            var records = await dbContext.Loans.AsNoTracking().Where(x => x.SalaryTemplateId == salaryTemplateId).ToListAsync();
            return records;
        }

        public async Task PostSalaryTemplate(Loan loan)
        {
            await dbContext.Loans.AddAsync(loan);
            await dbContext.SaveChangesAsync();

            var savedLoan = dbContext.Loans.AsNoTracking().Include(z => z.SalaryTemplate).ThenInclude(x => x.Staff).FirstOrDefault(x => x.Id == loan.Id);
            await dbContext.OutcomeTransactions.AddAsync(new OutcomeTransaction()
            {
                Amount = loan.Amount,
                CreationDate = loan.CreationDate,
                Date = loan.Date,
                Description = $"LOAN - {savedLoan?.SalaryTemplate?.Staff?.FirstName} {savedLoan?.SalaryTemplate?.Staff?.LastName} ",
                StaffId = savedLoan?.SalaryTemplate?.Staff?.Id,
                Type = OutcomeType.Salary,
            });
            dbContext.SaveChanges();
        }

        public async Task PutSalaryTemplate(Loan loan)
        {
            dbContext.Loans.Update(loan);
            await dbContext.SaveChangesAsync();
        }
    }
}
