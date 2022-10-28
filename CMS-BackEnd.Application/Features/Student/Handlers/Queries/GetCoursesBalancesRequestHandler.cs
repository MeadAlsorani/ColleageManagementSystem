using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.Features.Student.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Handlers.Queries
{
    public class GetCoursesBalancesRequestHandler : BaseRequestHandler, IRequestHandler<GetCoursesBalancesRequest, IReadOnlyList<CourseBalanceDto>>
    {
        public GetCoursesBalancesRequestHandler(IStudentRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IReadOnlyList<CourseBalanceDto>> Handle(GetCoursesBalancesRequest request, CancellationToken cancellationToken)
        {
            return await repository.GetCourseBalances(request.Id);
        }
    }
}
