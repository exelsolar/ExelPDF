using Ecotiza.PDFBase.Infrastructure.Constants;

namespace Ecotiza.PDFBase.Infrastructure.Decimals
{
    public static class DecimalExtensions
    {
        public static bool IsZero(this decimal value)
        {
            return value == 0;
        }

        public static bool IsGreaterThanZero(this decimal value)
        {
            return !IsZero(value);
        }

        public static bool IsEquals(this decimal value1, decimal value2)
        {
            return value1 == value2;
        }

        public static bool IsNotEquals(this decimal value1, decimal value2)
        {
            return !value1.IsEquals(value2);
        }

        public static bool IsGreaterThan(this decimal intValue, decimal valueToCompare)
        {
            return intValue > valueToCompare;
        }

        public static bool IsGreaterOrEqualThan(this decimal intValue, decimal valueToCompare)
        {
            return intValue >= valueToCompare;
        }

        public static bool IsLessThan(this decimal intValue, decimal valueToCompare)
        {
            return intValue < valueToCompare;
        }

        public static bool IsLessOrEqualThan(this decimal intValue, decimal valueToCompare)
        {
            return intValue <= valueToCompare;
        }

        public static int Ceiling(this decimal value)
        {
            return (int)System.Math.Ceiling(value);
        }

        public static decimal GetValue(this decimal? intValue)
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

        public static decimal RoundDecimal(this decimal value)
        {
            return System.Math.Round(value, GlobalConstants.NumberOfDecimals);
        }
    }
}