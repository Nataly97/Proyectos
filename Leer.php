<?php
include "Conexion_BD.php";

//Código que permite filtrar los  registros de la tabla que se encuentra en la pantalla Listado de Clientes
if(!isset($_POST['Buscar'])){

    $_POST["Buscar"] = "";
    $buscar = $_POST["Buscar"];
}

$buscar = $_POST["Buscar"];

$sql_leer = "SELECT * FROM clientes WHERE Num_Documento LIKE '%".$buscar."%' OR Nombre LIKE '%".$buscar."%'";

$result = mysqli_query($conexion,$sql_leer);
if(!$result){
    var_dump(mysqli_error($conexion)); 
    exit;
}
?>