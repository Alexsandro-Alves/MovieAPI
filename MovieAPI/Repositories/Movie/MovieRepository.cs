using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
