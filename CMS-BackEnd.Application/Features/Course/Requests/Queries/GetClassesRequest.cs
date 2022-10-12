using CMS_BackEnd.Application.DTOs.Course;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Requests.Queries
{
    public class GetClassesRequest : IRequest<IReadOnlyList<ClassListDto>>
    {
    }
}
