using System;
using System.Linq;

namespace Ecotiza.PDFBase.Infrastructure.Validators
{
    public static class Validate<T>
    {
        public static bool Property(string property)
        {
            string propertyName = property;
            var myType = typeof(T);
            if (property.Contains("."))
            {
                // nested object
                var properties = property.Split('.');
                var propertyInfo = myType.GetProperty(properties[0]);
                if (propertyInfo == null)
                    return false;
                foreach (var propertyNameInner in properties.Skip(1))
                {
                    myType = Type.GetType((propertyInfo.PropertyType).AssemblyQualifiedName);
                    if (myType == null)
                        return false;
                    propertyName = propertyNameInner;
                }
            }
            return myType.GetProperties().Any(prop => prop.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));
        }
    }
}