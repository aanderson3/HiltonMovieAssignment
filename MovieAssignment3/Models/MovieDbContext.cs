using System;
using Microsoft.EntityFrameworkCore;

namespace MovieAssignment3.Models
{
    //create movie db context to start db setup
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
            public DbSet<Movie> movies { get; set; }
        }
    }
}
