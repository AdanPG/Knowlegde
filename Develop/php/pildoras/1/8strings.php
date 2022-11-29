<?php


/*strcmp -> NO ES IGUAL en forma literal
strcasecmp ->NO ES IGUAL ignorando mayusculas

funciones para comparar texto*/

$var1="casa";
$var2="casa.";

$var3=strcmp($var1, $var2);


if ($var3)
{
echo "no son iguales";
}
else{
	echo "son iguales";
}
?>