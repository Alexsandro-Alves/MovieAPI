using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieAPI.Models;

namespace MovieAPI.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");

            builder.Property(x => x.Title)
                .IsRequired(true)
                .HasMaxLength(5);

            builder.Property(x => x.Director)
                .IsRequired(false)
                .HasMaxLength(100);

            builder.Property(x => x.Genre)
                .IsRequired(false)
                .HasMaxLength(100);
        }
    }
}
