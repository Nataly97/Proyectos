<?php
include("Conexion_BD.php");
include("guardar_Comentario.php");
include("session.php");
$id = $_GET['id'];
$clientes_comentario = "SELECT * FROM clientes WHERE Id_Cliente = '$id'";
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
        <h1>Agregar Comentario</h1>
        <form id="formulario_gestionarCliente" class="form" action="guardar_Comentario.php" method="post">
            <div class="row">

                <!-- Código que trae a los campos del formulario algunos 
                de los datos del cliente consignados en la Base de Datos.  -->
                <?php
                $consulta = mysqli_query($conexion, $clientes_comentario);
                while ($row = mysqli_fetch_assoc($consulta)) {
                    echo "

                    <input type='hidden' name='Id_Cliente' value='$row[Id_Cliente]'>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Nombre</label>
                        <input type='text' readonly name='Nombre_Cliente' value='$row[Nombre]' class='form-control' placeholder='Nombre' required>
                    </div>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Apellido</label>
                        <input type='text' readonly name='Apellido_Cliente' value='$row[Apellido]' class='form-control' placeholder='Apellido' required>
                    </div>

                    <div class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Número de documento</label>
                    <input type='text' readonly name='Documento_Cliente' value='$row[Num_Documento]' class='form-control' placeholder='Número de documento' required>
                    </div>
                    <div class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Fecha de gestión</label>
                    <input type='date' name='fechaComentario'class='form-control' placeholder='Fecha' required>
                    </div>

                    <input type='hidden' name='Correo_Cliente' value='$row[Correo]'>

                    <input type='hidden' name='Direccion_Cliente' value='$row[Direccion]'>

                    <input type='hidden' name='Telefono_Cliente' value='$row[Telefono]'>

                ";
                }
                ?>
                <!-- Campo para ingresar Comentarios sobre la gestión del cliente -->
                <div class="col-md-12">
                    <label for="" class="form-label">Comentario</label>
                    <textarea class="form-control" name="TxtComentario" rows="3" required></textarea>
                </div>
                <!-- Botón Guardar Comentario -->
                <div>
                    <button type="submit" name="btnGuardarComentario" class="btn_GuardarComentario">Guardar Comentario</button>
                </div>
            </div>
        </form>
        <!-- Botón para regresar a la pantalla de Listado Clientes-->
        <div>
            <button onclick="location.href='/choqmol/listadoClientes.php'" type="submit" name="Regresar_Comentarios" class="btn_RegresarComentarios">Regresar</button>
        </div>
    </div>
</body>

</html>