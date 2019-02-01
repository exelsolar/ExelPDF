using System;
using System.Linq;
using System.Linq.Expressions;

namespace Ecotiza.PDFBase.Infrastructure.Queries
{
    public static class Translation<T> //where T : class
    {
        public static Expression<Func<T, object>> LambdaExpression(string property)
        {
            ParameterExpression argParam = Expression.Parameter(typeof (T), "s");
            Expression nameProperty = Expression.Property(argParam, property);
            //var lambda = Expression.Lambda<Func<T, object>>(nameProperty, argParam);
            if (nameProperty.Type.IsValueType)
            {
                var underlyingType = typeof (T);
                var body = Expression.Property(
                    Expression.Convert(argParam, underlyingType), property
                    );
                return Expression.Lambda<Func<T, object>>(body, argParam);
            }
                return Expression.Lambda<Func<T, object>>(nameProperty, argParam);
        }

        public static Expression<Func<T, object>> LambdaExpressionAndConvertPropertyType(string property)
        {
            ParameterExpression argParam = Expression.Parameter(typeof (T), "s");
            Expression nameProperty = Expression.Property(argParam, property);
            Expression conversion = Expression.Convert(nameProperty, typeof (object));
            var lambda = Expression.Lambda<Func<T, object>>(conversion, argParam);
            return lambda;
        }

        public static Expression<Func<T, TKey>> LambdaExpression<TKey>(string property)
        {
            ParameterExpression argParam = Expression.Parameter(typeof(T), "s");
            //Expression nameProperty = Expression.Property(argParam, property);
            Expression body = argParam;
            foreach (var member in property.Split('.'))
            {
                body = Expression.PropertyOrField(body, member);
            }
            Expression conversion = Expression.Convert(body, typeof(TKey));
            var lambda = Expression.Lambda<Func<T, TKey>>(conversion, argParam);
            return lambda;
        }

        public static IQueryable<T> SortByType<TKey>(string sort, string sortBy, IQueryable<T> query)
        {
            var property = LambdaExpression<TKey>(sortBy);
            bool isOrderedAlready = query.Expression.Type == typeof(IOrderedQueryable<T>);
            if (sort.Equals(QueryConstants.OrderByDescending))
            {
                if (isOrderedAlready)
                {
                    return ((IOrderedQueryable<T>)query).ThenByDescending(property);
                }
                else
                {
                    return query.OrderByDescending(property);
                }
            }

            if (sort.Equals(QueryConstants.OrderByAscending))
            {
                if (isOrderedAlready)
                {
                    return ((IOrderedQueryable<T>)query).ThenByDescending(property);
                }
                else
                {
                    return query.OrderBy(property);
                }
            }

            return null;
        }
    }
}