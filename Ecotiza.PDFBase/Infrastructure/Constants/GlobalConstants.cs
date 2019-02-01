namespace Ecotiza.PDFBase.Infrastructure.Constants
{
    public class GlobalConstants
    {
        public const string CryptographyKey = "Ecotiza.PDFBaseKey";

        public const bool Activated = true;
        public const bool Deactivated = false;

        public const int NumberOfDecimals = 2;

        public const int MaxNumberOfPartnersActivated = 4;

        public const int OrderNumberOfFirstCustomer = 1;

        public const int NotaryVocalsTypeMin = 8;

        public const string RegExpInteger = "^([+-]?[1-9]\\d*|0)$";

        public const string RegexAlphanumericAndNotWhiteSpace = @"^([a-zA-Z0-9]+)?\s*[a-zA-Z0-9á-úÁ-Ú]+[a-zA-Z0-9á-úÁ-Ú\s]*$";

        public const int MaximunDaysPerYear = 365;
        public const int MinimunDaysPerYear = 1;

        public static double MaxFileSizeInKb
        {
            get
            {
                int maxRequestLength = 0;
                System.Web.Configuration.HttpRuntimeSection section = System.Configuration.ConfigurationManager.GetSection("system.web/httpRuntime") as System.Web.Configuration.HttpRuntimeSection;
                if (section != null)
                    maxRequestLength = section.MaxRequestLength;

                return maxRequestLength;
            }
        }
    }
}