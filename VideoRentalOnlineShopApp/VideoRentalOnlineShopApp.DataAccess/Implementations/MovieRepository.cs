using Microsoft.EntityFrameworkCore;
using VideoRentalOnlineShopApp.DataAccess.Interfaces;
using VideoRentalOnlineShopApp.Domain;

namespace VideoRentalOnlineShopApp.DataAccess.Implementations
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly VideoRentalOnlineShopAppDbContext _context;

        public MovieRepository(VideoRentalOnlineShopAppDbContext contex)
        {
            _context = contex;
        }

        public List<Movie> GetAll()
        {
            var movies = _context.Movies.ToList();
            return movies;
        }

        public Movie GetById(int id)
        {
            var movie = _context.Movies.FirstOrDefault(m => m.Id == id);
            return movie;
        }

        public void Create(Movie entity)
        {
            _context.Movies.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Movie entity)
        {
            _context.Movies.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var movieToDelete = GetById(id);
            
            if(movieToDelete != null)
            {
                _context.Movies.Remove(movieToDelete);
                _context.SaveChanges();
            }
        }
    }
}
