using _23.Models;
using _23.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Services.Classes;

class DBEntryService : IDBEntryService
{
    public List<Movie> ToMovies(Docs[] movies)
    {
        List<Movie> result = new();

        foreach (var item in movies)
        {
            try
            {
                Movie movie = new Movie();

                movie.Rating = ToRating(item);

                movie.Name = item.name;
                movie.Descriiption = item.description;
                movie.Year = item.year;

                result.Add(movie);
            }
            catch (Exception ex) { }
        }

        return result;
    }

    private MovieRating ToRating(Docs movie)
    {
        MovieRating rating = new();
        double[] data = new double[3];

        if (double.TryParse(movie.rating.kp.ToString(), out data[0]) && data[0] != 0)
            rating.KP = data[0];

        if (double.TryParse(movie.rating.imdb.ToString(), out data[1]) && data[1] != 0)
            rating.IMDB = data[1];

        if (double.TryParse(movie.rating.tmdb.ToString(), out data[2]) && data[2] != 0)
            rating.TMDB = data[2];

        if (data[0] == 0 && data[1] == 0 && data[2] == 0)
            throw new ArgumentException("Movie is not found");

        return rating;
    }
}