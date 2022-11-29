<?php

//para interrumpir la ejecucion de los bucles se utiliza la instruccion BREACK;
//para omitir una iteracion se utiliza CONTINUE;


//bucles indeterminados
//puede que nunca se ejecute el codigo 
$v=1;

while ( $v< 5) {
	echo "while menor a 5" . "<br>";
	echo "hola siguen siendo menores a 5" . "<br>";
	//aqui deberia entrar una instruccion rand, para que realmente no sea indeterminado el numero de ejecuciones, ya que con este contador sabemos bien cuantas veces se repetira. 
	$v++;
}

echo "llego a 5 <br><br><br>";

//para forzar a que se ejecute por lo menos una vez

do {
	echo "dentro del do while <br>";
	$v++;
}
while ( $v<5);
echo $v;

echo "<br><br>";


//------------------------------------------------------------------------



//bucles determinados
for($i=0;$i<10;$i++)
{
	//por ejemplo para omitir una iteracion
	/*if($i=7){
		echo "este numero no esta permitido";
		continue;
	}
	*/

	echo "bucles for menor a 10 <br>" . $i;
	//echo $i;
}

?>