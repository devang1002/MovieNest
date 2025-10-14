using Microsoft.EntityFrameworkCore;
using MovieNest.Data;
using MovieNest.Models;
using MovieNest.Services.Interface;

namespace MovieNest.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieDbContext _movieDbContext;
        public MovieService(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public async Task<Movie> AddMovie(Movie movie)
        {
            var result = _movieDbContext.Movies.AddAsync(movie);
            await _movieDbContext.SaveChangesAsync();
            return result.Result.Entity;
        }

        public async Task<bool> Delete(Guid id)
        {
            var result = await _movieDbContext.Movies.FindAsync(id);
            if (result != null)
            {
                _movieDbContext.Movies.Remove(result);
                await _movieDbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Movie>> GetAll()
        {
            return await _movieDbContext.Movies.ToListAsync();
        }

        public async Task<Movie> GetById(Guid id)
        {
            return await _movieDbContext.Movies.FirstOrDefaultAsync(x=> x.Id == id);
        }
    }
}
