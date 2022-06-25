<?php
include("registrar_Cliente.php");
include("session.php");
?>
<!DOCTYPE html>
<html lang="es">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Crear Cliente</title>
    <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="css/Cliente.css">
</head>

<body>
    <div id="crearCliente" class="contenedor">
        <!-- Título de la página -->
        <h1>Crear Cliente</h1>
        <!-- Formulario para Crear Cliente -->
        <form id="formulario_crearCliente" class="form" action="" method="post">
            <div class="row">
                <!-- Campo Número de documento del cliente -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Número de documento</label>
                    <input type="text" name="Documento" class="form-control" placeholder="Número de documento" required>
                </div>
                <!-- Campo Nombre del cliente -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Nombre</label>
                    <input type="text" name="Nombre" class="form-control" placeholder="Nombre" pattern="[a-zA-Z]+ && [' ']+]" required>
                </div>
                <!-- Campo Apellidos cliente -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Apellido</label>
                    <input type="text" name="Apellido" class="form-control" placeholder="Apellido" pattern="[a-zA-Z]+ && [' ']+]" required>
                </div>
                <!-- Campo Correo del cliente -->
                <div class="col-md-6">
                    <label for="inputEmail4" class="form-label">Correo</label>
                    <input type="email" class="form-control" name="Correo" placeholder="Correo" required>
                </div>
                <!-- Campo Dirección del cliente -->
                <div class="col-md-6">
                    <label for="inputAddress" class="form-label">Dirección</label>
                    <input type="text" class="form-control" name="Direccion" placeholder="Dirección" required>
                </div>
                <!-- Campo teléfono del cliente -->
                <div class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Teléfono</label>
                    <input type="text" class="form-control" name="Telefono" placeholder="Ingresa celular o fijo" title="Es necesario ingresar 7 o 10 digitos" pattern="[0-9]{7,10}" required>
                </div>
                <!-- Select Tipo de cliente -->
                <div name="tipoCliente" class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Tipo de cliente</label>
                    <select required class="form-select" name="TipoCliente" id="autoSizingSelect" required>
                        <option disabled selected value="">Seleccione</option>
                        <option value="Mayorista">Mayorista</option>
                        <option value="De tal">De tal</option>
                    </select>
                </div>
                <!-- Select Estado del cliente -->
                <div name="estadoCliente" class="col-md-6">
                    <label class="visually-hidden" for="autoSizingSelect">Estado</label>
                    <select required class="form-select" name="EstadoCliente" id="autoSizingSelect">>
                        <option disabled selected value="">Seleccione</option>
                        <option value="Activo">Activo</option>
                        <option value="Inactivo">Inactivo</option>
                    </select>
                </div>
            </div>
            <!-- Botones -->
            <div>
                <!-- Crear Cliente -->
                <button type="submit" name="Crear_Cliente" class="btnCrear_Cliente">Guardar Cliente</button>
            </div>
            <!-- Regresar a Menu -->
            <div>
                <button onclick="location.href='/choqmol/listadoClientes.php'" type="submit" name="Regresar" class="btn_RegresarCrearCliente">Regresar</button>
            </div>
    </div>
    </form>
    </div>
</body>

</html>