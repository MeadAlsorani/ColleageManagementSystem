using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Application.Features.Student.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Handlers.Queries
{
    public class GetStudentWithCoursesRequestHandler : BaseRequestHandler, IRequestHandler<GetStudentWithCoursesRequest, StudentCoursesDto>
    {
        public GetStudentWithCoursesRequestHandler(IStudentRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<StudentCoursesDto> Handle(GetStudentWithCoursesRequest request, CancellationToken cancellationToken)
        {
            var record = await repository.GetStudentWithCourses(request.Id);
            return record;
        }
    }
}
