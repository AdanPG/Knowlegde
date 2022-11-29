namespace ManejoPresupuesto.Servicios
{

    /*este servicio tiene como objetivo centralizar con un metodo
     la definicion del usuarioid, el cual se ha mantenido artificialmente*/



    //la interface que se implementa, siguiendo la idea de utilizar abstracciones
    //no objetos
    public interface IServicioUsuarios
    {
        //control + punto 
        int ObtenerUsuarioId();
    }


    //la clase que usa la intrerface
    public class ServicioUsuarios:IServicioUsuarios
        {

            //con esto se centraliza el poner manualmente el usuarioid=1
            //cuando se tenga el procedimiento, desde aqui se hara la toma del valor
            //luego de esto se registra en program
            public int ObtenerUsuarioId()
            {
                return 1;
            }


        }
}
