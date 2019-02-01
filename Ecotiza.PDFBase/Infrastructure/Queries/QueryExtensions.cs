using System;
using System.Linq;
using System.Linq.Expressions;
using Ecotiza.PDFBase.Infrastructure.Integers;
using Ecotiza.PDFBase.Infrastructure.Strings;
using Ecotiza.PDFBase.Infrastructure.Validators;

namespace Ecotiza.PDFBase.Infrastructure.Queries
{
    public static class QueryExtensions
    {
        private const int NumberOfPagesToSubtract = 1;

        public static string SortResolver(this string sort)
        {
            if (sort.IsNotNullOrEmpty())
                return sort.ToUpper();
            return QueryConstants.OrderByAscending;
        }
        public static Expression<Func<T, object>> SortByPropertyResolver<T>(this string sortBy) where T : class
        {
            var checkProperty = Validate<T>.Property(sortBy);
            if (checkProperty.Equals(false))
                sortBy = typeof(T).GetProperties().First().Name;
         
            return Translation<T>.LambdaExpression(sortBy);
        }

        public static IQueryable<T> SortByPropertyResolver<T>(string sort, string sortBy, IQueryable<T> query) where T : class
        {
            sort = sort.SortResolver();

            var checkProperty = Validate<T>.Property(sortBy);
            if (checkProperty.Equals(false))
                sortBy = typeof(T).GetProperties().First().Name;

            var myClass = typeof(T);
            //var myProperty = myClass.GetProperties().First(prop => prop.Name.Equals(sortBy, StringComparison.OrdinalIgnoreCase));
            var myPropertyType = GetPropertyType<T>(sortBy);

            if (myPropertyType.IsGenericType)
                 myPropertyType = myPropertyType.GenericTypeArguments[0];
            
            if (myPropertyType.IsEnum)
                return Translation<T>.SortByType<int>(sort, sortBy, query);

            if (myPropertyType == typeof(string))
                return Translation<T>.SortByType<string>(sort, sortBy, query);

            if (myPropertyType == typeof(int))
                return Translation<T>.SortByType<int>(sort, sortBy, query);

            if (myPropertyType == typeof(DateTime))
                return Translation<T>.SortByType<DateTime>(sort, sortBy, query);

            return null;
        }

        private static Type GetPropertyType<T>(string property)
        {
            string propertyName = property;
            var myType = typeof(T);
            if (property.Contains("."))
            {
                // nested objects
                var properties = property.Split('.');
                var propertyInfo = myType.GetProperty(properties[0]);
                if (propertyInfo == null)
                    return null;
                foreach (var propertyNameInner in properties.Skip(1))
                {
                    myType = Type.GetType((propertyInfo.PropertyType).AssemblyQualifiedName);
                    if(myType == null) 
                        return null;
                    propertyName = propertyNameInner;
                }
            }
         return myType.GetProperties().First(prop => prop.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase)).PropertyType;
        }

        public static IQueryable<T> PaginationResolver<T>(int itemsToShow, int page, IQueryable<T> query)
        {
            if (itemsToShow.IsNotZero() && page.IsNotZero())
                return query.Skip(itemsToShow * (page - NumberOfPagesToSubtract)).Take(itemsToShow);
            return query;
        }
    }
}