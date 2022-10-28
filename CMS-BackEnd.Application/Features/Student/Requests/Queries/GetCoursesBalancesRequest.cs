using CMS_BackEnd.Application.DTOs.Course;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Requests.Queries
{
    public class GetCoursesBalancesRequest:IRequest<IReadOnlyList<CourseBalanceDto>>
    {
        public int Id { get; set; }
    }
}
