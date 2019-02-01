using System.Configuration;

namespace Ecotiza.PDFBase.Infrastructure.Files.ElementConfigs
{
    public class HexInstanceCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new HexInstanceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((HexInstanceElement)element).Hex;
        }
    }
}