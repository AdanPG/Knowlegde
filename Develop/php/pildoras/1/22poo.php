<?php

//construccion de la clase
class claCoche
{
	//modificafores de acceso
	//PUBLIC: se puede acceder a allos desde cualquier lado, ES EL MODIFICADOR POR DEFECTO
	//PRIVATE: el acceso solo es dentro de la clase
	//PROTECTED: accesible desde la propia clase y desde sus herencias

	/*confusion. el detalle es que si quieres que las clases heredadas no puedan modificar los atributos y metodos, pero si quieres que se puedan leer, utilizar el protected, porque private bloquea por completo los atributos y metodos*/

	//CONSTRUCTOR ---------------------------------------------------------------------------------
	function claCoche(){
		$this->atrRuedas="8";
		$this->atrColor="";
		$this->atrMotor=1600;
	}

	
	//ATRIBUTOS------------------------------------------------------------------------------------
	//privado porque cada vehiculo tiene x numero de ruedas y no se debe poder alterarlo sin ninguna restriccion
	
	//private $atrRuedas;
	
	//solo que private bloquea por completo el acceso, por lo cual se debe crear una funcion get para el acceso de solo lectura

	//el SET en realidad es el metodo metCamColor, solo que no hemos utilizado la convencion setCamColor

	protected $atrRuedas;
	function getRuedas(){
		return $this->atrRuedas;
	} 

	var $atrColor;
	var $atrMotor;


	//METODOS-------------------------------------------------------------------------------
	function metArrancar(){
		echo "he arrancado";
	}

	function metFrenar(){
		echo "he frenado";
	}

	function metGirar(){
		echo "he girado";
	}

	//modificar un atributo de escritura
	function metCamColor($c){
	$this->atrColor=$c;
	echo "mi nuevo color es: " . $this->atrColor;
}

}



?>