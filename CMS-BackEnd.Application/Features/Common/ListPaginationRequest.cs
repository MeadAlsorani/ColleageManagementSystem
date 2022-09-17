using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Common
{
    public class ListPaginationRequest
    {
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public bool Ascending { get; set; }
        public string? SortBy { get; set; }
    }
}
