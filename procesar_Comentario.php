<?php
include 'Conexion_BD.php';
// Se almacenan en variables los datos almacenados por los campos del formulario ubicado en la pantalla modComentario.php
$id=$_POST['Id_Cliente'];
$comentario=$_POST['TxtComentario'];

//Consulta en Base de Datos para generar la actualización de los comentarios del cliente
$actualizar_comentario = "UPDATE comentarios_clientes SET Comentario_Cliente='$comentario' WHERE Id=$id";

//Ejecuta la acción descrita anteriormente.
$resultado=mysqli_query($conexion,$actualizar_comentario);

if ($resultado){
    echo "<script>alert('Se ha actualizado el comentario del cliente exitosamente');
    window.location='/choqmol/gestionarCliente.php'</script>";
} else {
    echo "<script>alert('No se pudo actualizar el comentario');
    window.history.go(-1);</script>";
    }

if (isset($_POST["Regresar_Comentarios"])){
   header ("Location: gestionarCliente.php");
}
?>