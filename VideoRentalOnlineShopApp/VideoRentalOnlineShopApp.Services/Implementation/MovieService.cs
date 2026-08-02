using VideoRentalOnlineShopApp.DataAccess.Interfaces;
using VideoRentalOnlineShopApp.Domain;
using VideoRentalOnlineShopApp.Models.ViewModels;
using VideoRentalOnlineShopApp.Services.Interfaces;

namespace VideoRentalOnlineShopApp.Services.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;

        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<MoviesVM> GetAllMovies()
        {
            List<Movie> movies = _movieRepository.GetAll();

            var moviesVM = new List<MoviesVM>();
             
            foreach(var movie in movies)
            {
                var movieVM = Mapper.OptionalMapper.MapToMoviesVM(movie);
                moviesVM.Add(movieVM);
            }
            return moviesVM;
        }

        public Movie GetMovieById(int id)
        {
            var movie = _movieRepository.GetById(id);
            return movie;
        }
    }
}
