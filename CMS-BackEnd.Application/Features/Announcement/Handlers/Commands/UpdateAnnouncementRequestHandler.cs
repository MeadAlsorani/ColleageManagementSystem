using AutoMapper;
using CMS_BackEnd.Application.Contracts;
using CMS_BackEnd.Application.Features.Announcement.Requests.Commands;
using MediatR;

namespace CMS_BackEnd.Application.Features.Announcement.Handlers.Commands
{
    public class UpdateAnnouncementRequestHandler :BaseRequestHandler, IRequestHandler<UpdateAnnouncementRequest, Unit>
    {
        public UpdateAnnouncementRequestHandler(IAnnouncementRepository repository,IMapper mapper):base(repository,mapper)
        {

        }
        public async Task<Unit> Handle(UpdateAnnouncementRequest request, CancellationToken cancellationToken)
        {
            await announcement.Update(mapper.Map<Domain.Announcement>(request.record));
            return Unit.Value;
        }
    }
}
