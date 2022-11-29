<?php



function calcular($Opera)
{
	
	//este ejemplo comenzo mandando parametros pero al segmentar resulto necesario declarar variables globales o para que no hubiera problemas de ambito
  if($Opera=="Suma")
  {
  	global $num1;
  	global $num2;
  	

    echo "el resultado es: " . ($num1+$num2);
  }
  if($Opera=="Resta")
  {
  	global $num1;
  	global $num2;
  	

    echo "el resultado es: " . ($num1-$num2);
  }
  if($Opera=="Multiplicación")
  {
  	global $num1;
  	global $num2;
    echo "el resultado es: " . ($num1*$num2);
  }
  if($Opera=="División")
  {
  	global $num1;
  	global $num2;
    echo "el resultado es: " . ($num1/$num2);
  }
  if($Opera=="Módulo")
  {
  	global $num1;
  	global $num2;
    echo "el resultado es: " . ($num1%$num2);
  }
   if($Opera=="Incremento")
  {
  	global $num1;
  	
  	$num1++;
    echo "el resultado es: " . ($num1);
  }
   if($Opera=="Decremento")
  {
  	global $num1;
  	
  	$num1--;
    echo "el resultado es: " . ($num1);
  }
}




?>