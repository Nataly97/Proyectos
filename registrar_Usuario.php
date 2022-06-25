<!-- Código que guarda en Base de Datos los datos ingresados en la pantalla crearUsuario.php -->
<?php

//Código para almacenar los datos ingresados en las variables definidas. 
    include 'Conexion_BD.php';
    if (isset($_POST["Crear_Usuario"])){
         $nombre_user = $_POST['Nombre'];
         $apellido_user = $_POST['Apellido'];
         $documento_user = $_POST['Documento'];
         $correo_user = $_POST['Correo'];
         $direccion_user = $_POST['Direccion'];
         $telefono_user = $_POST['Telefono'];
         $user = $_POST['User'];
         $password = $_POST['password'];
         $seleccion_rol = $_POST['Tipo_User'];

         //Código que inserta los datos de las variables en cada una de las columnas de la Base de Datos.
         $insertar_user = "INSERT INTO usuarios (Nombre_Usuario, Apellido_Usuario, Documento_Usuario, Correo_Usuario,
         Direccion_Usuario, Telefono_Usuario , User, Password_User, RolUser) VALUES('$nombre_user', '$apellido_user', '$documento_user', '$correo_user', 
         '$direccion_user', '$telefono_user', '$user', '$password', '$seleccion_rol')";

         //Variable que ejecuta la consulta de Insertar.
         $ejecutar_user = mysqli_query($conexion,$insertar_user);

         if ($ejecutar_user){
            echo "<script>alert('Se ha registrado el usuario exitosamente');
            window.location='/choqmol/crearUsuario.php'</script>";
         } else {
            echo "<script>alert('No se pudo registrar');
            window.history.go(-1);</script>";
         }

}
?>