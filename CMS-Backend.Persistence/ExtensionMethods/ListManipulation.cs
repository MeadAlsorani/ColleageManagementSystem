using CMS_BackEnd.Application.Features.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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
        private static Expression<Func<T, bool>> GetExpression<T>(Dictionary<string, object> keyValuePairs)
        {
            var param = Expression.Parameter(typeof(T), "x");
            Expression expression = null;
            foreach (var key in keyValuePairs.Keys)
            {
                var arg = Expression.Property(param, key);
                var t = Expression.Call(arg, "ToString", Type.EmptyTypes);
                var exp = Expression.Equal(t, Expression.Constant(keyValuePairs[key].ToString()));
                if (expression is null)
                {
                    expression = exp;
                }
                else
                {
                    expression = Expression.And(expression, exp);
                }
            }
            var func = Expression.Lambda<Func<T, bool>>(expression!, param);
            return func;

        }
        public static IOrderedQueryable<T> OrderBy<T>(
    this IQueryable<T> source,
    string property)
        {
            return ApplyOrder<T>(source, property, "OrderBy");
        }

        public static IOrderedQueryable<T> OrderByDescending<T>(
            this IQueryable<T> source,
            string property)
        {
            return ApplyOrder<T>(source, property, "OrderByDescending");
        }

        public static IOrderedQueryable<T> ThenBy<T>(
            this IOrderedQueryable<T> source,
            string property)
        {
            return ApplyOrder<T>(source, property, "ThenBy");
        }

        public static IOrderedQueryable<T> ThenByDescending<T>(
            this IOrderedQueryable<T> source,
            string property)
        {
            return ApplyOrder<T>(source, property, "ThenByDescending");
        }
        static IOrderedQueryable<T> ApplyOrder<T>(
    IQueryable<T> source,
    string property,
    string methodName)
        {
            string[] props = property.Split('.');
            Type type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            ParameterExpression arg = Expression.Parameter(type, "x");
            Expression expr = arg;
            foreach (string prop in props)
            {
                // use reflection (not ComponentModel) to mirror LINQ
                PropertyInfo pi = properties.FirstOrDefault(x => x.Name == property);
                expr = Expression.Property(expr, pi);
                type = pi.PropertyType;
            }
            Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
            LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

            object result = typeof(Queryable).GetMethods().Single(
                    method => method.Name == methodName
                            && method.IsGenericMethodDefinition
                            && method.GetGenericArguments().Length == 2
                            && method.GetParameters().Length == 2)
                    .MakeGenericMethod(typeof(T), type)
                    .Invoke(null, new object[] { source, lambda })!;
            return (IOrderedQueryable<T>)result;
        }
    }
}
