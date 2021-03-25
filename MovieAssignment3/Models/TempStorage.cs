using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAssignment3.Models
{
    public static class TempStorage
    {
        private static List<Movie> moviesList = new List<Movie>();

        public static IEnumerable<Movie> Movies => moviesList;

        public static void NewMovie(Movie oMovie)
        {
            moviesList.Add(oMovie);
        }
    }
}
