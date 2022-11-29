using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


/*OJO, CHECAR AL FINAL DEL MODULO EL PROCEDURA PARA INSERTAR DATOS, VIDEO 101*/

namespace ManejoPresupuesto.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        //no encontrado. NO SE por que se pone aqui, y no en el tiposcuentascontroller
        //la vista tambien esta en home
        public IActionResult noencontrado()
        {
            //sin parametro para que busque su vista correspondiente
            return View();
        }
    }
}