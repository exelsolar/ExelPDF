using System.Configuration;

namespace Ecotiza.PDFBase.Infrastructure.Proxy
{
    public class ProxySettings
    {
        public static string ServerInsejupy()
        {
            return ConfigurationManager.AppSettings["ServerInsejupy"];
        }
        
    }
}
