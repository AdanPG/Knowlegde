<HTML>
<BODY>



<!--EJERCICIO 1:-->
<?php
//LLAMANDO A LA FUNCION SIN MOVERSE DE LA PAGINA, EJECUCION POR ORDEN

//include("funcion.php");
//echo "desde aqui se llama a la funcion, sin moverse de esta pagina: <br><br>";
//echo mensaje();

?>




<!--EJERCICIO 2:-->
<!--<FORM METHOD="POST" ACTION="FUNCION.PHP">
<?php
//BRINCAR A LA PAGINA DE LA FUNCION Y DE AHI QUE MUESTRE EL MENSAJE
?>
<input type="submit" name="button" value="Brincar a la funcion">
</FORM>
-->


<!--EJERCICIO 3:-->

<FORM METHOD="POST" ACTION="FUNCION.PHP">

<label >mensaje para pasar a la funcion</label>
    <input type="text" name="m1"><!-- id="num1"><br>-->

<input type="submit" name="button" value="Brincar a la funcion">

<?php
//brinca a la funcion y se muestra el mensaje, pero con datos pasados desde el formulario
if(isset($_POST["button"]))
{
    $m1=$_POST["m1"];
}

?>

</FORM>
</BODY>
</HTML>