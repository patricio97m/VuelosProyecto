using System.Linq;
using System.Net;
using System.Web.Mvc;
using Vuelos.Models;
using Vuelos.ViewModels;

namespace Vuelos.Controllers
{
    public class VueloController : Controller
    {
        private MyDBContext _context;

        public VueloController()
        {
            _context = new MyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers/
        public ActionResult Index()
        {
            var vuelos = _context.Vuelo.ToList();
            return View(vuelos);
        }

        public ActionResult New()
        {
            var ViewModel = new VueloFormViewModel
            {
                Vuelo = new Vuelo(),
            };
            return View("VuelosForm", ViewModel);
        }

        public ActionResult Delete()
        {
            var viewModel = new VueloFormViewModel
            {
                Vuelo = new Vuelo(),
                Vuelos = _context.Vuelo.ToList()
            };
            return View("Delete", viewModel);
        }

        [HttpPost]
        public ActionResult Delete(VueloFormViewModel viewModel)
        {
            if (viewModel.Vuelo.Id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var vuelo = _context.Vuelo.FirstOrDefault(v => v.Id == viewModel.Vuelo.Id);

            if (vuelo == null)
            {
                return HttpNotFound();
            }

            _context.Vuelo.Remove(vuelo);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Vuelo vuelo)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new VueloFormViewModel
                {
                    Vuelo = vuelo,
                };
                return View("VuelosForm", viewModel);
            }
            if (vuelo.Id == 0)
            {
                _context.Vuelo.Add(vuelo);
            }
            else
            {
                var vueloInDb = _context.Vuelo.Single(c => c.Id == vuelo.Id);
                vueloInDb.Nombre = vuelo.Nombre;
                vueloInDb.HorarioDeLLegada = vuelo.HorarioDeLLegada;
                vueloInDb.LineaAerea = vuelo.LineaAerea;
                vueloInDb.Demorado = vuelo.Demorado;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Vuelo");
        }

        public ActionResult Edit(int id)
        {
            var vuelo = _context.Vuelo.SingleOrDefault(c => c.Id == id);
            if (vuelo == null)
            {
                return HttpNotFound();
            }

            var ViewModel = new VueloFormViewModel()
            {
                Vuelo = vuelo,
            };
            return View("VuelosForm", ViewModel);
        }
    }


}
