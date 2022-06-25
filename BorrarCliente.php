<?php
include 'Conexion_BD.php';
//Código que recibe el id de la fila y se almacena la respectiva consulta
$id=$_GET['id'];
$eliminar="DELETE FROM clientes WHERE Id_Cliente='$id'"; 

//Variable que realiza la acción solicitada en el paso anterior
$resultado=mysqli_query($conexion,$eliminar);

if ($resultado){
    echo "<script>alert('Se ha eliminado el cliente exitosamente');
    window.location='/choqmol/listadoClientes.php'</script>";
} else {
    echo "<script>alert('No se pudo eliminar el registro');
    window.history.go(-1);</script>";
    }
?>