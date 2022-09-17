using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Announcement
{
    public class AnnouncementListDto:BaseDto
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public AnnouncementType Type { get; set; }
    }
}
