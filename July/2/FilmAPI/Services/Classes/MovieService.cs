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

    public async Task<List<Movie>> GetMoviesByNameAsync(string name)
    {
        try
        {
            var movies = await _appDbContext.Movies
                .Where(m => m.Title == name)
                .ToListAsync();

            return movies;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<bool> AddMovieAsync(Movie movie)
    {
        try
        {
            _appDbContext.Movies.Add(movie);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}