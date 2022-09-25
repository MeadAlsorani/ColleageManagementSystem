using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Student.Requests.Commands;
using MediatR;
namespace CMS_BackEnd.Application.Features.Student.Handlers.Commands
{
    public class CreateStudentRequestHandler : BaseRequestHandler, IRequestHandler<CreateStudentCommand, int>
    {

        public CreateStudentRequestHandler(IStudentRepository student, IMapper mapper) : base(student, mapper)
        {
        }
        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var stu = mapper.Map<Domain.Student>(request.Student);
            var result = await repository.Add(stu);
            return result.Id;
        }
    }
}
