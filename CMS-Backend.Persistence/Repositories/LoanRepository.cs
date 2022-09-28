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
    public class LoanRepository : GenericRepository<Loan>, ILoanRepository
    {
        private readonly IMapper mapper;

        public LoanRepository(ColleageManagementDbContext dbContext, IMapper mapper) : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<IReadOnlyList<LoanRecordDto>> GetStaffLoans(int staffId)
        {
            var loans = await dbContext.Loans.AsNoTracking().Where(x => x.StaffId == staffId).ToListAsync();
            return mapper.Map<IReadOnlyList<LoanRecordDto>>(loans);
        }
    }
}
