using CMS_BackEnd.Application.DTOs.Announcement;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Announcement.Requests.Commands
{
    public class CreateAnnouncementRequest:IRequest<AnnouncementRecordDto>
    {
        public AnnouncementRecordDto announcement { get; set; }
    }
}
