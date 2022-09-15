using CMS_BackEnd.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class Announcement : BaseModelClass
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public AnnouncementType Type { get; set; }
        public string? Message { get; set; }
    }

    public enum AnnouncementType
    {
        Notice=1,
        Event,
        Holiday
    }
}
