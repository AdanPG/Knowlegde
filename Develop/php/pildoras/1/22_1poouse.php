<?php
//referencia a la clase para utilizarla
include("22poo.php");



//instancia de la clase
$myCoche=new claCoche();
//llamar a un metodo
echo "llamar a un metodo de clase girar <br>";
$myCoche->metGirar();

echo "<br><br>";

//llamar a un atributo
echo "llamar a un atributo de clase ruedas <br>";
echo $myCoche->atrRuedas;

echo "<br><br>";

//modifica un atributo de escritura
echo "modificar un atributo de escritura <br>";
$myCoche->metCamColor("rojito");


?>