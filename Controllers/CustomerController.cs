using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customers/List
        public ActionResult List()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Juan Carlos" },
                new Customer { Id = 2, Name = "María Florencia" },
                new Customer { Id = 3, Name = "Juan Ignacio" },
                new Customer { Id = 4, Name = "Luis Alberto" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Customers = customers,
            };
            return View(viewModel);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Juan Carlos" },
                new Customer { Id = 2, Name = "María Florencia" },
                new Customer { Id = 3, Name = "Juan Ignacio" },
                new Customer { Id = 4, Name = "Luis Alberto" }
            };
            var customer = customers.FirstOrDefault(c => c.Id == id);
            return View(customer);
        }
    }
}
