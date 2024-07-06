using FilmAPI.Data.Models;
using Microsoft.Net.Http.Headers;

namespace FilmAPI.Services.Interfaces;

public interface IMovieService
{
    public Task<List<Movie>> GetMoviesByNameAsync (string name);
    public Task<bool> AddMovieAsync (Movie movie);
}