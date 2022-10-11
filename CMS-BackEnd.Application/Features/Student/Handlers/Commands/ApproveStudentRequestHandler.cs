using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Student.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Handlers.Commands
{
    public class ApproveStudentRequestHandler : BaseRequestHandler, IRequestHandler<ApproveStudentRequest, Unit>
    {
        public ApproveStudentRequestHandler(IStudentRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(ApproveStudentRequest request, CancellationToken cancellationToken)
        {
            await repository.ApproveStudent(request.Id);
            return Unit.Value;
        }
    }
}
