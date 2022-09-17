using AutoMapper;
using CMS_BackEnd.Application.Contracts;
using CMS_BackEnd.Application.Features.Student.Requests.Commands;
using MediatR;
namespace CMS_BackEnd.Application.Features.Student.Handlers.Commands
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, int>
    {
        private readonly IStudentRepository student;
        private readonly IMapper mapper;

        public CreateStudentCommandHandler(IStudentRepository student, IMapper mapper)
        {
            this.student = student;
            this.mapper = mapper;
        }
        public async Task<int> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var stu = mapper.Map<Domain.Student>(request.Student);
            var result = await student.Add(stu);
            return result.Id;
        }
    }
}
