<?php
include("session.php");
include("registrar_Usuario.php");
?>

<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Crear Usuario</title>
    <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="css/Usuario.css">
</head>

<body>
    <div id="crearUsuario" class="contenedor">
        <!-- Título del formulario -->
        <h1 id="tituloCrear">Crear Usuario</h1>
        <!-- Imagen del formulario -->
        <div id="logo" class="">
            <img class="imagen" src="img/logo.jpg" alt="">
        </div>
        <!-- Formulario para crear Usuarios -->
        <form id="formulario_crearUsuario" class="form" action="" method="post">
            <div class="row">
                <!-- Campo Nombre -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Nombre</label>
                    <input type="text" name="Nombre" id="Nombre" class="form-control" placeholder="Nombre" pattern="[a-zA-Z]+ && [' ']+]" required>
                </div>
                <!-- Campo Apellido -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Apellido</label>
                    <input type="text" name="Apellido" id="Apellido" class="form-control" placeholder="Apellido" pattern="[a-zA-Z]+ && [' ']+]" required>
                </div>
                <!-- Campo Número de documento -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Número de documento</label>
                    <input type="text" name="Documento" id="Documento" class="form-control" placeholder="Número de documento" required>
                </div>
                <!-- Campo Correo -->
                <div class="col-md-6">
                    <label for="inputEmail4" class="form-label">Correo</label>
                    <input type="email" class="form-control" name="Correo" id="Correo" placeholder="Correo" required>
                </div>
                <!-- Campo Dirección -->
                <div class="col-md-6">
                    <label for="inputAddress" class="form-label">Dirección</label>
                    <input type="text" class="form-control" name="Direccion" id="inputAddress" placeholder="Dirección" required>
                </div>
                <!-- Campo Teléfono -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Teléfono</label>
                    <input type="text" id="Telefono" class="form-control" name="Telefono" placeholder="Ingresa celular o fijo" title="Es necesario ingresar 7 o 10 digitos" pattern="[0-9]{7,10}" required>
                </div>
                <!-- Campo Usuario -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Usuario</label>
                    <input type="text" id="usuario" class="form-control" name="User" placeholder="Usuario" required>
                </div>
                <!-- Campo Clave -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Clave</label>
                    <input type="password" id="Clave" class="form-control" name="password" placeholder="Contraseña" required>
                </div>
                <!-- Campo Seleccionar Rol -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Rol</label>
                    <select class="form-select" name="Tipo_User" id="autoSizingSelect" required>
                        <option disabled selected value="">Seleccione</option>
                        <option value="Administrador">Administrador</option>
                        <option value="Vendedor">Vendedor</option>
                    </select>
                </div>
                <!-- Botones -->
                <div class="botones_Usuario">
                    <!-- Crear Usuario -->
                    <button type="submit" name="Crear_Usuario" class="btnCrearUsuario">Crear Usuario</button>
                    <!-- Regresar a Login -->
                    <button onclick="location.href='/choqmol/listadoUsuarios.php'" type="submit" name="Regresar" class="btnRegresarUsuario">Regresar</button>
                </div>
            </div>
        </form>
    </div>
</body>

</html>