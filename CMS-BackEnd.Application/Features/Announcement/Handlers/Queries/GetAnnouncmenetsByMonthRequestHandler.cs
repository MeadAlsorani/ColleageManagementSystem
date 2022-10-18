using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
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
    public class GetAnnouncmenetsByMonthRequestHandler : BaseRequestHandler, IRequestHandler<GetAnnouncementsByMonthRequest, IReadOnlyList<AnnouncementListDto>>
    {
        public GetAnnouncmenetsByMonthRequestHandler(IAnnouncementRepository announcement, IMapper mapper) : base(announcement, mapper)
        {
        }

        public async Task<IReadOnlyList<AnnouncementListDto>> Handle(GetAnnouncementsByMonthRequest request, CancellationToken cancellationToken)
        {
            var records = await announcement.GetByMonth(request.Month);
            var mapped = mapper.Map<IReadOnlyList<AnnouncementListDto>>(records);
            return mapped;
        }
    }
}
