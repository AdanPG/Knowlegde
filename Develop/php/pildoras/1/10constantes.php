<?php
/*son objetos mas parecidos a la svariables de sesion, solo que no se pueden modificar por su
misma naturaleza CONSTANTES, su declaracion es distinta y su forma de invocacion tambien, pues no se puede insertar dentro del string como las variables, sino hay que sacarla y utilizar el punto pra concatenarla*/

/*por convencion se suele declarar con mayusculas, tambien existen muchas constantes predefinidad que
se oueden buscar en google, por ejemplo una que indica la linea del codigo actual*/

define("CONS1","adan",false);

echo "el nombre es : " . CONS1. "<br>";

echo "estoy en la linea: " . __LINE__;


?>