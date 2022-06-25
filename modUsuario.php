<?php
include "Conexion_BD.php";
include("session.php");
$id = $_GET["id"];
$sql = "SELECT * FROM usuarios WHERE Id_Usuario = '$id'";
?>

<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Modificar Usuario</title>
    <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="css/Usuario.css">
</head>

<body id="bodymodUsuario">
    <div id="modUsuario" class="contenedor">
        <h1>Modificar Usuario</h1>
        <form id="formulario_modUsuario" class="form" action="procesar_Usuario.php" method="post">
            <div class="row">

            <!-- Código que realiza consulta en Base Datos y trae a los campos del formulario, cada uno de los 
                datos requeridos para su posterior modificación. -->
                <?php
                $consulta = mysqli_query($conexion, $sql);
                while ($row = mysqli_fetch_assoc($consulta)) {
                    echo "

                    <input type='hidden' name='Id_User' value='$row[Id_Usuario]'>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Nombre</label>
                        <input type='text' name='Nombre_User' value='$row[Nombre_Usuario]' class='form-control' placeholder='Nombre' pattern='[a-zA-Z]+ && [' ']+]' required>
                    </div>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Apellido</label>
                        <input type='text' name='Apellido_User' value='$row[Apellido_Usuario]' class='form-control' placeholder='Apellido' pattern='[a-zA-Z]+ && [' ']+]' required>
                    </div>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Número de documento</label>
                        <input type='text' name='Documento_User' value='$row[Documento_Usuario]' class='form-control' placeholder='Número de documento' required>
                    </div>

                    <div class='col-md-6'>
                        <label for='inputEmail4' class='form-label'>Correo</label>
                        <input type='email' class='form-control' name='Correo_User' value='$row[Correo_Usuario]' placeholder='Correo' required>
                    </div>

                    <div class='col-md-6'>
                        <label for='inputAddress' class='form-label'>Dirección</label>
                        <input type='text' class='form-control' name='Direccion_User' value='$row[Direccion_Usuario]' placeholder='Dirección' required>
                    </div>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Teléfono</label>
                        <input type='text' name='Telefono_User' value='$row[Telefono_Usuario]' class='form-control' placeholder='Teléfono' title='Es necesario ingresar 7 o 10 digitos' pattern='[0-9]{7,10}' required>
                    </div>

                    <div class='col-md-6'>
                        <label class='visually-hidden' for='autoSizingSelect'>Usuario</label>
                        <input type='text' name='User' value='$row[User]' class='form-control' placeholder='Usuario' required>
                    </div>

                    <div class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Clave</label>
                    <input type='password' name='Password_User' value='$row[Password_User]' class='form-control' placeholder='Contraseña' required>
                </div>

                    <div id='tipoCliente' class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Tipo de Rol</label>
                    <select required class='form-select' name='Tipo_Rol' id='autoSizingSelect'>
                        <option selected value=''>Seleccione</option>
                        <option value='Administrador'>Administrador</option>
                        <option value='Vendedor'>Vendedor</option>
                    </select>
                    </div>
                ";
                }
                ?>


                <!-- Botones -->
                <div class="col-md-5">
                    <!-- Modificar Usuario -->
                    <button type="submit" name="Modificar_Usuario" class="btnModUsuario">Guardar Cambios</button>
                </div>
            </div>
        </form>
        <div>
            <button onclick="location.href='/choqmol/listadoUsuarios.php'" type="submit" name="Regresar" class="btn_RegresarUsuario">Regresar</button>
        </div>
    </div>
</body>

</html>