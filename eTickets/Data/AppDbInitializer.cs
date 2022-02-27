using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder ApplicationBuilder)
        {
            using(var serviceScope = ApplicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                        {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the second cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the third cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the foure cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the five cinema"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                        {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio   = "This is the bio of the first actor"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-2.jpeg",
                            Bio = "This is the bio of the second actor"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg",
                            Bio = "This is the bio of the third actor"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-4.jpeg",
                            Bio = "This is the bio of the foure actor"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            ProfilePictureURL = "https://dotnethow.net/images/actors/actor-5.jpeg",
                            Bio = "This is the bio of the five actor"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                        {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio   = "This is the bio of the first actor"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio = "This is the bio of the second actor"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio = "This is the bio of the third actor"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio = "This is the bio of the foure actor"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            ProfilePictureURL = "https://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio = "This is the bio of the five actor"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie
                        {
                            Name = "The Shawshank Redemption",
                            Description="This is The Shawshank Redemption movie description",
                            Price = 29.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ActorId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie
                        {
                            Name = "Lite",
                            Description="This is the Lite movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ActorId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie
                        {
                            Name = "Scoob",
                            Description="This is the scoob movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ActorId = 1,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie
                        {
                            Name = "Ghost",
                            Description="This is the scoob movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 4,
                            ActorId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie
                        {
                            Name = "Scoob",
                            Description="This is the scoob movie description",
                            Price = 39.50,
                            ImageURL = "https://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ActorId = 1,
                            MovieCategory = MovieCategory.Documentary
                        }
                    });
                    context.SaveChanges();

                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            actorId=1,
                            movieId=3
                        },
                        new Actor_Movie()
                        {
                            actorId=2,
                            movieId=3
                        },
                        new Actor_Movie()
                        {
                            actorId=5,
                            movieId=3
                        },
                        new Actor_Movie()
                        {
                            actorId=2,
                            movieId=4
                        },
                        new Actor_Movie()
                        {
                            actorId=4,
                            movieId=5
                        },
                        new Actor_Movie()
                        {
                            actorId=1,
                            movieId=5
                        },
                        new Actor_Movie()
                        {
                            actorId=3,
                            movieId=1
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
