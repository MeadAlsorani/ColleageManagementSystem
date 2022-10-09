using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Common;
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
    public class StudentsListRequestHandler : BaseRequestHandler, IRequestHandler<StudentsListRequest, PaginationResponse<StudentDto>>
    {
        public StudentsListRequestHandler(IStudentRepository student, IMapper mapper) : base(student, mapper)
        {
        }
        public async Task<PaginationResponse<StudentDto>> Handle(StudentsListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.Student> records;
            PaginationResponse<StudentDto> paginationResponse = new PaginationResponse<StudentDto>();
            if (request.pagination != null)
            {
                var paginationResult = await repository.GetAllWithPagination(request.pagination);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<StudentDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await repository.GetAll();
                var result = mapper.Map<IReadOnlyList<StudentDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}
