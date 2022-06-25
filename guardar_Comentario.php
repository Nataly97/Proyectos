<!-- Código que guarda en Base de Datos los datos ingresados en la pantalla crearComentario.php  -->
<?php
    include "Conexion_BD.php";

    if (isset($_POST["btnGuardarComentario"])){

        //Código para almacenar los datos ingresados en las variables definidas. 
        $nombre = $_POST['Nombre_Cliente'];
        $apellido = $_POST['Apellido_Cliente'];
        $documento = $_POST['Documento_Cliente'];
        $correo = $_POST['Correo_Cliente'];
        $direccion = $_POST['Direccion_Cliente'];
        $telefono = $_POST['Telefono_Cliente'];
        $comentario= $_POST['TxtComentario'];
        $fecha=$_POST['fechaComentario'];

        //Código que inserta los datos de las variables en cada una de las columnas de la Base de Datos.
        $insertar_comentario = "INSERT INTO comentarios_clientes (Nombre_Cliente,Apellido_Cliente,Documento_Cliente,Correo_Cliente,
        Direccion_Cliente,Telefono_Cliente,Comentario_Cliente, Fecha_Comentario) VALUES('$nombre','$apellido', 
        '$documento', '$correo', '$direccion', '$telefono', '$comentario', '$fecha')";

        //Variable que ejecuta la consulta de Insertar.
        $ejecutar = mysqli_query($conexion,$insertar_comentario);

        if ($ejecutar){
            echo "<script>alert('Comentario guardado exitosamente');
            window.location='/choqmol/listadoClientes.php'</script>";
        } else {
            echo "<script>alert('Error al guardar el comentario');
            window.history.go(-1);</script>";
        }

    }

?>