<?php

//llamada al codigo de conexion
require_once '3xconnect.php';

if($_POST)
{
	$id=$_POST['idempleado'];
	$enombre=$_POST['empleado_nombre'];
	$eedad=$_POST['empleado_edad'];

	$sql="INSERT INTO empleado(idempleado,empleado_nombre,empleado_edad) VALUES('$id','$enombre','$eedad')";

	//referencia a la variable de conexion de 3xconnect.php
	if($connect_bd->query($sql) === TRUE) 
	{
        echo "<p>New Record Successfully Created</p>";
    } else {
        echo "Error " . $sql . ' ' . $connect->connect_error;
    }
 
    $connect_bd->close();
}

?>