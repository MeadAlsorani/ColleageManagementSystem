using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Requests.Queries
{
    public class StudentsListRequest : IRequest<PaginationResponse<StudentDto>>
    {
        public ListPaginationRequest? pagination { get; set; }
    }
}
