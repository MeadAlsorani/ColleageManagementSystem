

using CMS_BackEnd.Application.DTOs.Announcement;
using CMS_BackEnd.Application.Features.Common;
using MediatR;

namespace CMS_BackEnd.Application.Features.Announcement.Requests.Queries
{
    public class AnnouncementListRequest : IRequest<IReadOnlyList<AnnouncementListDto>>
    {
        public ListPaginationRequest? request { get; set; }
    }
}
