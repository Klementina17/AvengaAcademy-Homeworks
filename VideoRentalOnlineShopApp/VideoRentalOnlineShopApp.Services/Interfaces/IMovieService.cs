using VideoRentalOnlineShopApp.Domain;
using VideoRentalOnlineShopApp.Models.ViewModels;

namespace VideoRentalOnlineShopApp.Services.Interfaces
{
    public interface IMovieService
    {
        List<MoviesVM> GetAllMovies();
        Movie GetMovieById(int id);

    }
}
