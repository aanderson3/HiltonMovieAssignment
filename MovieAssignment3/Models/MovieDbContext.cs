using System;
using Microsoft.EntityFrameworkCore;

namespace MovieAssignment3.Models
{
    //create movie db context to start db setup
    public class MovieDbContext : DbContext
    {
        //constructor
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
            //just to drop in base options
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
