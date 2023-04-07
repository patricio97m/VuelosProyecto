using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie { Name = "Titanic" },
                new Movie { Name = "Toy Story" },
                new Movie { Name = "Viernes 13" },
                new Movie { Name = "El Padrino" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movies = movie,
            };
            return View(viewModel);
        }



        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        //movies 
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}/sortBy={1}", pageIndex, sortBy));

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]

        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }
    }
}