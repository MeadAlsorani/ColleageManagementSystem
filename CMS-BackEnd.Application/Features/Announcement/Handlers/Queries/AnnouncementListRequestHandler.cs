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
    public class AnnouncementListRequestHandler : BaseRequestHandler, IRequestHandler<AnnouncementListRequest, IReadOnlyList<AnnouncementListDto>>
    {

        public AnnouncementListRequestHandler(IAnnouncementRepository announcement, IMapper mapper) : base(announcement, mapper)
        {
        }
        public async Task<IReadOnlyList<AnnouncementListDto>> Handle(AnnouncementListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.Announcement> records;
            if (request.request != null)
            {
                records = await announcement.GetAllWithPagination(request.request);
            }
            else
            {
                records=await announcement.GetAll();
            }
            return mapper.Map<IReadOnlyList<AnnouncementListDto>>(records);
        }
    }
}
