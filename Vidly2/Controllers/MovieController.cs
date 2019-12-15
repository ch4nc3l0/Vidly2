using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name ="The Ring"},
                new Movie { Id = 2, Name="Shrek"},
                new Movie { Id = 3, Name="Breaking Bad"}
            };
        }
    }
}