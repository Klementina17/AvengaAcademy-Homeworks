using Class08.Exercise1.Enums;
using System.Runtime.CompilerServices;

namespace Class08.Exercise1.Models;
public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Genre FavoriteMusicType { get; set; }
    public List<Song> FavoriteSongs { get; set; }

    public Person()
    {
        
    }
    public Person(int id,string fName,string lName,int age,Genre favMusicType,List<Song> favSongs)
    {
        Id = id;
        FirstName = fName;
        LastName = lName;
        Age = age;
        FavoriteMusicType = favMusicType;
        FavoriteSongs = favSongs ?? new List<Song>();
    }

    public void GetFavSongs()
    {
       if(!(FavoriteSongs.Count == 0))
        {
            Console.WriteLine($"{FirstName} {LastName} - Favorite Songs: ");
            foreach (var song in FavoriteSongs)
            {
                Console.WriteLine(song.Title);
            }
        }
        else
        {
            Console.WriteLine($"{FirstName} {LastName} hates music!");
        }
    }

}
