using Microsoft.EntityFrameworkCore;
using MovieAPI.Entities;
using MovieAPI.Models;

namespace MovieAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieTheater> MovieTheaters { get; set; }
        public DbSet<Address> Adresses { get; set; }
    }
}
