using AutoMapper;
using CMS_BackEnd.Application.Contracts;
using CMS_BackEnd.Application.DTOs.Announcement;
using CMS_BackEnd.Application.Features.Announcement.Requests.Commands;
using CMS_BackEnd.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Announcement.Handlers.Commands
{
    public class CreateAnnouncementRequestHandler : BaseRequestHandler, IRequestHandler<CreateAnnouncementRequest, AnnouncementRecordDto>
    {
        public CreateAnnouncementRequestHandler(IAnnouncementRepository announcement,IMapper mapper):base(announcement,mapper)
        {

        }
        public async Task<AnnouncementRecordDto> Handle(CreateAnnouncementRequest request, CancellationToken cancellationToken)
        {
            var ann = mapper.Map<Domain.Announcement>(request.announcement);
            var record = await announcement.Add(ann);
            request.announcement.Id= record.Id;
            return request.announcement;
        }
    }
}
