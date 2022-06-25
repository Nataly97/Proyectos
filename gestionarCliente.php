<?php
include("session.php");
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
        <h1>Historial de Clientes</h1>
        <form id="formulario_gestionarCliente" class="form" action="gestionarCliente.php" method="post">
            <div class="row">
                <div id="txtBuscarComentario" class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Buscar</label>
                    <input type="text" name="txtBuscar" class="form-control" placeholder="Buscar Cliente">
                </div>

                <div id="btnsListadoComentarios" class="col-md-4">
                    <button type="submit" name="btnBuscar_Comentario" class="btn_BuscarComentario">Buscar</button>
               
                    <button type="submit" <?php if (isset($_POST["Regresar_Menu"])) {
                                                header("Location: listadoClientes.php");
                                            }?> name="Regresar_Menu" class="btn_RegresarCrearComentarios">Regresar</button>
                </div>

                <div id="tabla">
                    <table class="table">
                        <thead>
                            <tr>
                                <th scope="col">Id</th>
                                <th scope="col">Nombre</th>
                                <th scope="col">Apellido</th>
                                <th scope="col">Documento</th>
                                <th scope="col">Correo</th>
                                <th scope="col">Dirección</th>
                                <th scope="col">Teléfono</th>
                                <th scope="col">Comentario</th>
                                <th scope="col">Fecha Gestion</th>
                                <th scope="col">Editar</th>
                                <th scope="col">Eliminar</th>

                            </tr>
                        </thead>
                        <tbody>
                            <?php
                            include "Leer_Comentario.php";

                            while ($fila = mysqli_fetch_assoc($result)) {
                                echo "
                                <tr>
                                    <td>{$fila['Id']}</td>
                                    <td>{$fila['Nombre_Cliente']}</td>
                                    <td>{$fila['Apellido_Cliente']}</td>
                                    <td>{$fila['Documento_Cliente']}</td>
                                    <td>{$fila['Correo_Cliente']}</td>
                                    <td>{$fila['Direccion_Cliente']}</td>
                                    <td>{$fila['Telefono_Cliente']}</td>
                                    <td>{$fila['Comentario_Cliente']}</td>
                                    <td>{$fila['Fecha_Comentario']}</td>
                                    <td><a href='modComentario.php?id=" . $fila['Id'] . "'><img src='./img/icons8-Edit-32.png' alt='Edit'></a></td>
                                    <td><a href='eliminar_Comentario.php?id=" . $fila['Id'] . "'><img src='./img/icons8-Trash-32.png' alt='Edit'></a></td>
                                </tr>";
                            }
                            ?>
                        </tbody>
                    </table>
                </div>
            </div>
        </form>
    </div>
</body>

</html>