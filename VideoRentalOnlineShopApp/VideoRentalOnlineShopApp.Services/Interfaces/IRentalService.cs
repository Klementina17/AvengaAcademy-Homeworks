using VideoRentalOnlineShopApp.Models.ViewModels;

namespace VideoRentalOnlineShopApp.Services.Interfaces
{
    public interface IRentalService
    {
        List<RentalVM> GetRentalMovies();
        (bool Success,string ErrorMessage)RentMovie(RentMovieVM rentMovieVM);
        bool ReturnMovie(int rentMovieId);
        bool ReturnMovieByMovieId(int movieId);
    }
}
