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
    public class UpdateStudentRequestHandler : BaseRequestHandler, IRequestHandler<UpdateStudentRequest, Unit>
    {
        public UpdateStudentRequestHandler(IStudentRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(UpdateStudentRequest request, CancellationToken cancellationToken)
        {
            var student = mapper.Map<Domain.Student>(request.Student);
            await repository.Update(student);
            return Unit.Value;
        }
    }
}
