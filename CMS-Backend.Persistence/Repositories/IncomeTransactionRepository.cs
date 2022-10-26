using AutoMapper;
using CMS_Backend.Persistence.ExtensionMethods;
using CMS_Backend.Persistence.Repositories.Base;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
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
        public override async Task<PaginationResponse<IncomeTransaction>> GetAllWithPagination(ListPaginationRequest request)
        {
            var records = await dbContext.IncomeTransactions.AsNoTracking()
                .Include(x => x.Student).Include(x => x.Course).ThenInclude(z => z.Class)
                .ApplyPagination(request)
                .OrderByDescending(x => x.CreationDate)
                .Where(x => string.IsNullOrWhiteSpace(request.SearchStatement) ? 1 == 1 :
                (x.Amount.ToString() == request.SearchStatement
                || string.Concat(x.Student == null ? "" : x.Student.FirstName, " ", x.Student == null ? "" : x.Student.LastName).Contains(request.SearchStatement)
                || string.Concat(
                    x.Course!.Class!.Name, " - ", x.Course!.Name
                    ).Contains(request.SearchStatement)
                ))
                .ToListAsync();
            var counts = await dbContext.IncomeTransactions.AsNoTracking().CountAsync();
            return new PaginationResponse<IncomeTransaction> { Count = counts, Records = records };
        }

        public async Task<IncomingTransactionAmounts> GetIncomingTransactionAmounts(int studentId, int courseId)
        {

            var agreedAmount = dbContext.Courses.AsNoTracking().FirstOrDefault(x => x.Id == courseId)?.Price ?? 0;
            var paidToDate = await dbContext.IncomeTransactions.AsNoTracking().Where(x => x.StudentId == studentId && x.CourseId == courseId).SumAsync(x => x.Amount);

            var remaining = agreedAmount - paidToDate;
            return new IncomingTransactionAmounts() { AgreedAmount = agreedAmount, PaidToDate = Convert.ToInt32(paidToDate), RemainingAmount = Convert.ToInt32(remaining) };
        }
    }
}
