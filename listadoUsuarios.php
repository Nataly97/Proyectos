<?php
include("session.php");
?>

<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lista de Usuarios</title>
    <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="css/Usuario.css">
</head>

<body>
    <div id="" class="contenedor">
        <h1>Listado de Usuarios</h1>
        <form id="formulario_listadoUsuarios" class="form" action="" method="post">
            <div class="row">
                <div id="txtBuscarUsuarios" class="col-md-6">
                    <!-- Campo buscar o filtrar Usuario -->
                    <label class="visually-hidden" for="autoSizingSelect">Buscar</label>
                    <input type="text" name="TxtBuscar_Usuario" class="form-control" placeholder="Buscar Usuario">
                </div>
                <div id="btnsListaUsuarios" class="col-md-4">
                    <!-- Botón Buscar o filtrar Usuario -->
                    <button type="submit" name="btnBuscar" class="btn_Buscar">Buscar</button>
                    <!-- Botón Crear Usuario -->
                    <button type="submit" <?php if (isset($_POST["btnCrearUsuario"])) {
                                                header("Location: crearUsuario.php");
                                            } ?> name="btnCrearUsuario" class="btn_CrearUsuario">Crear Usuario</button>
                    <!-- Botón atrás -->
                    <button type="submit" <?php if (isset($_POST["btnAtras"])) {
                                                header("Location: menu.php");
                                            } ?> name="btnAtras" class="btnAtras_Listado">Atrás</button>
                </div>
                <!-- Tabla de listado de Usuarios -->
                <div id="tabla">
                    <table class="table">
                        <thead>
                            <tr>
                                <th scope="col">Id</th>
                                <th scope="col">Nombre</th>
                                <th scope="col">Apellido</th>
                                <th scope="col">Documento</th>
                                <th scope="col">Correo</th>
                                <th scope="col">Direccion</th>
                                <th scope="col">Telefono</th>
                                <th scope="col">Usuario</th>
                                <th scope="col">Clave</th>
                                <th scope="col">Rol</th>
                                <th scope="col">Editar</th>
                                <th scope="col">Eliminar</th>

                            </tr>
                        </thead>
                        <!-- Código php para invocar la consulta realizada a la base de datos de la tabla de usuarios-->
                        <tbody>
                            <?php
                            include "Leer_Usuarios.php";

                            while ($fila = mysqli_fetch_assoc($result)) {
                                echo "
                                <tr>
                                    <td>{$fila['Id_Usuario']}</td>
                                    <td>{$fila['Nombre_Usuario']}</td>
                                    <td>{$fila['Apellido_Usuario']}</td>
                                    <td>{$fila['Documento_Usuario']}</td>
                                    <td>{$fila['Correo_Usuario']}</td>
                                    <td>{$fila['Direccion_Usuario']}</td>
                                    <td>{$fila['Telefono_Usuario']}</td>
                                    <td>{$fila['User']}</td>
                                    <td>{$fila['Password_User']}</td>
                                    <td>{$fila['RolUser']}</td>
                                    <td><a href='modUsuario.php?id=" . $fila['Id_Usuario'] . "'><img src='./img/icons8-Edit-32.png' alt='Edit'></a></td>
                                    <td><a href='eliminar_Usuario.php?id=" . $fila['Id_Usuario'] . "'><img src='./img/icons8-Trash-32.png' alt='Edit'></a></td>
                                </tr>";
                            }
                            ?>
                        </tbody>
                    </table>
                </div>
        </form>
    </div>

</body>

</html>