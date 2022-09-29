using AutoMapper;
using CMS_Backend.Persistence.ExtensionMethods;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.IncomingTransaction;
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
    public class IncomeTransactionRepository : GenericRepository<IncomeTransaction>, IIncomingTransactionRepository
    {
        private readonly IMapper mapper;

        public IncomeTransactionRepository(ColleageManagementDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<IReadOnlyList<StudentIncomingTransactionsDto>> GetStudentIncomingTransactions(int studentId, DateTime? start, DateTime? end)
        {
            var records = await dbContext.IncomeTransactions.AsNoTracking().Include(x => x.Course).ToListAsync();
            return mapper.Map<IReadOnlyList<StudentIncomingTransactionsDto>>(records);
        }
        public override async Task<IReadOnlyList<IncomeTransaction>> GetAll()
        {
            var records = await dbContext.IncomeTransactions.AsNoTracking().Include(x => x.Student).Include(x => x.Course).ToListAsync();
            return records;
        }
        public override async Task<IReadOnlyList<IncomeTransaction>> GetAllWithPagination(ListPaginationRequest request)
        {
            var records = await dbContext.IncomeTransactions.AsNoTracking()
                .Include(x => x.Student).Include(x => x.Course)
                .ApplyPagination(request).ToListAsync();
            return records;
        }
    }
}
