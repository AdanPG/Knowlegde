<?php

/*el ejemplo mas comun es cuando se requiere que la variable mantenga su valor, lo cual la equipara con 
una variable global o con una variable de sesion*/

function x(){

//al colocar la instruccion static indicamos que se trata de una variable global
static $variable=0;

print $variable++;
}


echo x(). "<br>";
echo x(). "<br>";
echo x(). "<br>";
echo x(). "<br>";


?>