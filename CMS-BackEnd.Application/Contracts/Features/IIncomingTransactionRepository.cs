using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Contracts.Features
{
    public interface IIncomingTransactionRepository : IGenericRepository<IncomeTransaction>
    {
        public Task<IReadOnlyList<StudentIncomingTransactionsDto>> GetStudentIncomingTransactions(int studentId, DateTime? start, DateTime? end);
    }
}
