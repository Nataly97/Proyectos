<?php
include("session.php");
?>

<!DOCTYPE html>
<html lang="es">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title></title>
  <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
  <script type="text/javascript" src="js/bootstrap.min.js"></script>
  <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
  <link rel="stylesheet" href="css/menu.css">

</head>

<body>
  <header>
    <div class="contenedor">
      <!-- Titulo -->
      <h1 class="tutuloMenu">CRM CHOQUETMOL</h1>
      <!-- Barra de nabegación -->
      <nav class="menu">
        <ul class="nav">
          <li><a class="nav-link" href="/choqmol/listadoClientes.php">Clientes</a>
          </li>
          <li><a class="nav-link" href="/choqmol/listadoUsuarios.php">Usuarios</a>
          </li>
        </ul>
        <!-- Botón de cerrar sesión -->
        <div class="Salir">
          <button onclick="location.href='/choqmol/cerrar_sesion.php'" type="submit" name="Cerrar_Sesion" id="Salir_Sistema" class="btn btn-primary">Cerrar Sesión</button>
        </div>
      </nav>
    </div>
  </header>

  <!-- Imagen página de inicio -->
  <div class="img">
    <img src="img/logo.jpg" alt="" height="500px" width="600px">
  </div>

</body>

</html>