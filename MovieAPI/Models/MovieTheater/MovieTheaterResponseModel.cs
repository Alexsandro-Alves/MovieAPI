using System;
using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models.Response
{
    public class MovieTheaterResponseModel
    {
        [Required(ErrorMessage = "É necessário informar o nome")]
        public string Name { get; set; }
        public DateTime ConsultationTime { get; set; }

    }
}
