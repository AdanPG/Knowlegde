<?php
	$servidor="localhost";
	$nombrebd="empresa";
	$usuario="root";
	$contrasena="";

require_once '3xconnect.php';
//$conexion=connect_bd();
$query="SELECT * from empleado";
$resultado=new mysqli($servidor,$usuario,$contrasena,$nombrebd);
//mysqli_close($conexion);
?>


<html>
	<header></header>
	<body>
		<hi lista de empleados/>

		<?php
			if($connect_bd->query($query) === TRUE) 
			{
				while($registro=mysqli_fetch_assoc($resultado))
				{
					echo'<li>'.$registro['empleado_nombre'].'</li>';
				}
			}
			$connect_bd->close();


		?>
	</body>	

</html>