using Microsoft.EntityFrameworkCore;
using FilmAPI.Data.Models;
using Microsoft.Extensions.Configuration;

namespace FilmAPI.Data.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var movie = modelBuilder.Entity<Movie>();

        movie
            .HasKey(m => m.ID);

        movie
            .Property(m => m.Director)
            .IsRequired();

        movie
            .Property(m => m.ReleaseDate)
            .IsRequired();

        movie
            .Property(m => m.Genre)
            .IsRequired();
    }
}