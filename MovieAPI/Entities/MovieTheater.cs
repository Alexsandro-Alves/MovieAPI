using FluentValidation;
using MovieAPI.Models;
using MovieAPI.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPI.Entities
{
    public class MovieTheater : BaseEntity
    {
        [Required(ErrorMessage = "É necessário informar o nome")]
        public string Name { get; set; }

        [NotMapped]
        protected override IValidator Validator => new MovieTheaterValidator();
        protected MovieTheater() : base() { }
    }
}
