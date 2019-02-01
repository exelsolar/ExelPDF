using System.Collections.Generic;
using System.Linq;
using Ecotiza.PDFBase.Infrastructure.Integers;

namespace Ecotiza.PDFBase.Infrastructure.Objects
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object value)
        {
            return value == null;
        }

        public static bool IsNotNull(this object value)
        {
            return !IsNull(value);
        }

        public static Dictionary<string, string> ConvertToDictionary(this object value)
        {
            if (value.IsNull())
                return null;

            var dictionary = (from x in value.GetType().GetProperties() select x).ToDictionary(x => x.Name,
                x => (x.GetGetMethod().Invoke(value, null) == null ? "" : x.GetGetMethod().Invoke(value, null).ToString()));
            return dictionary;
        }

        public static object ExtractProperty(this object @object, string property)
        {
            return @object.GetType().GetProperty(property).GetValue(@object, null);
        }

        public static T ExtractProperty<T>(this object @object, string property)
        {
            return (T)@object.GetType().GetProperty(property).GetValue(@object, null);
        }

        public static string ExtractName(this object @object)
        {
            var id = @object.ExtractProperty<int>("Id");
            return id.IsGreaterThanZero() ? @object.ExtractProperty("Name").ToString() : "-";
        }
    }
}