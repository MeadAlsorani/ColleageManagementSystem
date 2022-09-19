using CMS_BackEnd.Application.DTOs.Course;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Requests.Commands
{
    public class UpdateCourseRequest : IRequest<Unit>
    {
        public CreateCourseDto Course { get; set; }
    }
}
