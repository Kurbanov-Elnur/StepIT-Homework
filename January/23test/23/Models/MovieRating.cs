using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _23.Models;

class MovieRating
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required]
    public double KP { get; set; }

    [Required]
    public double IMDB { get; set; }

    [Required]
    public double TMDB { get; set; }

    public ICollection<Movie> Movies { get; set; }
}