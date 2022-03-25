using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace MovieAPI.Exceptions
{

    [Serializable]
    public class ValidationFailureException : Exception
    {
        public ICollection<ValidationError> Errors { get; private set; } = new List<ValidationError>();

        public ValidationFailureException(List<ValidationFailure> validationFailures)
        {
            validationFailures.ForEach(error => Errors.Add(new ValidationError(error.PropertyName, error.ErrorMessage)));
        }

        [ExcludeFromCodeCoverage]
        protected ValidationFailureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
