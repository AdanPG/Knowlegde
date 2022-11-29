using _2Portafolio.Models;
using _2Portafolio.servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2Portafolio.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Ilogger es una interface, es tambien una dependencia inyectada. Es un servicio preconfigurado que sirve para mostrar mensajes en logs
         * y mandarlos a un lugar especifico, consola, bd, archivo, etc. lo bueno es que hay categorias de mensajes, lo cual ayuda para poder 
         * administrar los estados de la aplicacion. esto se configura en appsettings.json, se muestran los tipos que estan de defaul, hacia ariba
         * ...warning, fail, critical. pg.
         * 
         */


        /*PROVEEDORES DE CONFIGURACION
         va en appsettings.json o appsettings.devepment.json, este ultimo tiene prioridad porque es la version de desarrollo, la otra es la de produccion.
        aqui se guardan las variables de entorno, conexiones, secrets, proveedores de configuracion, etc. a estos ultimos se accesa a travez de 
        iconfiguration
         
         
         */
        private readonly ILogger<HomeController> _logger;
        private readonly claRepositorio claRep;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, claRepositorio claRep, IConfiguration configuration)
        {
            _logger = logger;
            this.claRep = claRep;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {

            //utilizo iconfiguration para accesar al prov de conf
            var ape = configuration.GetValue<string>("apellido");

            //logs van como mensajes a la consola
            _logger.LogInformation("mensaje de log information");
            _logger.LogDebug ("mensaje de log critical" + ape);

            //var rp = new claRepositorio();
            var jobs = claRep.ObtenerJobs().Take(3).ToList();
            var mod= new HomeIndexVM() { Jobs = jobs };


            return View(mod);
        }



        /*
         * si se observa, el siguiente codigo es la data o una parte de la data, lo cual no es correcto porque el controlador debe servir basicamente
         * para proporcionar vistas, no para implementar data. OSEA incumple con la regla de responsabilidad unica. lo cual no es lo ACONSEJABLE
         * 
         * se resuelve creando una clase repositorio en una carpeta llamada servicios. los repositorios normalmente son utilizados para conectarse a 
         * las bases de datos y gestionar esos servicios
         * 
         * segmentar hacia una clase reppsitorio es recomendable, pero aun no esta completa la tarea de la responsabilidad
         * unica, pues aun existe la instanciacion var rp = new claRepositorio(); la idea es que no se debe instanciar desde cualquier lugar, en eso
         * se fundamenta una parte del modelo SOLID y se logra a traves de la tecnica de INYECCION de dependencias
         * 
         * inyeccion de dependencias esencialmente significa que cuando se instancia un objeto, implicitamente estamos obligados a instancias las 
         * clases que dependen de ese objeto, lo cual puede volver complejo el codigo. lo anterior se logra modificando la clase Program.cs, en la 
         * parte de program.services
         * 
         * la siguiente mejora es implementar una interface con la cual se obtendra flexibilidad, a este metodo se le llama inversion de dependencias,
         * en el cual las clases no dependen de otras clases, sino de tipos abstractos como lo son las interfaces ???.
         */


        public IActionResult ViewAllJobs()
        {
            /*toma el valor del procedimiento para llamar a la vista, pasando jobs como argumento*/
            var jobs = claRep.ObtenerJobs().ToList();
            return View(jobs);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Contacto()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Contacto(claContacto claC)
        {
            /*para que no mande cada vez que se actualice*/
            return RedirectToAction("viewGracias");
        }

        public IActionResult viewGracias()
        {
            return View("viewGracias");
        }

    }
}