using System.Web;
using Ecotiza.PDFBase.Infrastructure.Files.Enums;
using Ecotiza.PDFBase.Infrastructure.Strings;

namespace Ecotiza.PDFBase.Infrastructure.Files
{
    public static class FileExtensions
    {
        public static string UnknownIfIsNullOrEmpty(this string imagePath, EFileType eFileType, EFileContainer eFileContainer)
        {

            return imagePath.IsNullOrEmpty() 
                ? ServerDomainResolver.GetCurrentDomain() + "/Content/Images/System/Unknown" + eFileType + ".png" 
                : Resolver(imagePath, eFileContainer);
        }

        public static string Resolver(string filePath)
        {
            return HttpContext.Current.Server.MapPath(string.Concat("~", filePath));
        }

        public static string Resolver(string filePath, EFileContainer fileContainer)
        {
            var appPath = string.Format("{0}{1}{2}", ServerDomainResolver.GetCurrentDomain(), FileSettings.ContentFolder, fileContainer + "/" + filePath);
            return appPath;
        }

    }
}