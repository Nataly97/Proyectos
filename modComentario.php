<?php
include "Conexion_BD.php";
include "session.php";
$id_modificar = $_GET['id'];
$sql_mod_comentario = "SELECT * FROM comentarios_clientes WHERE Id = '$id_modificar'";
?>


<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gestionar Cliente</title>
    <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="css/Cliente.css">
</head>

<body>
    <div id="gestionarCliente" class="contenedor">
        <h1>Modificar Comentario</h1>
        <form id="formulario_gestionarCliente" class="form" action="procesar_Comentario.php" method="post">
            <div class="row">

            <!-- Código que realiza consulta en Base Datos y trae a los campos del formulario, cada uno de los 
                datos requeridos para su posterior modificación. -->

                <?php
                $consulta = mysqli_query($conexion, $sql_mod_comentario);
                while ($row = mysqli_fetch_assoc($consulta)) {
                    echo "

                    <input type='hidden' name='Id_Cliente' value='$row[Id]'>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Nombre</label>
                        <input type='text' readonly name='Nombre' value='$row[Nombre_Cliente]' class='form-control' placeholder='Nombre' required>
                    </div>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Apellido</label>
                        <input type='text' readonly name='Apellido' value='$row[Apellido_Cliente]' class='form-control' placeholder='Apellido' required>
                    </div>

                    <div class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Número de documento</label>
                    <input type='text' readonly name='Documento' value='$row[Documento_Cliente]' class='form-control' placeholder='Número de documento' required>
                    </div>

                    <div class='col-md-12'>
                    <label for='' class='form-label'>Comentario</label>
                    <textarea class='form-control' required name='TxtComentario'>$row[Comentario_Cliente]</textarea>
                </div>
                ";
                }
                ?>
                <!-- Botón para guardar los cambios realizados en los comentarios del cliente -->
                <div>
                    <button type="submit" name="btnGuardarComentario" class="btn_GuardarComentario">Guardar Cambios</button>
                </div>
            </div>
        </form>
        <!-- Botón para regresar a la pantalla Historial de Clientes  -->
        <div>
            <button onclick="location.href='/choqmol/gestionarCliente.php'" type="submit" name="Regresar_Comentarios" class="btn_RegresarComentarios">Regresar</button>
        </div>
    </div>

</body>

</html>