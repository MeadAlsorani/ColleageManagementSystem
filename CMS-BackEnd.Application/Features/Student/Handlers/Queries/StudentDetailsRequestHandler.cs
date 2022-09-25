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
    public class StudentDetailsRequestHandler : BaseRequestHandler, IRequestHandler<StudentDetailsRequest, StudentDto>
    {
        public StudentDetailsRequestHandler(IStudentRepository student, IMapper mapper) : base(student, mapper)
        {
        }
        public async Task<StudentDto> Handle(StudentDetailsRequest request, CancellationToken cancellationToken)
        {
            var record = await repository.Get(request.Id);
            return mapper.Map<StudentDto>(record);
        }
    }
}
