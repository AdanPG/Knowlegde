using Dapper;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;


/*aqui van los procedimientos para el funcionamiento de las vistas, los CRUD
 luego de esto se debe crear el servicio en program.cs

ASYNC. los procedimientos I/O deben estar en una logica asincrona, ya que se trata de
una llamada a una base se datos, como es el presente caso.

ahora se va a implementar el TERCER tipo de validacion que es a nivel de controlador, esto se
hace desde el punto de vista de que se trata de acciones que implican bases de datos. ver procedimiento
existe()
 */


namespace ManejoPresupuesto.Servicios
{
    //se hace esto porque no debe haber dependencias de tipos, sino de 
    //objetos abastractos, interfaces. INYECCION DE DEPENDENCIAS
    public interface IRepositorioTiposCuentas
    {
        Task Actualizar(TipoCuenta tipoCuenta);
        Task Borrar(int id);
        Task Crear(TipoCuenta tipocuenta);

        //contrl + punto desde el procedimiento para que se genere este codigo
        Task<bool> Existe(string nombre, int usuarioid);
        //control+punto parea agregar
        Task<IEnumerable<TipoCuenta>> Obtener(int usuarioId);
        Task<TipoCuenta> ObtenerXId(int id, int usuarioId);
    }







    public class RepositorioTiposCuentas:IRepositorioTiposCuentas
    {
        /*desde aqui el manejo de la capa de datos. el standard dice que se debe 
         * manejar todo desde una abstraccion*/
        private readonly string connectionString;

        public RepositorioTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        //se agrega async await task. y luego en donde se hace la inyeccion, o sea en el
        //controlador. task es como void pero en modo asincrono
        public async Task Crear(TipoCuenta tipocuenta)
        {
            //notar como se le pasa la instancia del modelo, con ello dapper 
            //busca en los campos los valores
            using var connection = new SqlConnection(connectionString);
            var id =await connection.QuerySingleAsync<int>(@"insert into tiposcuentas(nombre,usuarioid,orden) 
            values(@nombre,@usuarioid,0); SELECT SCOPE_IDENTITY();", tipocuenta);

            tipocuenta.id = id;
        }


        //ojo, en primera instancia se implemento esta validacion, pero requiere que se oprima submit, o sea una llamada al
        //servidor. luego de ello, se implementara con js para que sea al momento de estar llenando el formulario
        public async Task<bool> Existe(string nombre, int usuarioid)
        {
            //QueryFirstOrDefaultAsync<int> significa que debe regresar el valor de la consulta o el valor por default de int, que es 0
            //es buena opcion para evitar contar los registros de la consulta para devolver cierto o falso
            using var connection = new SqlConnection(connectionString);
            var existe = await connection.QueryFirstOrDefaultAsync<int>(@"select 1 from tiposcuentas where nombre=@nombre and usuarioid=@usuarioid;", new { nombre, usuarioid });

            return existe == 1;
        }


        public async Task<IEnumerable<TipoCuenta>> Obtener(int usuarioId)
        {
            //como lo usual es que se muestre la lista por default en la vista, se agrega un 
            //procedimiento index en el controlador
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<TipoCuenta>(@"select id, nombre, orden from
            tiposcuentas where usuarioid=@usuarioId", new { usuarioId });
        }


        //luego de estos dos, se agrega el procedimiento al controlador y la vista
        public async Task Actualizar(TipoCuenta tipoCuenta)
        {

            using var connection = new SqlConnection(connectionString);
            //es como solo ejecutar sin retorno de nada
            await connection.ExecuteAsync(@"update tiposcuentas set nombre=@nombre where id=@id",
                tipoCuenta);
        }

    
        
        public async Task<TipoCuenta> ObtenerXId(int id, int usuarioId)
        {

            //usuarioId para que vea solo lo que le incumbe
            //los parametros son tipos anonimos ???????
            //pasarlos a la interface Actualizar y ObtenerXId, tanto el id de usuario como el id de la cuenta sean validos, que no 
            //los haya manipulado el usuario
             using var connection = new SqlConnection(connectionString);
             return await connection.QueryFirstOrDefaultAsync<TipoCuenta>(
                 @"select id,nombre, orden from tiposcuentas where id=@id and usuarioid=@usuarioid", new { id,usuarioId});
         }


        //no se necesita setear un tipo, solo es  borrar
        //control + punto para agregar al a la interface el procedimiento
        //luego en el controlador se agrega la opcion de borrar
        public async Task Borrar( int id)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("delete tiposcuentas where id=@id", new {id });
        }
                
    }
}
