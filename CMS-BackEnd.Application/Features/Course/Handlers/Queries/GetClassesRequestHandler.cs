using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.Features.Course.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Handlers.Queries
{
    public class GetClassesRequestHandler : BaseRequestHandler, IRequestHandler<GetClassesRequest, IReadOnlyList<ClassListDto>>
    {
        public GetClassesRequestHandler(ICourseRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<IReadOnlyList<ClassListDto>> Handle(GetClassesRequest request, CancellationToken cancellationToken)
        {
            var records = await repository.GetClassList();
            return records;
        }
    }
}
