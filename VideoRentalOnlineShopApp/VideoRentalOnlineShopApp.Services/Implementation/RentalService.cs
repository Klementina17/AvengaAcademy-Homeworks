using VideoRentalOnlineShopApp.DataAccess.Interfaces;
using VideoRentalOnlineShopApp.Domain;
using VideoRentalOnlineShopApp.Models.ViewModels;
using VideoRentalOnlineShopApp.Services.Interfaces;

namespace VideoRentalOnlineShopApp.Services.Implementation
{
    public class RentalService : IRentalService
    {
        private readonly IRepository<Rental> _rentalRepository;
        private readonly IRepository<Movie> _movieRepository;

        public RentalService(IRepository<Rental> rentalRepository, IRepository<Movie> movieRepository)
        {
            _rentalRepository = rentalRepository;
            _movieRepository = movieRepository;
        }

        public List<RentalVM> GetRentalMovies()
        {
            List<Rental> rentals = _rentalRepository.GetAll();

            var rentalsVM = new List<RentalVM>();

            foreach (var rental in rentals)
            {
                var rentalVM = Mapper.OptionalMapper.MapToRentalVM(rental);

                rentalsVM.Add(rentalVM);
            }

            return rentalsVM;
        }

        public (bool Success, string ErrorMessage) RentMovie(RentMovieVM rentMovieVM)
        {
            var movie = _movieRepository.GetById(rentMovieVM.MovieId);

            if(movie is null ||  movie.Quantity <= 0 || !movie.IsAvailable)
            {
                return (false, "This movie is no longer available.");
            }

            
            var alreadyRented = _rentalRepository.GetAll()
                .Any(r => r.MovieId == rentMovieVM.MovieId
                          && r.UserId == rentMovieVM.UserId
                          && r.ReturnedOn == null);

            if (alreadyRented)
            {
                return (false, "You already have this movie rented.");
            }

            movie.Quantity--;
            if (movie.Quantity == 0)
            {
                movie.IsAvailable = false;
            }
            _movieRepository.Update(movie);

            Rental rental = Mapper.OptionalMapper.MapToRental(rentMovieVM);
            _rentalRepository.Create(rental);
            return (true, null);

        }

        public bool ReturnMovie(int rentMovieId)
        {
            var rental = _rentalRepository.GetById(rentMovieId);

            if (rental is null || rental.ReturnedOn != null)
            {
                return false; 
            }
           
            return CompleteReturn(rental);

        }

        public bool ReturnMovieByMovieId(int movieId)
        {
            var rental = _rentalRepository.GetAll()
              .FirstOrDefault(r => r.MovieId == movieId && r.ReturnedOn == null);

            if (rental is null)
            {
                return false;
            }

            return CompleteReturn(rental);
        }

        private bool CompleteReturn(Rental rental)
        {
             rental.ReturnedOn = DateTime.Now;
            _rentalRepository.Update(rental);

            var movie = _movieRepository.GetById(rental.MovieId);

            if (movie != null)
            {
                movie.Quantity++;
                if (!movie.IsAvailable)
                {
                    movie.IsAvailable = true;
                }
                _movieRepository.Update(movie);
            }
            return true;
        }
    }
}
