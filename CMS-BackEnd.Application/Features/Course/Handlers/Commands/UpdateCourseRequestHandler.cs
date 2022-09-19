using AutoMapper;
using CMS_BackEnd.Application.Contracts;
using CMS_BackEnd.Application.Features.Course.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Handlers.Commands
{
    public class UpdateCourseRequestHandler : BaseRequestHandler, IRequestHandler<UpdateCourseRequest, Unit>
    {
        public UpdateCourseRequestHandler(ICourseRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(UpdateCourseRequest request, CancellationToken cancellationToken)
        {
            await repository.Update(mapper.Map<Domain.Course>(request.Course));
            return Unit.Value;
        }
    }
}
