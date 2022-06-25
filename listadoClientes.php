<?php
include("session.php");
?>


<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lista de Cliente</title>
    <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="css/Cliente.css">
</head>

<body>
    <div id="modCliente" class="contenedor">
        <h1>Listado de Clientes</h1>
        <form id="formulario_modCliente" class="form" action="listadoClientes.php" method="post">
            <div  class="row">
                <div id="buscarClientes" class="col-md-6">
                    <!-- Campo buscar o filtrar cliente -->
                    <label class="visually-hidden" for="autoSizingSelect">Buscar</label>
                    <input type="text" id="txtBuscar" name="Buscar" class="form-control" placeholder="Buscar Cliente">
                </div>
                <div id="btnsClientes" class="col-md-5">
                    <!-- Botón Buscar o filtrar Cliente -->
                    <button type="submit" name="btnBuscar" class="btn_Buscar">Buscar</button>
                    <!-- Botón Crear Cliente -->
                    <button type="submit" name="btnCrearCliente" class="btn_CrearCliente"><a href="crearCliente.php">Crear Cliente</a></button>
                    <!-- Botón atrás -->
                    <button type="submit" name="btnHistorial" class="btnHistorialClientes"><a href="gestionarCliente.php">Historial de Gestión</button>
                    <!-- Botón atrás -->
                    <button type="submit" name="btnAtras" class="btnAtras_Listado"><a href="menu.php">Atrás</button>
                </div>
                <!-- Tabla de listado de clientes -->
                <div id="tabla">
                    <table class="table">
                        <thead>
                            <tr>
                                <th scope="col">Id</th>
                                <th scope="col">N. Documento</th>
                                <th scope="col">Nombre</th>
                                <th scope="col">Apellido</th>
                                <th scope="col">Correo</th>
                                <th scope="col">Direccion</th>
                                <th scope="col">Telefono</th>
                                <th scope="col">Tipo Cliente</th>
                                <th scope="col">Estado</th>
                                <th scope="col">Editar</th>
                                <th scope="col">Eliminar</th>
                                <th scope="col">Nota</th>

                            </tr>
                        </thead>
                        <!-- Código php para invocar la consulta realizada a la base de datos de la tabla de clientes-->
                        <tbody>
                            <?php
                            include "Leer.php";

                            while ($fila = mysqli_fetch_assoc($result)) {
                                echo "
                                <tr>
                                    <td>{$fila['Id_Cliente']}</td>
                                    <td>{$fila['Num_Documento']}</td>
                                    <td>{$fila['Nombre']}</td>
                                    <td>{$fila['Apellido']}</td>
                                    <td>{$fila['Correo']}</td>
                                    <td>{$fila['Direccion']}</td>
                                    <td>{$fila['Telefono']}</td>
                                    <td>{$fila['Tipo_Cliente']}</td>
                                    <td>{$fila['Estado_Cliente']}</td>
                                    <td><a href='actualizarCliente.php?id=" . $fila['Id_Cliente'] . "'><img src='./img/icons8-Edit-32.png' alt='Edit'></a></td>
                                    <td><a href='BorrarCliente.php?id=" . $fila['Id_Cliente'] . "'><img src='./img/icons8-Trash-32.png' alt='Edit'></a></td>
                                    <td><a href='crearComentario.php?id=" . $fila['Id_Cliente'] . "'><img src='./img/icons8-nota-48.png' alt='Edit'></a></td>
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