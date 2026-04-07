
using Class09Ex.CinemaSystem.Enums;
using Class09Ex.CinemaSystem.Modals;

bool isRunning = true;
while (isRunning)
{
    try
    {
        List<Movie> moviesInCineplexSCM = new List<Movie>()
{
    new Movie("The Conjuring",Genre.Horror,5),
    new Movie("Titanic",Genre.Drama,5),
    new Movie("The Hangover",Genre.Comedy,4)
};
        List<Movie> moviesInMilenium = new List<Movie>()
{
    new Movie("The Matrix", Genre.SciFi, 3),
    new Movie("John Wick", Genre.Action, 3)
};
        List<Movie> moviesInCinemania = new List<Movie>()
{
    new Movie("The Conjuring",Genre.Horror,5),
    new Movie("Forrest Gump",Genre.Drama,5),
    new Movie("The Matrix", Genre.SciFi, 3),
    new Movie("Superbad", Genre.Comedy, 4)
};
        List<Cinema> allCinemas = new List<Cinema>()
{
    new Cinema("Cineplexx Skopje City Mall",10,moviesInCineplexSCM),
    new Cinema("Milenium",5,moviesInMilenium),
    new Cinema("Cinemania",7,moviesInCinemania)
};
        //---------------- SELECT CINEMA ----------------
        Console.WriteLine("Please choose a cinema: ");
        for (int i = 0; i < allCinemas.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {allCinemas[i].Name}");
        }

        int cinemaChoice;
        Cinema selectedCinema = null;
        try
        {
            cinemaChoice = Int32.Parse(Console.ReadLine());

            if (cinemaChoice < 1 || cinemaChoice > allCinemas.Count)
            {
                throw new ArgumentOutOfRangeException("Choices number of cinemas.");
            }
            selectedCinema = allCinemas[cinemaChoice - 1];
        }
        catch (ArgumentOutOfRangeException aRe)
        {
            Console.WriteLine($"{aRe.Message}");
            continue;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error:  {ex.Message}");
            continue;
        }
        // ----------- Select option ----------
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1) Show all movies");
        Console.WriteLine("2) Show movies by genre");

        int option;
        try
        {
            option = Int32.Parse(Console.ReadLine());
            if (option < 1 || option > 2)
            {
                throw new ArgumentOutOfRangeException("Option must be 1 or 2.");
            }
        }
        catch (ArgumentOutOfRangeException aRx)
        {
            Console.WriteLine($"{aRx.Message}");
            continue;
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Please enter a valid number!");
            continue;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error:  {ex.Message}");
            continue;
        }
        // ----- Action -----
        if (option == 1)
        {
            selectedCinema.ShowAllMovies();
            Console.WriteLine("Choose which movie do you want to watch? ");
            for (int i = 0; i < selectedCinema.ListOfMovies.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {selectedCinema.ListOfMovies[i].Title}");
            }
            try
            {
                int choosenMovieToWatch = Int32.Parse(Console.ReadLine());
                if (choosenMovieToWatch < 1 || choosenMovieToWatch > selectedCinema.ListOfMovies.Count)
                {
                    throw new ArgumentOutOfRangeException("Invalid movie choice.");
                }
                string movieName = selectedCinema.ListOfMovies[choosenMovieToWatch - 1].Title;
                selectedCinema.MoviePlaying(movieName);
            }
            catch (ArgumentOutOfRangeException aRe)
            {
                Console.WriteLine($"{aRe.Message}");
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error:  {ex.Message}");
                continue;
            }
        }
        else
        {
            Console.WriteLine("Enter favorite genre (Horror, Drama, Comedy, Action, SciFi):");
            Genre genre;
            try
            {
                string inputGenre = Console.ReadLine();
                genre = (Genre)Enum.Parse(typeof(Genre), inputGenre, true);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Invalid genre.");
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error:  {ex.Message}");
                continue;
            }

            var filteredMoviesByGenre = selectedCinema.ListOfMovies.Where(m => m.Type == genre).ToList();
            if (filteredMoviesByGenre.Any())
            {
                Console.WriteLine("Choose a movie:");

                for (int i = 0; i < filteredMoviesByGenre.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {filteredMoviesByGenre[i].Title}");
                }

                try
                {
                    int chosenMovie = Int32.Parse(Console.ReadLine());

                    if (chosenMovie < 1 || chosenMovie > filteredMoviesByGenre.Count)
                        throw new ArgumentOutOfRangeException("Invalid movie choice.");

                    string movieName = filteredMoviesByGenre[chosenMovie - 1].Title;

                    selectedCinema.MoviePlaying(movieName);
                }
                catch (ArgumentOutOfRangeException aRe)
                {
                    Console.WriteLine($"{aRe.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error:  {ex.Message}");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("No movies found.");
            }
        }
    }
    catch (ArgumentOutOfRangeException AofrE)
    {
        Console.WriteLine($"{AofrE.Message}");
        continue;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error:  {ex.Message}");
        continue;
    }

    Console.WriteLine("Do you want to continue? (y/n)");
    string answer = Console.ReadLine().ToLower();

    if (answer == "n")
    {
        isRunning = false;
        Console.WriteLine("Goodbye! See u again!");
    }
}





