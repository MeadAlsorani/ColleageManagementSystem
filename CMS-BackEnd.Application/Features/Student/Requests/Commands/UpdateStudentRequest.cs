using CMS_BackEnd.Application.DTOs.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Requests.Commands
{
    public class UpdateStudentRequest : IRequest<Unit>
    {
        public UpdateStudentDto? Student { get; set; }
    }
}
