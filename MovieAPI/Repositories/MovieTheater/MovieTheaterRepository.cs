using MovieAPI.Data;
using MovieAPI.Entities;

namespace MovieAPI.Repositories
{
    public class MovieTheaterRepository : GenericRepository<MovieTheater>, IMovieTheaterRepository
    {
        public MovieTheaterRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
