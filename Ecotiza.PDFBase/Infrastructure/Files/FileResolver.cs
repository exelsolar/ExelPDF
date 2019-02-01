using System.Web;
using Ecotiza.PDFBase.Infrastructure.Files.Interfaces;

namespace Ecotiza.PDFBase.Infrastructure.Files
{
    public class FileResolver : IFileResolver
    {
        public string Resolve(string filePath)
        {
            return HttpContext.Current.Server.MapPath(string.Concat("~/", filePath));
        }
    }
}