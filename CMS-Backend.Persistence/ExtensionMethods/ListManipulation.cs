using CMS_BackEnd.Application.Features.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.ExtensionMethods
{
    public static class ListManipulation
    {
        public static IQueryable<T> ApplyPagination<T>(this IQueryable<T> data, ListPaginationRequest request)
        {
            return data.Skip(request.PageSize * request.PageIndex).Take(request.PageSize);
        }
    }
}
