<?php


//cambia al evaluar igualdades complejar.
echo "switch con evaluaciones compuestas" . "<br>";
$v=80;

switch ($v) 
{
	case ($v>0 && $v<18):
		echo "menor de edad";
		break;
	case ($v>=18 && $v<60):
		echo "adulto";
		break;
	default:
		echo "indefinido";
		break;
}

echo "<br>";
echo "switch con evaluaciones simples" . "<br>";
//evaluacio simple

$nom="";

switch ($nom) {
	case 'juan':
		echo "hola";
		break;
	
	default:
		echo "largo";
		break;
}

?>