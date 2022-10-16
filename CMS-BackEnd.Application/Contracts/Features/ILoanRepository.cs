using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.DTOs.Loan;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Contracts.Features
{
    public interface ILoanRepository
    {
        public Task<Loan> Get(int id);
        public Task<IReadOnlyList<Loan>> GetAll(int salaryTemplateId);
        public Task PostSalaryTemplate(Loan loan);
        public Task PutSalaryTemplate(Loan loan);
        public Task DeleteSalaryTemplate(int id);

    }
}
