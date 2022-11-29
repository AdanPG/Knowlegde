using Dapper;
using ManejoPresupuesto.Models;
using ManejoPresupuesto.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {

        //esto es para probar la conexion a datos con dapper: se crea la instancia en el constructor
        //y luego en crear se llama a la libreria de dapper. pero es una forma provisional ya que el
        //codigo de acceso a datos no debe ir en el controlador. se debe cear una clase repositorio,
        //dentro de una carpeta servicios.

        //private readonly string cn;
        //public TiposCuentasController(IConfiguration configuration)
        //{
        //    cn = configuration.GetConnectionString("DefaultConnection");
        //}


        //esto es para cuando se utiliza el repositorio con interfaces
        private IRepositorioTiposCuentas RepositorioTiposCuentas;
        private readonly IServicioUsuarios servicioUsuarios;


        //agregamos el servicio de usuarioId en el constructor y se agrega como
        //campo
        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas, IServicioUsuarios servicioUsuarios)
        {
            this.RepositorioTiposCuentas = repositorioTiposCuentas;
            this.servicioUsuarios = servicioUsuarios;
        }


        public async Task<IActionResult> Index()
        {
            //de aqui se debe crear la vista para mostrar la lista
            //se va sustituyendo var usuarioId=1;

            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tiposcuentas = await RepositorioTiposCuentas.Obtener(usuarioId);
            return View(tiposcuentas);
        }

        public IActionResult crear()
        {
            //codigo para probar dapper
            //using (var connection=new SqlConnection(cn))
            //{
            //    var qry = connection.Query("SELECT 1").FirstOrDefault();
            //}

            //ejemplo de como mandar un dato dentro del modelo
            //var mod = new TipoCuenta() { nombre = "adan" };
            //return View(mod);
            return View("crear");
        }

        [HttpPost]
        /*[ValidateAntiForgeryToken]*/
        /*OJO. mandaba el parametro pero no como instancia del modelo, agregando method="post"
         * a la propiedad del formaulario en la vista, ahora si se instancia el modelo Tipos 
         * Cuentas, solo que los campos siguen llegando nulos.
         * 
         * una alternativa era la coleccion FormCollection
         * 
         * pasaba nulo tc porque se estaban utilizanco como campos las propiedades del modelo
         */
        public async Task<IActionResult> crear(TipoCuenta tc) //FormCollection fc)//
        {
            /*aunque hay validacion de campos en la vista, requiere cachar la validez del modelo*/

            if (!ModelState.IsValid)
            {
                /*se le manda tc para que se siga viendo la informacion que ya tenia capturada,
                 persiste la data del formulario, ver asp-for en la vista*/
                return View(tc);
            }

            //aqui ya se puede utilizar el procedimiento crear
            //se le da un usuarioid artificial porque aun no se crea el procedimiento
            tc.usuarioid = servicioUsuarios.ObtenerUsuarioId();

            //aqui la otra parte de la validacion para ver si existe el tipo de cuenta
            var yaExiste = await RepositorioTiposCuentas.Existe(tc.nombre, tc.usuarioid);
            if (yaExiste)
            {
                ModelState.AddModelError(nameof(tc.nombre), $"el {tc.nombre} ya existe");
                return View(tc);
            }


            await RepositorioTiposCuentas.Crear(tc);

            //como ya existe un index debe redirigir ahi, no al success
            //sin redirecttoaction mandaba error al llamar a Model de la vista ??????, quiza redirect llama a la vista desde una instancia ya existente
            return RedirectToAction("index");
        }



        //editar, aqui realmente busca el usuario por id
        [HttpGet]
        public async Task<ActionResult> Editar(int id)
        {
            //comprueba los ids
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tipoCuenta = await RepositorioTiposCuentas.ObtenerXId(id, usuarioId);

            if (tipoCuenta is null) {
                return RedirectToAction("noencontrado", "" +
                    "Home");
            }

            //si vienen los ides llama al formulario de edicion SOLO LLAMA AL FORMULARIO PARA EDITAR
            return View(tipoCuenta);
        }


        //en este si se hace la edicion de datos
        [HttpPost]
        public async Task<ActionResult> Editar(TipoCuenta tipoCuenta)
        {
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tipoCuentaExiste = await RepositorioTiposCuentas.ObtenerXId(tipoCuenta.id,usuarioId);

            if(tipoCuentaExiste is null)
            {
                return RedirectToAction("noencontrado","Home");
            }

            //este es realmente la diferencia. aqui se le mandan los datos del modelo MANDA LOS DATOS EDITADOS
            await RepositorioTiposCuentas.Actualizar(tipoCuenta);
            return RedirectToAction("index");
        }


        //validaciones por controlador. ???? son validaciones que utilizan js, a fin de cuentas
        //llaman al procedimiento Existe y tambien PIENSO que se viola el pincipio
        //de duplicar funcionalidad del controlador
        //luego se invoca el atributo en el modelo

        [HttpGet]
        public async Task<IActionResult> VerificarTCuenta(string nombre)
        {
            //se debe tomar el id de usuario de alguna lista
            var usuarioid = servicioUsuarios.ObtenerUsuarioId();
            var YaExiste = await RepositorioTiposCuentas.Existe(nombre, usuarioid);

            if(YaExiste)
            {
                return Json($"el nombre {nombre} ya existe");
            }

            return Json(true);
        }

        //evalua que los ides sean validos
        public async Task<IActionResult> Borrar(int id)
        {
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tipoCuenta = await RepositorioTiposCuentas.ObtenerXId(id,usuarioId);

            if (tipoCuenta is null)
            {
                return RedirectToAction("noencontrado","Home");

            }
            return View(tipoCuenta);

        }


        //el procedimiento que realmente borra, notar que no es sobrecarga, por ello si 
        //cambia de nombre. aqui se debe crear la vista, el formulario de confirmacion
        [HttpPost]
        public async Task<IActionResult> BorraTC(int id)
        {
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tipoCuenta = await RepositorioTiposCuentas.ObtenerXId(id, usuarioId);

            if (tipoCuenta is null)
            {
                return RedirectToAction("noencontrado", "Home");

            }
            await RepositorioTiposCuentas.Borrar(id);
            return RedirectToAction("index");
        }
        
       

    }
}
