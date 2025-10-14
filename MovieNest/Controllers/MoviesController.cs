using Microsoft.AspNetCore.Mvc;
using MovieNest.Models;
using MovieNest.Services.Interface;

namespace MovieNest.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: Movies/Index
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetAll();
            return View(movies);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieService.AddMovie(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            await _movieService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _movieService.GetById(id);
            return View(result);
         }

    }
}
