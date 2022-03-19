using AutoMapper;
using MovieAPI.Models;
using MovieAPI.Models.Response;

namespace MovieAPI.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieRequestModel, Movie>();
            CreateMap<Movie, MovieResponseModel>();
        }
    }
}
