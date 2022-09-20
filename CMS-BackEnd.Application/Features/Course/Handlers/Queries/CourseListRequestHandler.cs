using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.Features.Course.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Handlers.Queries
{
    public class CourseListRequestHandler : BaseRequestHandler, IRequestHandler<CoursesListRequest, IReadOnlyList<CourseListDto>>
    {
        public CourseListRequestHandler(ICourseRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
        public async Task<IReadOnlyList<CourseListDto>> Handle(CoursesListRequest request, CancellationToken cancellationToken)
        {
            var records = await repository.GetAllWithPagination(request.pagination);
            return mapper.Map<IReadOnlyList<CourseListDto>>(records);
        }
    }
}
