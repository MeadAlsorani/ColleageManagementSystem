using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Requests.Queries
{
    public class CoursesListRequest:IRequest<IReadOnlyList<CourseListDto>>
    {
        public ListPaginationRequest? pagination { get; set; }
    }
}
