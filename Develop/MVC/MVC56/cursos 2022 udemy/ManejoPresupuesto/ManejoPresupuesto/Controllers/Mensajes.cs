using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Controllers
{
    public class Mensajes:Controller
    {
        /*se utiliza para hacer pruebas basicas con el controlador.pg. mandar un hola mundo en el que solo se requiera un controlador.
         el procedimiento se ejecuta con: ...  /mensajes/mensaje?strquien=soy%20adan*/

        public IActionResult mensaje(string strQuien)
        {
            return Content("hola mundo, utilizando solo un controlador !!!!!!" + " " + strQuien);
        }

        public IActionResult msg()
        {
            return View();
        }
    }
}
