using FluentValidation.Results;
using MovieAPI.Exceptions;

namespace MovieAPI.Extentions
{
    public static class ValidationExtensions
    {
        public static void HandleValidationResult(this ValidationResult result)
        {
            if (!result.IsValid)
            {
                throw new ValidationFailureException(result.Errors);
            }
        }
    }
}
