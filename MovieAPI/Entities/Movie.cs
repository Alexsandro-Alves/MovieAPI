using FluentValidation;
using MovieAPI.Validators;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPI.Models
{
    public class Movie : BaseEntity
    {
        public string Title { get; protected set; }
        public string Director { get; protected set; }
        public string Genre { get; protected set; }
        public int Duration { get; protected set; }

        [NotMapped]
        protected override IValidator Validator => new MovieValidator();
        protected Movie() : base() { }

    }
}
