using Microsoft.EntityFrameworkCore;
using VideoRentalOnlineShopApp.Domain;
using VideoRentalOnlineShopApp.Domain.Enums;

namespace VideoRentalOnlineShopApp.DataAccess
{
    public class VideoRentalOnlineShopAppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public VideoRentalOnlineShopAppDbContext(DbContextOptions<VideoRentalOnlineShopAppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rental>()
                .HasOne(r => r.User)
                .WithMany(u => u.Rentals)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Rental>()
              .HasOne(r => r.Movie)
              .WithMany(m => m.Rentals)
              .HasForeignKey(r => r.MovieId);

            modelBuilder.Entity<Cast>()
                  .HasOne(c => c.Movie)
                  .WithMany(m => m.Casts)
                  .HasForeignKey(c => c.MovieId);

            modelBuilder.Entity<User>().HasData(
       new User
       {
           Id = 1,
           FullName = "John Smith",
           Age = 25,
           CardNumber = "1234567890123456",
           CreatedOn = new DateTime(2026, 1, 10),
           IsSubscriptionExpired = false,
           SubscriptionType = SubscriptionType.Premium
       },
       new User
       {
           Id = 2,
           FullName = "Maria Johnson",
           Age = 31,
           CardNumber = "9876543210987654",
           CreatedOn = new DateTime(2026, 2, 15),
           IsSubscriptionExpired = false,
           SubscriptionType = SubscriptionType.Basic
       },
       new User
       {
           Id = 3,
           FullName = "Alex Brown",
           Age = 18,
           CardNumber = "5555666677778888",
           CreatedOn = new DateTime(2026, 3, 20),
           IsSubscriptionExpired = true,
           SubscriptionType = SubscriptionType.Free
       }
   );


            modelBuilder.Entity<Movie>().HasData(
     new Movie
     {
         Id = 1,
         Title = "Inception",
         Genre = Genre.ScienceFiction,
         Language = Language.English,
         IsAvailable = true,
         ReleaseDate = new DateTime(2010, 7, 16),
         Length = new TimeSpan(2, 28, 0),
         AgeRestriction = 13,
         Quantity = 5
     },
     new Movie
     {
         Id = 2,
         Title = "The Dark Knight",
         Genre = Genre.Action,
         Language = Language.English,
         IsAvailable = true,
         ReleaseDate = new DateTime(2008, 7, 18),
         Length = new TimeSpan(2, 32, 0),
         AgeRestriction = 13,
         Quantity = 3
     },
     new Movie
     {
         Id = 3,
         Title = "Spirited Away",
         Genre = Genre.Animation,
         Language = Language.Japanese,
         IsAvailable = true,
         ReleaseDate = new DateTime(2001, 7, 20),
         Length = new TimeSpan(2, 5, 0),
         AgeRestriction = 7,
         Quantity = 4
     },
     new Movie
     {
         Id = 4,
         Title = "Interstellar",
         Genre = Genre.ScienceFiction,
         Language = Language.English,
         IsAvailable = true,
         ReleaseDate = new DateTime(2014, 11, 7),
         Length = new TimeSpan(2, 49, 0),
         AgeRestriction = 13,
         Quantity = 6
     },
     new Movie
     {
         Id = 5,
         Title = "The Matrix",
         Genre = Genre.ScienceFiction,
         Language = Language.English,
         IsAvailable = true,
         ReleaseDate = new DateTime(1999, 3, 31),
         Length = new TimeSpan(2, 16, 0),
         AgeRestriction = 16,
         Quantity = 2
     }
 );

            modelBuilder.Entity<Cast>().HasData(
                new Cast
                {
                    Id = 1,
                    Name = "Leonardo DiCaprio",
                    MovieId = 1,
                    Part = Part.Actor
                },
                new Cast
                {
                    Id = 2,
                    Name = "Christopher Nolan",
                    MovieId = 1,
                    Part = Part.Director
                },
                new Cast
                {
                    Id = 3,
                    Name = "Christian Bale",
                    MovieId = 2,
                    Part = Part.Actor
                },
                new Cast
                {
                    Id = 4,
                    Name = "Hayao Miyazaki",
                    MovieId = 3,
                    Part = Part.Director
                },
                new Cast
                {
                    Id = 5,
                    Name = "Matthew McConaughey",
                    MovieId = 4,
                    Part = Part.Actor
                },
                new Cast
                {
                    Id = 6,
                    Name = "Keanu Reeves",
                    MovieId = 5,
                    Part = Part.Actor
                }
            );


            modelBuilder.Entity<Rental>().HasData(
                new Rental
                {
                    Id = 1,
                    MovieId = 1,
                    UserId = 1,
                    RentedOn = new DateTime(2026, 7, 1),
                    ReturnedOn = new DateTime(2026, 7, 5)
                },
                new Rental
                {
                    Id = 2,
                    MovieId = 2,
                    UserId = 2,
                    RentedOn = new DateTime(2026, 7, 10),
                    ReturnedOn = new DateTime(2026, 7, 12)
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
