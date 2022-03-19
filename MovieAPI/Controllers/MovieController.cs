using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Data;
using MovieAPI.Models;
using MovieAPI.Models.Response;
using System;
using System.Linq;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;
        private IMapper _mapper;

        public MovieController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddMovie([FromBody] MovieRequestModel movieModel)
        {
            Movie movie = _mapper.Map<Movie>(movieModel);

            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok(_context.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(Guid id)
        {
            var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie != null)
            {
                MovieResponseModel movieRequestModel = _mapper.Map<MovieResponseModel>(movie);

                return Ok(movieRequestModel);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(Guid id, [FromBody] MovieRequestModel movieModel)
        {
            var movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            _mapper.Map(movieModel, movie);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
