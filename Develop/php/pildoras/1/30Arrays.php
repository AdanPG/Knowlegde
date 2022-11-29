<?php

//array indexado
//$semana[]="lunes";
//$semana[]="martes";
//$semana[]="miercoles";


//otra forma de declararlos


$semana=array("lunes","martes","miercoles","jueves","viernes");

echo $semana[2];

echo "<br>";

//array sin indexar

$nombres=array("nombre"=>"adan","apellido"=>"perez");
echo $nombres["nombre"];

echo "muestra si es array o no con la funcion IS_ARRAY() <br>";

if (is_array($semana))
{
	echo "es un array";
}
else
{
	echo "no un array";	
}


echo "<br>";
echo "<br>";
echo "recorrido del array con foreach <br>";


foreach ($nombres as $key => $value) {
	echo "$key $value <br>";
}

echo "<br>";


echo "<br>";
echo "<br>";
echo "recorrido del array con for <br>";

for($i=0;$i<3;$i++)
{
	echo $semana[$i]."<br>";
}

echo "<br>";
echo "<br>";
echo "recorrido del array con for pero sin saber el limite <br>";

for($i=0;$i<count($semana);$i++)
{
	echo $semana[$i]."<br>";
}

echo "<br>";
echo "<br>";
echo "ordenar el array <br>";

sort($semana);

for($i=0;$i<3;$i++)
{
	echo $semana[$i]."<br>";
}



echo "<br>";
echo "ojo con var_dump() la funcion que recorre y desglosa las arrays de arrays <br>";
?>