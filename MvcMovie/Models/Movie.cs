using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Release { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Imdb { get; set; }
        public string Path { get; set; }
        public string Comment { get; set; }
    }
    public class MovieDbContext : DbContext
    {
        public MovieDbContext()
            : base("MovieDbContext")
        {
        }


        public DbSet<Movie> Movies { get; set; }
    }
}