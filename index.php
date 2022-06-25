<!DOCTYPE html>
<html lang="en" dir="ltr">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>CHOQMOL</title>
  <link rel="stylesheet" type="text/css" href="css\bootstrap.min.css">
  <script type="text/javascript" src="js/bootstrap.min.js"></script>
  <script type="text/javascript" src="js/jquery-3.6.0.min.js"></script>
  <link rel="stylesheet" href="css/index.css">
</head>

<body>
  <div id="inicio" class="contenedor">
    <!-- Título de la ventana -->
    <h1>Bienvenido</h1>
    <!-- Imagen de la ventana Login -->
    <div id="logo" class="">
      <img class="imagen" src="img/logo.jpg" alt="">
    </div>
    <!-- Formulario login -->
    <form id="formulario_login" class="form" action="login.php" method="post">
      <!-- Campo Usuario -->
      <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Usuario</label>
        <input type="text" class="form-control" name="Usuario" id="id_Usuario" aria-describedby="emailHelp" required> 
      </div>
      <!-- Campo Clave o Contraseña -->
      <div class="mb-3">
        <label for="exampleInputPassword1" class="form-label">Clave</label>
        <input type="password" class="form-control" name="Clave" id="idClave" required>
      </div>
      <!-- Botones -->
      <div>
        <!-- Ingresar -->
        <button type="submit" name="Ingresar" class="btnIngresar">Ingresar</button>
        <!-- Crear Usuario -->
        <!-- <button onclick="location.href='/choqmol/crearUsuario.php'"type="submit" name="Crear_Usuario" id="idCrear_Usuario" >Crear Usuario</button> -->
      </div>
    </form>
  </div>
</body>

</html>