using Microsoft.EntityFrameworkCore;
using VideoRentalOnlineShopApp.DataAccess.Interfaces;
using VideoRentalOnlineShopApp.Domain;

namespace VideoRentalOnlineShopApp.DataAccess.Implementations
{
    public class RentalRepository : IRepository<Rental>
    {
        private readonly VideoRentalOnlineShopAppDbContext _context;

        public RentalRepository(VideoRentalOnlineShopAppDbContext context)
        {
            _context = context;
        }
        public List<Rental> GetAll()
        {
            var rentals = _context.Rentals
            .Include(r => r.Movie)
            .Include(r => r.User)
            .ToList();
            return rentals;
        }

        public Rental GetById(int id)
        {
            var rental = _context.Rentals
                 .Include(r => r.Movie)
                  .Include(r => r.User)
                  .FirstOrDefault(r => r.Id == id);
            return rental;
        }

        public void Create(Rental entity)
        {
            _context.Rentals.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Rental entity)
        {
            _context.Rentals.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var rentalToDelete = GetById(id);
            if (rentalToDelete != null)
            {
                _context.Rentals.Remove(rentalToDelete);
                _context.SaveChanges();
            }
           
        }
    }
}
