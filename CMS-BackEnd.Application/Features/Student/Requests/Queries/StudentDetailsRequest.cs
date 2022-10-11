using CMS_BackEnd.Application.DTOs.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Requests.Queries
{
    public class StudentDetailsRequest : IRequest<UpdateStudentDto>
    {
        public int Id { get; set; }
    }
}
