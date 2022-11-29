<?php
/*Los CAMPOS O METODOS estaticos tienen la misma funcionalidad que en otros lenguajes, con la novedad de que una clase normal puede tener uno o mas campos o metodos estaticos

para declarar un campo/metodo estatico se pone static*/


class claMy{

	private static $atrStatic=250;
	//esto origina que el campo se pueda manipular haciendo referencia a la clase base, lo cual no es aceptable

	//privada para que no se pueda modificar directamente con la clase base

	function metModStatic(){
		//para referenciarlo se utiliza SELF::
		return 100+self::$atrStatic;
	}

	static function metEtatico(){
		self::$atrStatic=1000;
		return self::$atrStatic;
	}
}



echo "mostrando el campo estatico <br>";
$claM=new claMy();

echo $claM->metModStatic();


//instruccion que no es aceptable, acceso a un campo estatico desde la clase base. por lo visto al declarar un estatico convierte en estatica a al propia clase
//claMy::$atrStatic=5000;


echo "<br>";
echo "accesa al metodo estatico referenciando a la clase base, sin instancia <br>";

echo claMy::metEtatico();





?>