namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Titol,
                new Movie
                {
                    Titol = "When Harry Met Sally",
                    DataEstrena = DateTime.Parse("1989-1-11"),
                    Genere = "Romantic Comedy",
                    Preu = 7.99M,
                    IMDB = 678,
                    Cartell = "Cartell",
                    Durada =5446
              
                },

                 new Movie
                 {
                     Titol = "Ghostbusters ",
                     DataEstrena = DateTime.Parse("1984-3-13"),
                     Genere = "Comedy",
                     Preu = 8.99M,
                     IMDB =5465,
                     Cartell = "Cartell",
                     Durada = 5446
                 },

                 new Movie
                 {
                     Titol = "Ghostbusters 2",
                     DataEstrena = DateTime.Parse("1986-2-23"),
                     Genere = "Comedy",
                     Preu = 9.99M,
                     IMDB = 546546,
                     Cartell = "Cartell",
                     Durada = 5446
                 },

               new Movie
               {
                   Titol = "Rio Bravo",
                   DataEstrena = DateTime.Parse("1959-4-15"),
                   Genere = "Western",
                   Preu = 3.99M,
                   IMDB=54654,
                   Cartell = "Cartell",
                   Durada = 5446
               }
           );

        }
    }
}
