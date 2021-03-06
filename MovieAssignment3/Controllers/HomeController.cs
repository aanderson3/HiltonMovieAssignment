using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieAssignment3.Models;

namespace MovieAssignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //context property
        private MovieDbContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieDbContext contxt)
        {
            _logger = logger;
            context = contxt;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie oMovie)
        {
            if (ModelState.IsValid)
            {
                context.Movies.Add(oMovie);
                context.SaveChanges();

                return View("MovieList", context.Movies);
            }

            return View();
        }

        public IActionResult MovieList()
        {
            return View(context.Movies);
        }

        [HttpGet]
        public IActionResult EditMovie(int movieId)
        {
            Movie editMovie = context.Movies.Where(x => x.MovieId == movieId).FirstOrDefault();
            ViewBag.Movie = editMovie;
            return View(editMovie);
        }

        [HttpPost]
        public IActionResult EditMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {

                Movie editMovie = context.Movies.Where(x => x.MovieId == movie.MovieId).FirstOrDefault();
                editMovie.Title = movie.Title;
                editMovie.Category = movie.Category;
                editMovie.Year = movie.Year;
                editMovie.Director = movie.Director;
                editMovie.Rating = movie.Rating;
                editMovie.Edited = movie.Edited;
                editMovie.LentTo = movie.LentTo;
                editMovie.Notes = movie.Notes;

                //context.Movies.Update(editMovie);
                context.SaveChanges();
            }

            return View("MovieList", context.Movies);
        }

        public IActionResult DeleteMovie(int movieId)
        {
            Movie editMovie = context.Movies.Where(x => x.MovieId == movieId).FirstOrDefault();
            context.Movies.Remove(editMovie);
            context.SaveChanges();

            return View("MovieList", context.Movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
