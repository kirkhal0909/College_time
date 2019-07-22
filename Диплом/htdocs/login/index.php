<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/headers/header.php');
echo "<script>document.title = 'Авторизация'</script>";
?>
  
  <!--<link rel="stylesheet" type="text/css" href="login.css">-->  
  <div class="main-block form">
    <form>  
    	<ul class="tab-group">
            <li id="show-auth-button" class="tab active"><a onclick="showAuth()">Авторизация</a></li>
            <li id="show-reg-button" class="tab"><a onclick="showReg()">Регистрация</a></li>
        </ul>
    	<h1 id='login-form-caption'>Авторизация</h1>
      <input id='login' placeholder="Логин" type="text">   
      <p id='error-login' class='error-message'>Такой логин уже существует</p>
      <input id='pass' placeholder="Пароль" type="password">
      <input id='pass2' placeholder='Повтор пароля' type="hidden" name="pass2">
      <p id='error-pass2' class='error-message'>Пароли не совпадают</p>
      <input id='reg-code' placeholder='Код регистрации' type="hidden" name="code">
      <p id='error-msg' class='error-message'>Неправильный код регистрации</p>
      <p id='error-pass' class='error-message'>Неправильный логин или пароль</p>
      <button id='login-submit' onclick="doAuth()" type="button" class="button">
    		Войти
      </button>
    </form> 
  </div> 
<script src="login.js"> </script>



</body>

</html>
