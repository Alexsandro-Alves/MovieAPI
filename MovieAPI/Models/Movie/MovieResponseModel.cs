using System;
using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models.Response
{
    public class MovieResponseModel
    {
        [Required(ErrorMessage = "O titulo do filme deve ser informado")]
        public string Title { get; set; }
        [Required(ErrorMessage = "O diretor do filme deve ser informado")]
        public string Director { get; set; }
        [Required(ErrorMessage = "O genero do filme deve ser informado")]
        public string Genre { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duration { get; set; }
        public DateTime ConsultationTime { get; set; }
    }
}
