<?php

//recibe los datos del formulario evaluando si se pulso el boton, Nota: para el servidor mariadb local, el user es root y el passdword es una cadena vacia
if(isset($_POST["butAceptar"]))
{
  $us=$_POST["texUsuario"];
  $pas=$_POST["texContraseña"];

  //llama a la funcion pasandole los parametros evitando errores de ambito de las variables
  //Tambien, para evitar crear nueva variables parametros se pueden declarar globales las variables y usarlas en los distintos bloques
  funConectar();

}


function funConectar()
{
	$localhost = "127.0.0.1"; 
	$dbname = "php_crud"; 
	//ariables globales
	global $us;
	global $pas; 
	
 
	// create connection 
	$connect = new mysqli($localhost, $us, $pas, $dbname); 
 
	// check connection 
	if($connect->connect_error) 
	{
		//EN LA MISMA PAGINA DE LA FUNCION PRESENTA EL CODIGO DE ERROR, AQUI SE PODRIA REDIRECCIONAR A OTRAS PAGINAS DE ERROR PERSONALIZADAS
    	die("connection failed : " . $connect->connect_error);
	}
	else 
	{
    	header('Location: panel.php');
    }


}

?>