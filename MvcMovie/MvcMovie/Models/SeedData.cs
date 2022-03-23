
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Dbde film var mı bak yoksa çalıştır
                if (context.Movie.Any())
                {
                    return;  
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Batman Begins",
                        ReleaseDate = DateTime.Parse("2005-6-16"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 34.95M
                    },

                    new Movie
                    {
                        Title = "The Dark Knight ",
                        ReleaseDate = DateTime.Parse("2008-6-24"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 38.99M
                    },

                    new Movie
                    {
                        Title = "Inception",
                        ReleaseDate = DateTime.Parse("2010-6-16"),
                        Genre = "Sci-Fi",
                        Rating = "R",
                        Price = 19.99M
                    },

                    new Movie
                    {
                        Title = "The Goonies",
                        ReleaseDate = DateTime.Parse("1985-11-29"),
                        Genre = "Family",
                        Rating = "E",
                        Price = 3.99M
                    },

                    new Movie
                    {
                        Title = "WALL-E",
                        ReleaseDate = DateTime.Parse("2008-7-18"),
                        Genre = "Animation",
                        Rating = "E",
                        Price = 13.99M
                    },

                    new Movie
                    {
                        Title = "Goodfellas",
                        ReleaseDate = DateTime.Parse("1990-10-26"),
                        Genre = "Crime",
                        Rating = "R",
                        Price = 19.99M
                    }

                );
                context.SaveChanges();
            }
        }
    }
}