using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new MvcMovieContext(
                    serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look if movie exist in database
                if(context.Movie.Any())
                {
                    return; // if there is any movie it means db has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "GhostBusters 2",
                        ReleaseDate = DateTime.Parse("1985-2-3"),
                        Genre = "Comedy/Adventure",
                        Price = 45.99M
                    },
                    new Movie
                    {
                        Title = "Bad boys",
                        ReleaseDate = DateTime.Parse("1995-4-7"),
                        Genre = "Comedy/Adventure",
                        Price = 45.99M
                    },
                    new Movie
                    {
                        Title = "GhostBusters",
                        ReleaseDate = DateTime.Parse("1983-5-1"),
                        Genre = "Comedy/Adventure",
                        Price = 45.99M
                    },
                    new Movie
                    {
                        Title = "Twelve Monkeys",
                        ReleaseDate = DateTime.Parse("1995-2-3"),
                        Genre = "Sci-fi/Triller",
                        Price = 45.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
