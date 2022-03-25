using FluentValidation;
using MovieAPI.Models;

namespace MovieAPI.Validators
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(x => x.Title)
                   .NotEmpty().WithMessage("O titulo deve ser informado.")
                   .MaximumLength(5).WithMessage("O titulo deve conter no máximo 100 caracteres.");

            RuleFor(x => x.Director)
                .NotEmpty().WithMessage("O diretor deve ser informado.")
                .MaximumLength(100).WithMessage("O diretor deve conter no máximo 100 caracteres.");

            RuleFor(x => x.Genre)
                .NotEmpty().WithMessage("O gênero deve ser informado.")
                .MaximumLength(100).WithMessage("O gênero deve conter no máximo 100 caracteres.");

            RuleFor(x => x.Duration)
                .NotEmpty().WithMessage("a duração deve ser informada.");
        }
    }
}
