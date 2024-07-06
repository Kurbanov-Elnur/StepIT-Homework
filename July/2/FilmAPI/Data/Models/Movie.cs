namespace FilmAPI.Data.Models;

public class Movie
{
    public string ID { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } 
    public string Director { get; set; } 
    public DateTime ReleaseDate { get; set; } 
    public string Genre { get; set; }
    public double Rating { get; set; } 
}