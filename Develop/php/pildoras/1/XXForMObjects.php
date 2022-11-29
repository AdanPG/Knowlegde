<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Documento sin título</title>
</head>

<body>

<form>
	<p>el objeto label, solo se configura lo que mostrara y quiza el name por si se referencia </p>
    <label>soy una label</label><br><br>

    <p>los imput que son las cajas de texto, se configura type y el name para referenciarlos</p>
    <input type="text" name="num1" ><br><br>
    <input type="password" name="num1" ><br><br>

     <p>las listas solo el name para referenciarlos</p>
     <select name="operacion" >
      <option>Suma</option>
      <option>Resta</option>
     </select><br><br>


    <p>los botones, se configura type, id y onClick, recordar que por lo regular este control se liga a un codigo isset que es con lo que se desencadena el codigo asociado</p>
    <input type="submit" name="button" id="button" value="Enviar" onClick="prueba">
</form>



</body>
</html>