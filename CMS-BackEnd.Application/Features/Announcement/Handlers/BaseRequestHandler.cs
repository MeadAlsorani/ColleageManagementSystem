using AutoMapper;
using CMS_BackEnd.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Announcement.Handlers
{
    public class BaseRequestHandler
    {
        public readonly IAnnouncementRepository announcement;
        public readonly IMapper mapper;

        public BaseRequestHandler(IAnnouncementRepository announcement, IMapper mapper)
        {
            this.announcement = announcement;
            this.mapper = mapper;
        }
    }
}
