<!-- Código para la conexión a la base de datos en PHPMyAdmin -->
<?php

$server="localhost";
$user="root";
$password="";
$nombre_db="choquetmole";

$conexion= mysqli_connect($server,$user,$password,$nombre_db);

?>
