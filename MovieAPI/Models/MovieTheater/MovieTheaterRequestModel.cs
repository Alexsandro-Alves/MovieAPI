using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models.Request
{
    public class MovieTheaterRequestModel
    {
        [Required(ErrorMessage = "É necessário informar o nome")]
        public string Name { get; set; }
    }
}
