using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Common
{
    public class PaginationResponse<T>
    {
        public int Count { get; set; }
        public IReadOnlyList<T> Records { get; set; } = new List<T>();
    }
}
