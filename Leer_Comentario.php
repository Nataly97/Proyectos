<?php
include "Conexion_BD.php";

//Código que permite filtrar los  registros de la tabla que se encuentra en la pantalla Historial de Clientes. 
if(!isset($_POST['txtBuscar'])){

    $_POST["txtBuscar"] = "";
    $buscar = $_POST["txtBuscar"];
}

$buscar = $_POST["txtBuscar"];

$sql_leer = "SELECT * FROM comentarios_clientes WHERE Nombre_Cliente LIKE '%".$buscar."%' OR Documento_Cliente LIKE '%".$buscar."%'";

$result = mysqli_query($conexion,$sql_leer);
if(!$result){
    var_dump(mysqli_error($conexion)); 
    exit;
}
?>