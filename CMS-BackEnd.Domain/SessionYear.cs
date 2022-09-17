using CMS_BackEnd.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Domain
{
    public class SessionYear : BaseModelClass
    {
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
