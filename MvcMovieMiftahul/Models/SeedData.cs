using Microsoft.EntityFrameworkCore;
using MvcMovieMiftahul.Data;

namespace MvcMovieMiftahul.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieMiftahulContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieMiftahulContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        RelaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.9M

                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        RelaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M

                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        RelaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M

                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        RelaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M

                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
