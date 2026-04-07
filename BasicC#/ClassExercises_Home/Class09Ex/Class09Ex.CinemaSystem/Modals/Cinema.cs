using System.Runtime.InteropServices;

namespace Class09Ex.CinemaSystem.Modals;

public class Cinema
{
    public string Name { get; set; }
    public int Halls { get; set; }
    public List<Movie> ListOfMovies { get; set; }

    public Cinema(string name,int halls,List<Movie> movies)
    {
        Name = name;
        Halls = halls;
        ListOfMovies = movies ?? new List<Movie>();
    }

    public void MoviePlaying(string movieName)
    {
        var foundMovie = ListOfMovies.FirstOrDefault(m => m.Title.ToLower() == movieName.ToLower());
            Console.WriteLine($"Watching: {foundMovie.Title}");
    }

    public void ShowAllMovies()
    {
        foreach(var movie in ListOfMovies)
        {
            Console.WriteLine($"Title: {movie.Title} Type: {movie.Type} Rating:  {movie.Rating} TicketPrice: {movie.TicketPrice}");
        }
    }
}
