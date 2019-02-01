using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ecotiza.PDFBase.Infrastructure.Enums
{
    public static class EnumExtensions
    {
        public static List<Enumerator> ConvertToCollection(this Enum enumerator)
        {
            var type = enumerator.GetType();
            return Enum.GetNames(type)
                    .Select(name => new Enumerator { Name = name, Value = (int)Enum.Parse(type, name) })
                    .ToList();
        }

        public static int GetValue(this object key)
        {
            var type = key.GetType();
            return (int)Enum.Parse(type, key.ToString());
        }

        public static int GetValue(this Enum enumerator, string key)
        {
            var type = enumerator.GetType();
            return (int)Enum.Parse(type, key);
        }

        public static bool IsEqualTo(this Enum enumerator1, Enum enumerator2)
        {
            return Equals(enumerator1, enumerator2);
        }

        public static bool IsNotEqualTo(this Enum enumerator1, Enum enumerator2)
        {
            return !IsEqualTo(enumerator1, enumerator2);
        }

        public static int RetrieveMaxValue<TEnum>(this TEnum enumerator)
        {
            return Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Max().GetValue();
        }

        public static int RetrieveMinValue<TEnum>(this TEnum enumerator)
        {
            return Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Min().GetValue();
        }

        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<System.ComponentModel.DataAnnotations.DisplayAttribute>()
                .Name;
        }

        public static string GetDisplayDescription(this Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<System.ComponentModel.DataAnnotations.DisplayAttribute>()
                .Description;
        }
    }
}