<?php
//EJERCICIO 1: MENSAJE MOSTRADO EN LA MISMA PAGINA EN DONDE SE LLAMA A LA FUNCION, SE UTILIZA EL INCLUDE

//function mensaje(){
//echo "mensaje desde la funcion";
//}




//JERCICIO 2: MENSAJE BRINCANDO A LA FUNCION UTILIZANDO POST DEL FORMULARIO Y EL ACTION
//SOLO SE AGREGA UN BOTON QUE HAGA EL POST

//function mensaje(){
//echo "mensaje brincando a la funcion";
//}

//mensaje();




//JERCICIO 3: MENSAJE BRINCANDO A LA FUNCION UTILIZANDO POST DEL FORMULARIO Y EL ACTION, pero mandando menaje desde el formulario con una variable de sesion
//SOLO SE AGREGA UN BOTON QUE HAGA EL POST

function mensaje(){
echo $_POST["m1"];;
}

mensaje();

?>