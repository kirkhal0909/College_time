<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/session.php');

$phrase_to_reload = 'reload';
/*echo 123;
echo '<br>';
print_r($_POST);*/


//include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/user.php');		
if(isset($_GET['logout']))	//Выход из аккаунта
{
	destroySession();
	header('Location: '.'.././login');
}
else if(isset($_POST['code']))	//Регистрация
{	
	$code = $_POST['code'];
	include_once($_SERVER['DOCUMENT_ROOT'].'/php/password_def.php');	
	$registry_user = new user("","");
	if(!$registry_user->queryCodeInDB($code))
		{
			echo "Неправильный регистрационный код";
		} else
			{ 
				if(isset($_POST['login']))
				{
					$username = $_POST['login'];
					$registry_user->username = $username;
					if($registry_user->queryUserInDB()){
						echo "Логин пользователя уже занят";
					} else 
						{
								if(isset($_POST['pass'])&&isset($_POST['pass2']))
								{
									$password = $_POST['pass'];
									$password2 = $_POST['pass2'];									
									if($password!=$password2){
										echo "Пароли не совпадают";
									} else if (!passwordIsValid($password))
									{
										echo passwordValidMessage($password);
										//if(strlen($password)<password_min_len)
									} else{
										$registry_user->setPassword($password);
										$registry_user->user_createByCode($code);
										
										$login_user = new user($username,$password);
										setSession($login_user);
										echo $phrase_to_reload;
									}
								}
						}
				}
		}
}
else{	//Вход в аккаунт
	$username = $_POST['login'];
	$password = $_POST['pass'];
	$login_user = new user($username,$password);
	$goodLogin = False;		
	if($login_user->queryUserInDB())
	{
		//echo "User in DB\n";
		if($login_user->queryPasswordIsCorrect())
		{
			//echo "pass good\n";			
			setSession($login_user);
			$goodLogin = True;
			echo $phrase_to_reload;
			//header('Location: '.'.././');
		}
	}
	if(!$goodLogin)
	{		

		echo "<p>Неправильные данные!</p><a href='/login/?login=".$_POST['login']."'>Попробовать ещё раз</a>";
		//include_once($_SERVER['DOCUMENT_ROOT'].'/login/index.php');
	}
}
