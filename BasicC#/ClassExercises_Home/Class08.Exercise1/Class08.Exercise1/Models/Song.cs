using Class08.Exercise1.Enums;

namespace Class08.Exercise1.Models;
public class Song
{
    public string Title { get; set; }
    public int Length { get; set; }
    public Genre Type { get; set; }

    public Song(string title,int length,Genre type)
    {
        Title = title;
        Length = length;
        Type = type;
    }

}
