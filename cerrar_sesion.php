<!-- Código que permite que la sesión quede cerrada  -->
<?php
   session_start();
   
   if(session_destroy()) {
      header("Location: index.php");
   }
?>