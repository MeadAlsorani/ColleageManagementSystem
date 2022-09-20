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
    public class CourseDetailsRequestHandler :BaseRequestHandler, IRequestHandler<CourseDetailsRequest, CourseDetailsDto>
    {
        public CourseDetailsRequestHandler(ICourseRepository repository,IMapper mapper):base(repository,mapper)
        {

        }
        public Task<CourseDetailsDto> Handle(CourseDetailsRequest request, CancellationToken cancellationToken)
        {
            return repository.GetCourseWithStudents(request.Id);
        }
    }
}
