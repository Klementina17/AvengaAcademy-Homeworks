using Class08.Exercise1.Enums;
using Class08.Exercise1.Models;

// Exercise 1
Song song1 = new Song("Smells Like Teen Spirit", 301, Genre.Rock);
Song song2 = new Song("Lose Yourself", 326, Genre.Hip_Hop);
Song song3 = new Song("Numb", 185, Genre.Rock);
Song song4 = new Song("Sandstorm", 224, Genre.Techno);

// Exercise 2
Song song5 = new Song("Believer", 204, Genre.Rock);
Song song6 = new Song("Blinding Lights", 200, Genre.Pop);
Song song7 = new Song("Bohemian Rhapsody", 354, Genre.Rock);
Song song8 = new Song("Beat It", 258, Genre.Pop);
Song song9 = new Song("Bad Guy", 194, Genre.Pop);
Song song10 = new Song("Baby One More Time", 210, Genre.Pop);
Song song11 = new Song("Burn", 390, Genre.Techno);
Song song12 = new Song("Breathe", 420, Genre.Techno);

List<Song> allSongs = new List<Song>
{
    song1, song2, song3, song4,
    song5, song6, song7, song8,
    song9, song10, song11, song12
};

// Exercise 1
Person person1 = new Person(1, "Klementina", "Dimitrova", 26, Genre.Hip_Hop, new List<Song> { song2 });
Person person2 = new Person(2, "Kirila", "Dimitrova", 22, Genre.Rock, new List<Song> { song1, song3 });
Person person3 = new Person(3, "Adriana", "Tomovska", 34, Genre.Techno, new List<Song>
{
    song4, song11, song12, song7
});
Person person4 = new Person(4, "Tadej", "Markovski", 11, Genre.Classical, null);

// Exercise 2
Person jerry = new Person(5, "Jerry", "Smith", 30, Genre.Rock, new List<Song>
{
    song5, song7, song8, song9
});

Person maria = new Person(6, "Maria", "Johnson", 28, Genre.Pop, new List<Song>
{
    song11, song12, song7
});

Person jane = new Person(7, "Jane", "Brown", 35, Genre.Rock, new List<Song>
{
    song1, song3, song5, song7
});

Person stefan = new Person(8, "Stefan", "Petrov", 19, Genre.Hip_Hop, new List<Song>
{
    song2, song9
});

List<Person> persons = new List<Person>
{
    person1,
    person2,
    person3,
    person4,
    jerry,
    maria,
    jane,
    stefan
};

//Exercise 1
person1.GetFavSongs();
person2.GetFavSongs();
person3.GetFavSongs();
person4.GetFavSongs();

//Exercise 2
jerry.GetFavSongs();
maria.GetFavSongs();
jane.GetFavSongs();
stefan.GetFavSongs();


var personJerry = persons.FirstOrDefault(p => p.FirstName.ToLower() == "jerry");
var allSongsWhichStartsWithB = allSongs.Where(s => s.Title.StartsWith("B"));
personJerry.FavoriteSongs.AddRange(allSongsWhichStartsWithB);

var personMaria = persons.FirstOrDefault(p => p.FirstName.ToLower() == "maria");
var allSongsWithLengthLongThen360s = allSongs.Where(s => s.Length > 360);
personMaria.FavoriteSongs.AddRange(allSongsWithLengthLongThen360s);

var personJane = persons.FirstOrDefault(p => p.FirstName.ToLower() == "jane");
var allSongsOfGenreRock = allSongs.Where(s => s.Type == Genre.Pop);
personJane.FavoriteSongs.AddRange(allSongsOfGenreRock);

var personStefan = persons.FirstOrDefault(p => p.FirstName.ToLower() == "stefan");
var allSongsShorterThan3minAndOfGenreHipHop = allSongs.Where(s => s.Length < 180 && s.Type == Genre.Hip_Hop);
personStefan.FavoriteSongs.AddRange(allSongsShorterThan3minAndOfGenreHipHop);

var personsWithMoreThan4Songs = persons.Where(p => p.FavoriteSongs.Count>=4);
foreach(var person in personsWithMoreThan4Songs)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
    foreach(var song in allSongs)
    {
        Console.WriteLine($"Title:{song.Title}, Length:{song.Length}");
    }
}
  