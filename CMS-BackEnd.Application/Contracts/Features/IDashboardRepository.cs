using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Contracts.Features
{
    public interface IDashboardRepository
    {
        public Task<CountsResponse> Counts();
        public Task<Dictionary<string, double>> GetIncomesSumByMonth(int month);
        public Task<Dictionary<string, double>> GetIncomesSum();
        public Task<Dictionary<string, double>> GetOutcomesSumByMonth(int month);
        public Task<Dictionary<string, double>> GetOutcomesSum();
        public Task<Dictionary<string, int>> GetAttendanceCountsToday();
    }
}
