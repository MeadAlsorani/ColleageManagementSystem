using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.Features.Course.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Handlers.Commands
{
    public class CreateCourseRequestHandler : BaseRequestHandler, IRequestHandler<CreateCourseRequest, CreateCourseDto>
    {
        public CreateCourseRequestHandler(ICourseRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<CreateCourseDto> Handle(CreateCourseRequest request, CancellationToken cancellationToken)
        {
            var course = mapper.Map<Domain.Course>(request.Course);
            var addedCourse = await repository.Add(course);
            request.Course.Id = addedCourse.Id;
            return request.Course;
        }
    }
}
