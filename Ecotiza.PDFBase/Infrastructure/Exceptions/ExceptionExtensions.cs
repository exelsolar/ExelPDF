using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Ecotiza.PDFBase.Infrastructure.Enums;
using Ecotiza.PDFBase.Infrastructure.Validators;

namespace Ecotiza.PDFBase.Infrastructure.Exceptions
{
    public static class ExceptionExtensions
    {
        public static void ThrowCustomException(HttpStatusCode httpStatusCode, ECodeValidator eCodeVAlidator, string message)
        {
            throw new HttpResponseException(new HttpResponseMessage
            {
                StatusCode = httpStatusCode,
                Content = new StringContent("{\"ErrorCode\": " + eCodeVAlidator.GetValue() + ",\"Message\": \"" + message + "\"}", Encoding.Default, "application/json")
            });
        }

    }
}