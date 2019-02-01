using System;
using Ecotiza.PDFBase.Infrastructure.Collections;

namespace Ecotiza.PDFBase.Infrastructure.Strings
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !IsNullOrEmpty(value);
        }

        public static bool IsEqualTo(this string value, string valueToCompare)
        {
            return value == valueToCompare;
        }

        public static bool IsNotEqualTo(this string value, string valueToCompare)
        {
            return !IsEqualTo(value, valueToCompare);
        }

        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }

        public static decimal ToDecimal(this string value)
        {
            return decimal.Parse(value);
        }

        public static int ConvertToint(this string value)
        {
            try
            {
                var convert = Convert.ToInt32(value);
                return convert;
            }
            catch
            {
                return 0;
            }
        }
        public static string RemoveAcent(this string texto)
        {
            string consignos = "áàäéèëíìïóòöúùüÁÀÄÉÈËÍÌÏÓÒÖÚÙÜçÇ";
            string sinsignos = "aaaeeeiiiooouuuAAAEEEIIIOOOUUUcC";
            for (int v = 0; v < sinsignos.Length; v++)
            {
                string i = consignos.Substring(v, 1);
                string j = sinsignos.Substring(v, 1);
                texto = texto.Replace(i, j);
            }
            return texto.Replace(" ", "");
        }

        public static string ShuffleText(this string source)
        {
            var shuffledChars = source.ToCharArray().Shuffle();
            var sb = new System.Text.StringBuilder();

            foreach (var c in shuffledChars)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static string ToSnakeCase(this string source)
        {
            const string pattern = @"(?<=\w)(?=[A-Z])";
            string result = System.Text.RegularExpressions.Regex.Replace(source, pattern,
                "-", System.Text.RegularExpressions.RegexOptions.None);
            return result.Substring(0, 1).ToLower() + result.Substring(1);
        }
    }
}