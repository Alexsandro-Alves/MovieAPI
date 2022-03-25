using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Entities;
using MovieAPI.Models.MovieTheater;
using MovieAPI.Models.Request;
using MovieAPI.Models.Response;
using MovieAPI.Repositories;
using System;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieTheaterController : ControllerBase
    {
        private IMovieTheaterRepository _movieTheaterRepository;
        private IMapper _mapper;

        public MovieTheaterController(IMovieTheaterRepository movieTheaterRepository, IMapper mapper)
        {
            _movieTheaterRepository = movieTheaterRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddMovieTheater([FromBody] MovieTheaterRequestModel movieTheaterModel)
        {
            MovieTheater movieTheater = _mapper.Map<MovieTheater>(movieTheaterModel);

            _movieTheaterRepository.Create(movieTheater);
            _movieTheaterRepository.Save();
            return CreatedAtAction(nameof(GetMovieTheaterById), new { Id = movieTheater.Id }, movieTheater);
        }

        [HttpGet]
        public IActionResult GetAllMovieTheaters()
        {
            return Ok(_movieTheaterRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieTheaterById(Guid id)
        {
            var movieTheater = _movieTheaterRepository.GetById(id);
            if (movieTheater != null)
            {
                MovieTheaterResponseModel movieTheaterRequestModel = _mapper.Map<MovieTheaterResponseModel>(movieTheater);

                return Ok(movieTheaterRequestModel);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovieTheater(Guid id, [FromBody] UpdateMovieTheaterRequestModel movieTheaterModel)
        {
            var movieTheater = _movieTheaterRepository.GetById(id);
            if (movieTheater == null)
            {
                return NotFound();
            }

            _mapper.Map(movieTheaterModel, movieTheater);
            _movieTheaterRepository.Save();

            return NoContent();
        }
    }
}
