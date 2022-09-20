using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.Features.Announcement.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Announcement.Handlers.Commands
{
    public class DeleteAnnouncementRequestHandler :BaseRequestHandler, IRequestHandler<DeleteAnnouncementRequest, Unit>
    {
        public DeleteAnnouncementRequestHandler(IAnnouncementRepository announcement, IMapper mapper) : base(announcement, mapper)
        {

        }
        public async Task<Unit> Handle(DeleteAnnouncementRequest request, CancellationToken cancellationToken)
        {
            await announcement.Delete(request.Id);
            return Unit.Value;
        }
    }
}
