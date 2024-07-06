using Microsoft.EntityFrameworkCore;
using FilmAPI.Data.Models;

namespace FilmAPI.Data.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(builder.GetConnectionString("DefaultConnection"));
        }
    }

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