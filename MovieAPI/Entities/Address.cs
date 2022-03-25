using FluentValidation;
using MovieAPI.Models;
using MovieAPI.Validators;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieAPI.Entities
{
    public class Address : BaseEntity
    {
        public string Road { get; set; }
        public string District { get; set; }
        public int Number { get; set; }

        [NotMapped]
        protected override IValidator Validator => new AddressValidator();
        protected Address() : base() { }
    }
}
