using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using ramos.Models;
using ramos.ViewModels;


namespace ramos.Controllers
{
    public class MoviesController : Controller
    {
        private List<Customer> customer;

        // GET: Random
        public ActionResult Random()

        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(ViewModel);

        }

        //attribute route
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }



    }
}