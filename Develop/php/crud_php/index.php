
<?php 
//referencia al action que tiene la conexion
require_once 'php_action/db_connect.php'; 


setcookie("saludo","hola cookie",time()+60);
$muestra=$_COOKIE['saludo'];
echo "se crea la cookie en el navegador despues de 6 segundos".'<br>';;
echo $muestra.'<br>'.'<br>';



session_start();
$_SESSION["saludo"]="hola sesiones";
$x=$_SESSION["saludo"];
echo "esta es una session que se almacena en el servidor".'<br>';
echo $x;


?>
 
<!DOCTYPE html>
<html>
<head>
    <title>PHP CRUD</title>
 
    <style type="text/css">
        .manageMember {
            width: 80%;
            margin: auto;
        }
 
        table {
            width: 100%;
            margin-top: 10px;
            
        }
 
    </style>
 
</head>
<body>
 
<div class="manageMember">
    <!--configura el boton de agregar en el crud-->
    <a href="create.php"><button type="button">Add Member</button></a>
    <table border="1" cellspacing="0" cellpadding="0">
        <!--encabezados de la tabla-->
        <thead>
            <tr>
                <th>Name</th>
                <th>Age</th>
                <th>Contact</th>
                <th>Option</th>
            </tr>
        </thead>
         <!--datos de la tabla-->
        <tbody>
            <?php
            $sql = "SELECT * FROM members WHERE active = 1";
            $result = $connect->query($sql);
            //vacia la consulta en la tabla de la pagina, asi como sus botones individuales 
            if($result->num_rows > 0) {
                while($row = $result->fetch_assoc()) {
                    //fetch_assoc crea una referencia a todos los campos de la consulta a manera
                    //de que se generen variables tipo sesion $row['campo']"
                    echo "<tr>
                        <td>".$row['fname']." ".$row['lname']."</td>
                        <td>".$row['age']."</td>
                        <td>".$row['contact']."</td>
                        <td>
                            <!--a los botones les agrega una variable que toma el session del id del registro-->



                            <a href='edit.php?id=".$row['id']."'><button type='button'>Edit</button></a>
                            <a href='remove.php?id=".$row['id']."'><button type='button'>Remove</button></a>
                        </td>
                    </tr>";
                }
            } else {
                echo "<tr><td colspan='5'><center>No Data Avaliable</center></td></tr>";
            }
            ?>
        </tbody>
    </table>
</div>
 
</body>
</html>