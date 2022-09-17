using AutoMapper;
using CMS_BackEnd.Application.Contracts;
using CMS_BackEnd.Application.DTOs.Announcement;
using CMS_BackEnd.Application.Features.Announcement.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Announcement.Handlers.Queries
{
    public class AnnouncementDetailsRequestHandler :BaseRequestHandler, IRequestHandler<AnnouncementDetailsRequest, AnnouncementRecordDto>
    {
        
        public AnnouncementDetailsRequestHandler(IAnnouncementRepository announcement, IMapper mapper):base(announcement, mapper)
        {
        }
        public async Task<AnnouncementRecordDto> Handle(AnnouncementDetailsRequest request, CancellationToken cancellationToken)
        {
            var record = await announcement.Get(request.Id);
            return mapper.Map<AnnouncementRecordDto>(record);
        }
    }
}
