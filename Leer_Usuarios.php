<?php
include "Conexion_BD.php";

//Código que permite filtrar los  registros de la tabla que se encuentra en la pantalla Listado de Usuarios. 
if(!isset($_POST['TxtBuscar_Usuario'])){

    $_POST["TxtBuscar_Usuario"] = "";
    $buscar = $_POST["TxtBuscar_Usuario"];
}

$buscar = $_POST["TxtBuscar_Usuario"];

$sql_leer = "SELECT * FROM usuarios WHERE Nombre_Usuario LIKE '%".$buscar."%' OR Documento_Usuario LIKE '%".$buscar."%'";

$result = mysqli_query($conexion,$sql_leer);
if(!$result){
    var_dump(mysqli_error($conexion)); 
    exit;
}
?>