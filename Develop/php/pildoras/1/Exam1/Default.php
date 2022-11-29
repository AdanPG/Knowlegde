<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Documento sin título</title>
</head>

<body>
<!--PRIMERO. LA PAGINA IMPLICA UNA LLAMADA AL SERVIDOR PARA UN AOPERACION, POR LO QUE SE DEBE DEFINIR UN METODO DE ENVIO POST

  ACTION QUE BRINCA AL CODIGO DE LA FUNCION Y DE AHI SE PRESENTA UN MENSAJE DE ERROR O REDIRECCIONA A LA PAGINA DE CONTENIDO-->
<form name="form1" method="post" action="connection.php">
  <p>
    <label >Usuario</label><br>
    <input type="text" name="texUsuario"><br>
    <label >Contraseña</label><br>
    <input type="password" name="texContraseña"><br>
  </p>
  <p>
    <!--SE CONFIGURA EL BOTON ASOCIANDOLO CON ISSET-->
    <input type="submit" name="butAceptar" value="Aceptar">
  </p>


</form>
</body>
</html>