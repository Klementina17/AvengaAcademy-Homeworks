using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using VideoRentalOnlineShopApp.Domain.Enums;
using VideoRentalOnlineShopApp.Services.Interfaces;

namespace VideoRentalOnlineShopApp.Controllers
{
    [Route("movies")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAllMovies(Genre? genre,string search)
        {
            var movies = _movieService.GetAllMovies();

            if (!string.IsNullOrEmpty(search))
            {
                movies = movies.Where(m => m.Title.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (genre.HasValue)
            {
                movies = movies.Where(m => m.Genre == genre.Value).ToList();
            }
            ViewBag.SelectedGenre = genre;
            ViewBag.SearchBy = search;

            return View(movies);
        }

        [HttpGet("id")]
        public IActionResult MovieDetails([FromQuery] int id)
        {
            var movie = _movieService.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            var movieDetailsVM = Mapper.OptionalMapper.MapToMovieDetailsVM(movie);
            return View(movieDetailsVM);
        }
    }
}
