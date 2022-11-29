<html
<body>
<h2>CURSO BASICO DE PHP</H2>
<h4>VARIABLES, CURSORES, DECISION Y REPETICION</H4>

<?php

echo "VARIABLES";
echo "<br>";

$entero=20;
$real=20.5;
$cadena="hola";
$cadena_comillas='"hola"';

$bit=0;

echo "ejemplo de entero: ".$entero;
echo "<br>";
echo "ejemplo de real: ".$real;
echo "<br>";
echo "ejemplo de cadena: ".$cadena;
echo "<br>";
echo "ejemplo de cadena con comillas, usa comilla simple para envolver: ".$cadena_comillas;
echo "<br>";
echo "ejemplo de bit: ".$bit;

echo "<br>";
echo "<br>";


echo 'ARRAY O VECTOR $elnombre[elindice]';
echo "<br>";
echo "<br>";

$edades[0]=15;
$edades[1]=22;
$edades[2]=55;


echo "EJEMPLO CON WHILE QUE RECORRE EL VECTOR";
echo "<br>";

$h=0;
while($h<$EDADES.BOUND)
{
echo "edades".$h;
echo"<br>";
$h++;
}


echo "<br>";

echo "EJEMPLO CON FOR";
echo "<br>";
for($i=0;$i<3;$i++)
{
if ($edades[$i]>18 and $edades[$i]<=30 )
{
echo "joven";
echo "<BR>";
}
else if ($edades[$i]>30)
{
echo "mayor";
echo "<BR>";
}
else
{
echo "olvidalo"; 
echo "<BR>";
}
}
?>

</body>
</html>