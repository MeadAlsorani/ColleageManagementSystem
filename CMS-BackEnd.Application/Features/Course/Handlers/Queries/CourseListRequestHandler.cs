using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
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
    public class CourseListRequestHandler : BaseRequestHandler, IRequestHandler<CoursesListRequest, PaginationResponse<CourseListDto>>
    {
        public CourseListRequestHandler(ICourseRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
        public async Task<PaginationResponse<CourseListDto>> Handle(CoursesListRequest request, CancellationToken cancellationToken)
        {
            PaginationResponse<CourseListDto> paginationResponse = new PaginationResponse<CourseListDto>();
            IReadOnlyList<Domain.Course> records;
            if (request.pagination != null)
            {
                var paginationResult = await repository.GetAllWithPagination(request.pagination);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<CourseListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await repository.GetAll();
                var result = mapper.Map<IReadOnlyList<CourseListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}
