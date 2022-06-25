<!-- Código que permite abrir una sesión para ingresar al menú principal del programa.-->
<?php
session_start();
   
if(!isset($_SESSION['User'])){
	header("location:index.php");
	}
?>