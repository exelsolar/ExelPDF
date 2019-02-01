using System.Web;
using Ecotiza.PDFBase.Infrastructure.Objects;

namespace Ecotiza.PDFBase.Infrastructure.Files
{
    public static class ServerDomainResolver
    {
        public static string GetCurrentDomain()
        {
            var appPath = string.Empty;
            var context = HttpContext.Current;
            var applicationPath = context.Request.ApplicationPath == "/" ? string.Empty : context.Request.ApplicationPath;
            if (context.IsNotNull())
            {
                appPath = string.Format("{0}://{1}{2}{3}",
                    context.Request.Url.Scheme,
                    context.Request.Url.Host,
                    context.Request.Url.Port == 80 ? string.Empty : ":" + context.Request.Url.Port, applicationPath);
            }

            return appPath;
        }

        public static string GetCurrentDomainHttp()
        {
            var appPath = string.Empty;
            var context = HttpContext.Current;
            var applicationPath = context.Request.ApplicationPath == "/" ? string.Empty : context.Request.ApplicationPath;
            if (context.IsNotNull())
            {
                appPath = string.Format("{0}://{1}{2}{3}",
                    System.Uri.UriSchemeHttp,
                    context.Request.Url.Host,
                    context.Request.Url.Port == 80 || context.Request.Url.Port == 443 ? string.Empty : ":" + context.Request.Url.Port, applicationPath);
            }

            return appPath;
        }
    }
}