<?php
include 'Conexion_BD.php';
// Se almacenan en variables los datos almacenados por los campos del formulario ubicado en la pantalla modUsuario.php
if (isset($_POST["Modificar_Usuario"])){
$id=$_POST['Id_User'];
$nombre = $_POST['Nombre_User'];
$apellido = $_POST['Apellido_User'];
$documento = $_POST['Documento_User'];
$correo = $_POST['Correo_User'];
$direccion = $_POST['Direccion_User'];
$telefono = $_POST['Telefono_User'];
$user= $_POST['User'];
$contrasena= $_POST['Password_User'];
$seleccion_rol = $_POST['Tipo_Rol'];

//Consulta en Base de Datos para generar la actualización de los datos del Cliente
$actualizar_usuario = "UPDATE usuarios SET Nombre_Usuario='$nombre', Apellido_Usuario='$apellido', Documento_Usuario='$documento',
            Correo_Usuario='$correo', Direccion_Usuario='$direccion', Telefono_Usuario='$telefono', User='$user', 
            Password_User='$contrasena',  RolUser='$seleccion_rol' WHERE Id_Usuario=$id";

//Ejecuta la acción descrita anteriormente.
$resultado=mysqli_query($conexion,$actualizar_usuario);

if ($resultado){
    echo "<script>alert('Se ha actualizado el usuario exitosamente');
    window.location='/choqmol/listadoUsuarios.php'</script>";
} else {
    echo "<script>alert('No se pudo actualizar el usuario');
    window.history.go(-1);</script>";
}
}