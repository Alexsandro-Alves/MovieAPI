using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Models.Response;
using MovieAPI.Repositories;
using System;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private IMovieRepository _movieRepository;
        private IMapper _mapper;

        public MovieController(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] MovieRequestModel movieModel)
        {
            Movie movie = _mapper.Map<Movie>(movieModel);

            _movieRepository.Create(movie);
            _movieRepository.Save();
            return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok(_movieRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(Guid id)
        {
            var movie = _movieRepository.GetById(id);
            if (movie != null)
            {
                MovieResponseModel movieRequestModel = _mapper.Map<MovieResponseModel>(movie);

                return Ok(movieRequestModel);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(Guid id, [FromBody] UpdateMovieRequestModel movieModel)
        {
            var movie = _movieRepository.GetById(id);

            if (movie == null)
            {
                return NotFound();
            }

            _mapper.Map(movieModel, movie);
            _movieRepository.Save();

            return NoContent();
        }
    }
}
