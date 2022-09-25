using CMS_BackEnd.Application.DTOs.Announcement;
using CMS_BackEnd.Application.Features.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Announcement.Requests.Queries
{
    public class AnnouncementListRequest : IRequest<List<AnnouncementListDto>>
    {
        public ListPaginationRequest? request { get; set; }
    }
}
