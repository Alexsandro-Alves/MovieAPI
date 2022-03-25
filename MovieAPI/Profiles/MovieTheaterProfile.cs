using AutoMapper;
using MovieAPI.Entities;
using MovieAPI.Models.MovieTheater;
using MovieAPI.Models.Request;
using MovieAPI.Models.Response;

namespace MovieAPI.Profiles
{
    public class MovieTheaterProfile : Profile
    {
        public MovieTheaterProfile()
        {
            CreateMap<MovieTheaterRequestModel, MovieTheater>();
            CreateMap<MovieTheater, MovieTheaterResponseModel>();
            CreateMap<UpdateMovieTheaterRequestModel, MovieTheater>();
        }
    }
}
