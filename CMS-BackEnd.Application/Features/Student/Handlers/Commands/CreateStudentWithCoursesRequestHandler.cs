using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Student.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Handlers.Commands
{
    public class CreateStudentWithCoursesRequestHandler : BaseRequestHandler, IRequestHandler<CreateStudentWithCoursesRequest, Unit>
    {
        public CreateStudentWithCoursesRequestHandler(IStudentRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(CreateStudentWithCoursesRequest request, CancellationToken cancellationToken)
        {
            await repository.CreateStudentWithCourses(request.student);
            return Unit.Value;
        }
    }
}
