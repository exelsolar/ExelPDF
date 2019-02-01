using System.IO;
using Jil;

namespace Ecotiza.PDFBase.Infrastructure.Serializers
{
    public static class SerializerExtensions
    {
        public static T Deserialize<T>(this string value)
        {
            using (var input = new StringReader(value))
            {
                return JSON.DeserializeDynamic(input);
            }
        }

        public static object Serialize(this object @object)
        {
            return JSON.SerializeDynamic(@object);
        }
    }
}