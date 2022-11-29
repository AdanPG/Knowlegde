<?php
/*AMBITO DE FUNCIONES
cada bloque de codigo en si mismo es un ambito en php, por lo cual no se puede accesar a un 
ambito aunque se encuentre en la misma pagina. esto para evitar sobreescritura.
*/

$nombre="juan";

function funCambiaNombre(){

	//con global se indica que se quiere modificar intencionalmente la variable cambiandole 
	//su ambito
	global $nombre;
	$nombre="juan modificado con la sentencia global <br>";
	echo $nombre;
}

funCambiaNombre();


echo "<br>";

/*las funciones se pueden incluir en la misma pagina, antes o despues de la llamada. tambien se pueden
tener en un archivo de la misma aplicacion, lo cual seria equivalente a tener una funcion publica, para 
ello se debe incluir el archivo de la funcion con include y luego llamar a la funcion*/

/*INCLUDE Y REQUIRE
ambas sirven para lo mismo, solo que con require no se permite la ejecucion de ningun codigo 
despues de que la llamada a la funcion haya fallado, pues se trata de una informacion REQUERIDA*/



echo "muestra la fecha desde una funcion que esta en un archivo externo <br>";

include ("5_1FuncionFecha.php");
FuncionFecha();


echo "<br><br> otras funciones utiles <br><br>";

echo "esta es una cadena pasada a minusculas: " . strtolower("MINUSCULAS") . "<br>";
echo "esta es una cadena pasada a mayusculas: " . strtoupper("mayusculas") . "<br>";
echo "esta es una cadena pasada a altas y bajas: " . ucwords("adan perez") . "<br><br><br>";


//PARAM OPCIONAL o PREDEF: la manera es darle un valor
echo "PARAMETROS OPCIONALES------------------------------------------<BR><br>";


function funMy($op=0){

	if($op>0){

		echo "diferente de 0";
	}
	else{

		echo "entra el param opcional =0";
	}
}

echo funMy();

?>