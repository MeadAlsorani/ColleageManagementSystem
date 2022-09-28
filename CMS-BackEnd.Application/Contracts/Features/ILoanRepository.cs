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
    public interface ILoanRepository : IGenericRepository<Loan>
    {
        public Task<IReadOnlyList<LoanRecordDto>> GetStaffLoans(int staffId);
    }
}
