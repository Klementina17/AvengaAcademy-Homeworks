using Class09Ex.CinemaSystem.Enums;

namespace Class09Ex.CinemaSystem.Modals;

public class Movie
{
    public string Title { get; set; }
    public Genre Type { get; set; }
    public int Rating { get; set; }
    public int TicketPrice { get; set; }

    public Movie(string title,Genre type,int rating)
    {
        Title = title;
        Type = type;
        Rating = rating;
        TicketPrice = rating > 0 && rating < 6 ? 5 * rating : throw new ArgumentOutOfRangeException("Enter number between 1-5.");
    }

}
