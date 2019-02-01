using System;
using System.Globalization;

namespace Ecotiza.PDFBase.Infrastructure.Integers
{
    public static class IntegerExtensions
    {
        public static bool IsEqualTo(this int intValue, int valueToCompare)
        {
            return intValue == valueToCompare;
        }

        public static bool IsNotEqualTo(this int intValue, int valueToCompare)
        {
            return !IsEqualTo(intValue, valueToCompare);
        }

        public static bool IsGreaterThan(this int intValue, int valueToCompare)
        {
            return intValue > valueToCompare;
        }

        public static bool IsLessThan(this int intValue, int valueToCompare)
        {
            return intValue < valueToCompare;
        }

        public static bool IsZero(this int value)
        {
            return value == 0;
        }

        public static bool IsNotZero(this int value)
        {
            return !IsZero(value);
        }

        public static T ConvertToEnum<T>(this int value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), value);
        }

        public static bool IsEquals(this int value1, int value2)
        {
            return value1 == value2;
        }   

        public static bool IsNotEquals(this int value1, int value2)
        {
            return !value1.IsEquals(value2);
        }

        public static bool IsGreaterOrEqualThan(this int value, int valueToCompare)
        {
            return IsGreaterThan(value, valueToCompare) || IsEquals(value, valueToCompare);
        }

        public static bool IsLessThanOrEqualThan(this int value, int valueToCompare)
        {
            return IsLessThan(value, valueToCompare) || IsEquals(value, valueToCompare);
        }

        public static bool IsGreaterThanZero(this int value)
        {
            return IsGreaterThan(value, 0);
        }

        public static bool IsEven(this int value)
        {
            return value %2 != 0;
        }

        public static bool IsOdd(this int value)
        {
            return !IsEven(value);
        }

        public static string ConvertToString(this int intValue)
        {
            return intValue.ToString(CultureInfo.InvariantCulture);
        }

        public static int GetValue(this int? intValue)
        {
            try
            {
                return intValue.Value;
            }
            catch
            {
                return 0;
            }
        }
    }
}