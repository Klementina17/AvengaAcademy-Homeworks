using VideoRentalOnlineShopApp.Domain;
using VideoRentalOnlineShopApp.Models.ViewModels;

namespace VideoRentalOnlineShopApp.Mapper
{
    public static class OptionalMapper
    {

      public static MoviesVM MapToMoviesVM(Movie movie)
        {
            return new MoviesVM
            {
                Id=movie.Id,
                Title=movie.Title,
                Genre=movie.Genre,
                Language=movie.Language,
                IsAvailable=movie.IsAvailable,
                Length=movie.Length,
            };
        }

      public static MovieDetailsVM MapToMovieDetailsVM(Movie movie)
        {
            return new MovieDetailsVM
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre,
                Language = movie.Language,
                IsAvailable = movie.IsAvailable,
                Length = movie.Length,
                AgeRestriction=movie.AgeRestriction,
                ReleaseDate=movie.ReleaseDate,
                Quantity=movie.Quantity
            };
        }

      public static RentalVM MapToRentalVM(Rental rental)
        {
            return new RentalVM
            {
                Id = rental.Id,
                RentedOn = rental.RentedOn,
                ReturnedOn = rental.ReturnedOn,
                UserName = rental.User.FullName,
                MovieName =rental.Movie.Title,
                MovieId=rental.MovieId,
                UserId=rental.UserId
                
                
            };
        }

       public static Rental MapToRental (RentMovieVM rentMovieVM)
        {
            return new Rental
            {
                MovieId = rentMovieVM.MovieId,
                UserId = rentMovieVM.UserId,
                RentedOn = DateTime.Now,
                ReturnedOn = null
            };
        }

       
    }
}
