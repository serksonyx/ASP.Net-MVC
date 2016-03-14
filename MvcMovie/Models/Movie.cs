using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Relese { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string IMDB { get; set; }
        public string Path { get; set; }
    }
    public class MovieDataBaseContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}