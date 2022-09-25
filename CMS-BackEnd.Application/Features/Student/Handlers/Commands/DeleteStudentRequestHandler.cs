using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Student.Requests.Commands;
using MediatR;

namespace CMS_BackEnd.Application.Features.Student.Handlers.Commands
{
    public class DeleteStudentRequestHandler : BaseRequestHandler, IRequestHandler<DeleteStudentRequest, Unit>
    {
        public DeleteStudentRequestHandler(IStudentRepository repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(DeleteStudentRequest request, CancellationToken cancellationToken)
        {
            await repository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
