<?php
include 'Conexion_BD.php';
//Código que recibe id asociado al usuario para proceder con su eliminación en la Base de Datos 
$id=$_GET['id'];
$eliminar_usuario="DELETE FROM usuarios WHERE Id_Usuario='$id'"; 

//Ejecuta la acción o consulta descrita anteriormente 
$resultado=mysqli_query($conexion,$eliminar_usuario);

if ($resultado){
    echo "<script>alert('Se ha eliminado el usuario exitosamente');
    window.location='/choqmol/listadoUsuarios.php'</script>";
} else {
    echo "<script>alert('No se pudo eliminar el usuario');
    window.history.go(-1);</script>";
    }
?>