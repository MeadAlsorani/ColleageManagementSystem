using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Course.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Handlers.Commands
{
    public class DeleteCourseRequestHandler : BaseRequestHandler, IRequestHandler<DeleteCourseRequest, Unit>
    {
        public DeleteCourseRequestHandler(ICourseRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(DeleteCourseRequest request, CancellationToken cancellationToken)
        {
            await repository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
