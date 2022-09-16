using AutoMapper;
using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Application.Features.Attendance.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Handlers.Queries
{
    public class StudentsListRequestHandler : IRequestHandler<StudentsListRequest, List<StudentDto>>
    {
        private readonly IStudentRepository student;
        private readonly IMapper mapper;

        public StudentsListRequestHandler(IStudentRepository student, IMapper mapper)
        {
            this.student = student;
            this.mapper = mapper;
        }
        public async Task<List<StudentDto>> Handle(StudentsListRequest request, CancellationToken cancellationToken)
        {
            var records = await student.GetAll();
            return mapper.Map<List<StudentDto>>(records);
        }
    }
}
