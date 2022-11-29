<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Documento sin título</title>
</head>

<body>

<p>&nbsp;</p>
<!--PRIMERO. LA PAGINA IMPLICA UNA LLAMADA AL SERVIDOR PARA UN AOPERACION, POR LO QUE SE DEBE DEFINIR UN METODO DE ENVIO POST.

  EL ACTION SE DEFINE CUANDO SE DESEA POR EJEMPLO PASAR A OTRA PAGINA, EN ESTE CASO SOLO SE LLAMA A UNA FUNCION A LA QUE LE VA A PASAR LOS PARAMETROS SIN PASAR A OTRA PAGINA, y se ejecuta secuencialmente-->


<form name="form1" method="post"><!-- action="11_1calculadora.php">-->
  <p>
    <label >Numero 1</label>
    <input type="text" name="n1"><!-- id="num1"><br>-->
    <label >Numero 2</label>
    <input type="text" name="n2"><!-- id="num2"><br>-->
    <label >Operacion</label>
    <select name="op"><!-- id="operacion">-->
      <option>Suma</option>
      <option>Resta</option>
      <option>Multiplicación</option>
      <option>División</option>
      <option>Módulo</option>
      <option>Incremento</option>
      <option>Decremento</option>
    </select>
  </p>
  <p>
    <!--el boton unicamente hace el envio, algo como un postback, no necesita mas, la funcion sera la que reciba los datos del formulario-->
    <input type="submit" name="button" value="Calcula">
  </p>
</form>
<p>&nbsp;</p>






<?php

//CON LA IDEA DE SEGMENTAR CODIGO, SE AGRAGA LA SENTENCIA INCLUDE
include("111calculadora.php");


//*SI SE PRESIONo EL BOTON CALCULAR*/
if(isset($_POST["button"]))
{
    //se toman los valores de los campos en variables de sesion
  //
    $num1=$_POST["n1"];
    $num2=$_POST["n2"];
    $ope=$_POST["op"];

    //se llama a la variable y se le pasan los parametros, con esto se evita el error de ambitos de las variables
    $opev="Ha seleccionado la operacion: " . $ope;

    echo "<script>alert('$opev')</script>";

    echo "el resultado en secuencia es: <br>";
    
    calcular($ope);
}



?>





</body>
</html>