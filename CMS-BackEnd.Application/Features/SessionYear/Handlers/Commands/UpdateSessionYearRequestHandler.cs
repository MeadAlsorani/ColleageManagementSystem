using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.SessionYear;
using CMS_BackEnd.Application.Features.SessionYear.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SessionYear.Handlers.Commands
{
    public class UpdateSessionYearRequestHandler : BaseRequestHandler, IRequestHandler<UpdateSessionYearRequest, UpdateSessionYearDto>
    {
        public UpdateSessionYearRequestHandler(ISessionYearRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public async Task<UpdateSessionYearDto> Handle(UpdateSessionYearRequest request, CancellationToken cancellationToken)
        {
            await repository.Update(mapper.Map<Domain.SessionYear>(request.data));
            return request.data;
        }
    }
}
