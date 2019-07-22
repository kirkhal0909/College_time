<?php

//include_once($_SERVER['DOCUMENT_ROOT'].'/php/headers/header.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/need_login.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/password_def.php');



$user->setPassword($_POST['pass']);
//echo $user->getPasswordHash();
if($user->queryPasswordIsCorrect())//Если правильный пароль
{		
	if(isset($_POST['phone']))
		$user->teacher->setPhone($_POST['phone']);
	if(isset($_POST['email']))
		$user->teacher->setEmail($_POST['email']);
	$user->teacher->teacher_update();

	$passUpdated = False;
	if($_POST['pass-new']==$_POST['pass-new2'])
	{		
		if (passwordIsValid($_POST['pass-new']))
		{
			$user->user_ChangePassword($_POST['pass-new']);
			$passUpdated = True;
		}
		//else {				}
	}
	if($_POST['pass-new'])
	{
		if(!$passUpdated)
		{
			if($_POST['pass-new']!=$_POST['pass-new2'])
			{
				echo "Пароли не совпадают!";// window.location.replace('/?page=options');</script>";
			} else{				
				echo passwordValidMessage($_POST['pass-new']);				
				//echo "<script>alert('Пароль должен состоять хотябы из 8 символов'); window.location.replace('/?page=options');</script>";
			}
		} else{
			echo 'Пароль успешно изменён!';// window.location.replace('/?page=options');</script>";
		}
	}	//echo "<script>window.location.replace('/?page=options');</script>";
} else
{	
	echo 'Неправильный пароль!';//window.location.replace('/?page=options');</script>";
	//header('Location: '.'.././'); 
}
//echo "12412";
//print_r($_POST);
//echo $_POST['year'];