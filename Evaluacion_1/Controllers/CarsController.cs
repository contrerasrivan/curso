using Evaluacion_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Evaluacion_1.Controllers
{
    [Route("Cars")]
    public class CarsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var cars = new CarsModels
            {
                MarcaAuto = "Toyota",
                ModeloAuto = "Hyrus",
                PrecioAuto = 30000
            };

            return View(cars);
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(CarsModels models)
        {
            return RedirectToAction("index");
        }
    }
}
