namespace Ecotiza.PDFBase.Infrastructure.Validators
{
    public interface IValidator<in T>
    {
        void ValidateAndThrowException(T request, string ruleSet);
        bool ValidateState(T request, string ruleSet);
    }
}