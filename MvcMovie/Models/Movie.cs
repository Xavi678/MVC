using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MvcMovie.Models
    
{
    public class Movie
    {
        public int ID { get; set; }
        public string Titol { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataEstrena { get; set; }
        public string Genere { get; set; }
        public decimal Preu { get; set; }
        public int IMDB { get; set; }
        public string Cartell { get; set;}
        public int Durada { get; set;  }
        public string Sinopsi { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}