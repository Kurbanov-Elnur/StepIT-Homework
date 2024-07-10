using FilmAPI.Data.Models;
using Microsoft.Net.Http.Headers;

namespace FilmAPI.Services.Interfaces;

public interface IMovieService
{
    public Task<List<Movie>> GetMoviesByNameAsync (string name, int page);
    public Task<bool> AddMovieAsync (string title, string director,
     DateTime releaseDate, string genre, double rating);
}