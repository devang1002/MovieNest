using MovieNest.Models;

namespace MovieNest.Services.Interface
{
    public interface IMovieService
    {
        Task<Movie> AddMovie (Movie movie);
        Task<bool> Delete(Guid id);
        Task<Movie> GetById(Guid id);
        Task<List<Movie>> GetAll();
    }
}
