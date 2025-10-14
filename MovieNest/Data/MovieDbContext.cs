using Microsoft.EntityFrameworkCore;
using MovieNest.Models;

namespace MovieNest.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
                
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
