using MovieAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Entities
{
    public class MovieTheater : BaseEntity
    {
        [Required(ErrorMessage = "É necessário informar o nome")]
        public string Name { get; set; }
    }
}
