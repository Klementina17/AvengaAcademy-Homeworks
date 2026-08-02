using Microsoft.AspNetCore.Mvc;
using VideoRentalOnlineShopApp.Models.ViewModels;
using VideoRentalOnlineShopApp.Services.Interfaces;

namespace VideoRentalOnlineShopApp.Controllers
{
    [Route("rentals")]
    public class RentalController : Controller
    {
        private readonly IRentalService _rentalService;
        private readonly IMovieService _movieService;

        public RentalController(IRentalService rentalService, IMovieService movieService)
        {
            _rentalService = rentalService;
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetRentalMovies()
        {
            var rentalMovies = _rentalService.GetRentalMovies();
            return View(rentalMovies);
        }

        [HttpGet("rent/{id}", Name = "GetRentMovieForm")]
        public IActionResult RentMovie(int id)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId is null)
            {
                return RedirectToAction("Login", "Account");
            }

            var movie = _movieService.GetMovieById(id);
            if(movie is null)
            {
                return NotFound();
            }

            var rentMovieVM = new RentMovieVM()
            {
                MovieId = movie.Id,
                MovieName=movie.Title,
                UserId=userId.Value,
                UserName=HttpContext.Session.GetString("UserName")   
            };

            return View(rentMovieVM);
        }

        [HttpPost("rent", Name = "PostRentMovie")]
        public IActionResult RentMovie(RentMovieVM rentMovieVM)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId is null)
            {
                return RedirectToAction("Login", "Account");
            }

         
            rentMovieVM.UserId = userId.Value;
            rentMovieVM.UserName = HttpContext.Session.GetString("UserName");

            if (!ModelState.IsValid) return View(rentMovieVM);

            var (success, errorMessage) = _rentalService.RentMovie(rentMovieVM);
            if (!success)
            {
                ModelState.AddModelError("", errorMessage);
                return View(rentMovieVM);
            }
            return RedirectToAction(nameof(GetRentalMovies));
        }

        [HttpPost("return/{id}")]
        public IActionResult ReturnMovie(int id)
        {
            var success = _rentalService.ReturnMovie(id);
            if (!success)
            {
                TempData["Error"] = "This rental was not found or was already returned.";
            }

            return RedirectToAction(nameof(GetRentalMovies));
        }

        [HttpPost("return-by-movie/{movieId}")]
        public IActionResult ReturnMovieByMovieId(int movieId)
        {
            var success = _rentalService.ReturnMovieByMovieId(movieId);

            if (!success)
            {
                TempData["Error"] = "No active rental found for this movie.";
            }

            return RedirectToAction("GetAllMovies", "Movie");
        }
    }
}
