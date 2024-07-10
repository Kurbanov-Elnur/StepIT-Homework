using System.Text.Json;
using FilmAPI.Data.Models;
using FilmAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FilmAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet("GetMovieByName")]
    public async Task<IActionResult> GetMovieByNameAsync(string name)
    {
        var movies = await _movieService.GetMoviesByNameAsync(name);

        if (movies != null)
        {
            return new JsonResult(movies, new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }

        return BadRequest("Something went wrong");
    }

    [HttpPost("AddMovie")]
    public async Task<IActionResult> AddMovieAsync([FromBody] Movie movie)
    {
        if(await _movieService.AddMovieAsync(movie.Title, movie.Director, movie.ReleaseDate, movie.Genre, movie.Rating))
        {
            return Ok();
        }
        else
        {
            return BadRequest("Something went wrong");
        }
    }
}