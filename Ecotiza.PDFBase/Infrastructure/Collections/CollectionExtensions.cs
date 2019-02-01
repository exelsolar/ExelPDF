using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecotiza.PDFBase.Infrastructure.Collections
{
    public static class CollectionExtensions
    {
        public static bool IsNotEmpty(this IEnumerable<object> values)
        {
            return values != null && values.Any();
        }

        public static bool IsEmpty(this IEnumerable<object> values)
        {
            return !IsNotEmpty(values);
        }

        public static bool Exist(this IEnumerable<string> values, string valueToCompare)
        {
            return values.Any(value => value.Equals(valueToCompare));
        }

        public static bool Exist(this IEnumerable<int> values, int valueToCompare)
        {
            return values.Any(value => value.Equals(valueToCompare));
        }

        public static bool NotExist(this IEnumerable<int> values, int valueToCompare)
        {
            return !Exist(values, valueToCompare);
        }

        public static string ConvertToString(this IEnumerable<int> values)
        {
            return string.Join(",", values);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.Shuffle(new Random());
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rng)
        {
            return source.ShuffleIterator(rng);
        }

        private static IEnumerable<T> ShuffleIterator<T>(
            this IEnumerable<T> source, Random rng)
        {
            var buffer = source.ToList();
            for (int i = 0; i < buffer.Count; i++)
            {
                int j = rng.Next(i, buffer.Count);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}