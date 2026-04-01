using Class08.Exercise1.Enums;
using Class08.Exercise1.Models;

Song song1 = new Song("Smells Like Teen Spirit", 301, Genre.Rock);
Song song2 = new Song("Lose Yourself", 326, Genre.Hip_Hop);
Song song3 = new Song("Numb", 185, Genre.Rock);
Song song4 = new Song("Sandstorm", 224, Genre.Techno);

List<Song> favSongs = new List<Song>
{
    song1,
    song2,
    song3,
    song4
};

Person person1 = new Person(1, "Klementina", "Dimitrova", 26, Genre.Hip_Hop, new List<Song>{song2});
Person person2 = new Person(2, "Kirila", "Dimitrova", 22, Genre.Rock, new List<Song> { song1, song3 });
Person person3=new Person(3, "Adriana", "Tomovska", 34, Genre.Techno, favSongs);
Person person4 = new Person(4, "Tadej", "Markovski", 11, Genre.Classical, null);

person1.GetFavSongs();
person2.GetFavSongs();
person3.GetFavSongs();
person4.GetFavSongs();
