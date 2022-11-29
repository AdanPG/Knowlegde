<?php
//casting implicito, se asigna dinamicamente, solo al asignar el valor 

$var=0.35;

//para cuando lal lectura y escritura de datos da error con las ñ y acentos, utf8_encode es para escribir datos
echo "ñ la variable generó un tipo: ". utf8_decode(gettype($var)) . "<br>";

$var=true;
echo "la variable generó un tipo: ". gettype($var). "<br>";

$var="10";
echo "la variable generó un tipo: ". gettype($var). "<br><br><br>";



//casting explicito, se antecede con el tipo deseado entre parentesis

$var2=(int)$var;
echo gettype($var2);

?>