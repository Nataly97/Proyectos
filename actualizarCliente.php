<?php
include "Conexion_BD.php";
include("session.php");

$id = $_GET["id"];
$clientes = "SELECT * FROM clientes WHERE Id_Cliente = '$id'";
?>
<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Modificar Cliente</title>
    <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="css/Cliente.css">
</head>

<body>
    <div id="modCliente" class="contenedor">
        <h1>Modificar Cliente</h1>
        <form id="formulario_modCliente" class="form" action="Procesar_Clientes.php" method="post">
            <div class="row">
               <!-- Código que trae a los campos del formulario los 
               datos del cliente consignados en la Base de Datos, para su modificación.   -->
               <?php
                $consulta = mysqli_query($conexion, $clientes);
                while ($row = mysqli_fetch_assoc($consulta)) {
                    echo "

                    
                    <input type='hidden' name='Id_Cliente' value='$row[Id_Cliente]'>
                    

                    <div class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Nombre</label>
                    <input type='text'name='Nombre' value='$row[Nombre]' class='form-control' placeholder='Nombre' pattern='[a-zA-Z]+ && [' ']+]' required>
                    </div>
                    
                    <div class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Apellido</label>
                    <input type='text' name='Apellido' value='$row[Apellido]' class='form-control' placeholder='Apellido' pattern='[a-zA-Z]+ && [' ']+]' required>
                    </div>

                    <div class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Número de documento</label>
                    <input type='text' name='Documento' value='$row[Num_Documento]' class='form-control' placeholder='Número de documento' required>

                    </div>
                    <div class='col-md-6'>
                    <label for='inputEmail4' class='form-label'>Correo</label>
                    <input type='email' class='form-control' name='Correo' value='$row[Correo]' placeholder='Correo' required>
                    </div>

                    <div class='col-md-6'>
                    <label for='inputAddress' class='form-label'>Dirección</label>
                    <input type='text' class='form-control' name='Direccion' value='$row[Direccion]' placeholder='Dirección' required>
                    </div>

                    <div class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Teléfono</label>
                    <input type='text' name='Telefono' value='$row[Telefono]' class='form-control'placeholder='Ingresa celular o fijo' title='Es necesario ingresar 7 o 10 digitos' pattern='[0-9]{7,10}' required>
                    </div>

                    <div id='tipoCliente' class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Tipo de cliente</label>
                    <select class='form-select' name='TipoCliente' id='autoSizingSelect' required >
                        <option selected value='$row[Tipo_Cliente]'>Seleccione</option>
                        <option value='Mayorista'>Mayorista</option>
                        <option value='De tal'>De tal</option>
                    </select>
                    </div>

                    <div id='estadoCliente' class='col-md-6'>
                    <label class='visually-hidden' for='autoSizingSelect'>Estado</label>
                    <select required class='form-select' name='EstadoCliente' id='autoSizingSelect' required>
                        <option selected value='$row[Estado_Cliente]'>Seleccione</option>
                        <option value='Activo'>Activo</option>
                        <option value='Inactivo'>Inactivo</option>
                    </select>
                    </div>
                ";
                }
                ?>
            </div>
            <br>
            <!-- Botón para guardar los cambios realizados en la información del cliente  -->
            <div>
                <button type="submit" name="Modificar_Cliente" class="btnModificar_Cliente">Guardar</button>
            </div>
        </form>
        <!-- Botón para devolverse a la página de Listado de Clientes  -->
        <div>
            <button onclick="location.href='/choqmol/listadoClientes.php'" type="submit" name="Cancelar" class="btn_RegresarCliente">Cancelar</button>
        </div>
    </div>

</body>

</html>