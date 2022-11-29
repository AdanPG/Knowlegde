<?php

	$servidor="localhost";
	$nombrebd="empresa";
	$usuario="root";
	$contrasena="";

	$connect_bd=new mysqli($servidor,$usuario,$contrasena,$nombrebd);

	if ($connect_bd->connect_error)
	{
		die("error".$connect_bd->connect_error);
	}
	else
	{
		//echo "bienvenido".$connect_bd->server_info;
	}


?>