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
    public class StudentsListRequestHandler : BaseRequestHandler, IRequestHandler<StudentsListRequest, List<StudentDto>>
    {
        public StudentsListRequestHandler(IStudentRepository student, IMapper mapper) : base(student, mapper)
        {
        }
        public async Task<List<StudentDto>> Handle(StudentsListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.Student> students;
            if (request.pagination == null)
                students = await repository.GetAll();
            else
                students = await repository.GetAllWithPagination(request.pagination);
            return mapper.Map<List<StudentDto>>(students);
        }
    }
}
