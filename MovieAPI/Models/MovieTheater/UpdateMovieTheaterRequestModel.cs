using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models.MovieTheater
{
    public class UpdateMovieTheaterRequestModel
    {
        [Required(ErrorMessage = "É necessário informar o nome")]
        public string Name { get; set; }
    }
}
