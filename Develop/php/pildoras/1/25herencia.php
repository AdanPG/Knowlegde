<?php
include("22poo.php");


//hereda de la clase coche con EXTENDS
class claCamion extends claCoche{


function claCamion(){
		$this->atrRuedas="22";
		$this->atrColor="blanco";
		$this->atrMotor=3600;
	}

//sobrecarga de metodos, para cuando necesitamos un comportamiento distinto al que nos ofrece la clase padre
function metCamColor($c,$n){
	$this->atrColor=$c;
	echo "mi nuevo color es: " . $this->atrColor . " en mi camion " . $n;
}


//ampliar la funcionalidad, para cuando requerimos la funcionalidad del padre y aparte funcionalidades extra PARENT

function metGirar(){
	//indica que se utilizara toda la funcionalidad original y luego el codigo ampliado
	parent ::metGirar();
	echo "<br>";
	echo "Esperando instrucciones...";
}

};


echo "Mostrando los atributos de la clase <br>";
$myClaCamion=new claCamion();

//origino error por utilizar protected, comportamiento esperado, se corrige utilizando
echo "el tipo de color para el camion es: " . $myClaCamion->getRuedas() . "<br>";

//echo "el tipo de ruedas para el camion son: " . $myClaCamion->atrRuedas . "<br>";
//echo "el tipo de color para el camion es: " . $myClaCamion->atrColor . "<br>";


echo "el tipo de motor para el camion es: " . $myClaCamion->atrMotor . "<br>";

echo "<br>";
echo "Mostrando los metodos de la clase <br>";

$myClaCamion->metFrenar();
echo "<br>";
echo "<br>";

echo "sobreescribiendo el metodo metCamColor,  <br>";
$myClaCamion->metCamColor("gris","mack");

echo "<br><br>";
echo "usando funcionalidad ampliada con PARENT <br>";

$myClaCamion->metGirar();

//echo "<br>";
//echo "<br>";
//tratando de modificar un atributo privado, mandara error
//$myClaCamion->atrRuedas=9;



?>