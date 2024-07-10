using FilmAPI.Data.Contexts;
using FilmAPI.Data.Models;
using FilmAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FilmAPI.Services.Classes;

public class MovieService : IMovieService
{
    private readonly AppDbContext _appDbContext;

    public MovieService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<List<Movie>> GetMoviesByNameAsync(string name, int page = 1)
    {
        try
        {
            var movies = await _appDbContext.Movies
                .Where(m => m.Title.Contains(name))
                .Skip((page - 1) * 10)
                .Take(10)
                .ToListAsync();

            return movies;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<bool> AddMovieAsync(string title, string director,
     DateTime releaseDate, string genre, double rating)
    {
        var newMovie = new Movie(title, director, releaseDate, genre, rating);

        try
        {
            _appDbContext.Movies.Add(newMovie);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}