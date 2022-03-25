using FluentValidation;
using MovieAPI.Extentions;
using System;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }
        public bool Deleted { get; protected set; }
        public DateTime CreatedAt { get; protected set; } = DateTime.Now;
        public DateTime UpdatedAt { get; protected set; }

        protected abstract IValidator Validator { get; }

        public async Task ValidateEntity()
        {
            var validatorContext = new ValidationContext<BaseEntity>(this);
            var result = await Validator.ValidateAsync(validatorContext);
            result.HandleValidationResult();
        }

        protected void SetUpdatedAt()
        {
            UpdatedAt = DateTime.Now;
        }

        public void Delete()
        {
            Deleted = true;
        }
    }
}
