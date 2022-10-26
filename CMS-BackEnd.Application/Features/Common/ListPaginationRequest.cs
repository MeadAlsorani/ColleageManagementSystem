using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Common
{
    public class ListPaginationRequest
    {
        public ListPaginationRequest()
        {
            PageSize = 0;
            PageIndex = 0;
            Ascending = true;
            SortBy = "Id";
            SearchStatement = "";
        }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public bool Ascending { get; set; }
        public string? SortBy { get; set; }
        public string SearchStatement { get; set; }
    }
}
