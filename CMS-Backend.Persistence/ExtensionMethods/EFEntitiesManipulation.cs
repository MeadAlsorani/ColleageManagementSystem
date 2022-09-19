using CMS_BackEnd.Application.Features.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.ExtensionMethods
{
    public static class EFEntitiesManipulation
    {
        public static IQueryable<T> SortBy<T>(this IQueryable<T> data,Expression<Func<T,object>> expression,ListPaginationRequest request)
        {
            var selectorBody = expression.Body;
            if (selectorBody.NodeType == ExpressionType.Convert)
                selectorBody = ((UnaryExpression)selectorBody).Operand;
            var selector = Expression.Lambda(selectorBody, expression.Parameters);
            var queryBody = Expression.Call(typeof(Queryable),
                request.Ascending? "OrderBy" : "OrderByDescending",
                new Type[] { typeof(T), selectorBody.Type },
                data.Expression, Expression.Quote(selector));
            var result = data.Provider.CreateQuery<T>(queryBody);
            return result;
        }
    }
}
