using System.Linq;
using System.Net;
using FluentValidation;
using Ecotiza.PDFBase.Infrastructure.Exceptions;

namespace Ecotiza.PDFBase.Infrastructure.Validators
{
    public class BaseValidator<T> : AbstractValidator<T>
    {
        public void ValidateAndThrowException(T request, string ruleSet)
        {
            try
            {
                var errors = Validate(request).Errors.Concat(this.Validate(request, ruleSet: ruleSet).Errors).ToList();
                if (errors.Any())
                    throw new ValidationException(errors);
            }
            catch (ValidationException exception)
            {
                var message = string.Join(" ", exception.Errors.Select(error => error.ErrorMessage));
                ExceptionExtensions.ThrowCustomException(HttpStatusCode.BadRequest, ECodeValidator.DataAccess, message);
            }
        }

        public bool ValidateState(T request, string ruleSet)
        {
            try
            {
                 var IsValid = this.Validate(request, ruleSet: ruleSet);

                return IsValid.IsValid;
            }
            catch (ValidationException exception)
            {

                var message = string.Join(" ", exception.Errors.Select(error => error.ErrorMessage));
                ExceptionExtensions.ThrowCustomException(HttpStatusCode.BadRequest, ECodeValidator.DataAccess, message);
                return false;
            }
        }
    }
}