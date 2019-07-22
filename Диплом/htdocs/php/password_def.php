<?php
define('password_min_len',8);
define('alph_lower_case',"qwertyuiopasdfghjklzxcvbnm");
define('alph_upper_case',"QWERTYUIOPASDFGHJKLZXCVBNM");
define('alph_special_chars',"~`!@#$%^&*()_+=-[{}]:;\"'<>?,.\|/");
define('alph_numbers',"0123456789");

define('password_need_lower_case',false);
define('password_need_upper_case',false);	//QWERTYUIOPASDFGHJKLZXCVBNM
define('password_need_special_chars',false);	//~`!@#$%^&*()_+=-[{}]:;"'<>?,.\|/
define('password_need_numbers',false);



function passwordValidMessage($password)
{	
	$passwordValid = true;
	$msg = "";
	if(strlen($password)<password_min_len)
	{
		$passwordValid = False;
		$msg = $msg. "Минимальная длина пароля должна быть ".password_min_len." символов\n";
	}

	else if(password_need_lower_case)
		if(!passwordSomeInAlph($password,alph_lower_case))
		{
			$passwordValid = False;
			$msg = $msg. "В пароле должен быть хотя бы один символ из списка: ".alph_lower_case."\n";
		}
	else if(password_need_upper_case)
		if(!passwordSomeInAlph($password,alph_upper_case))
		{
			$passwordValid = False;
			$msg = $msg. "В пароле должен быть хотя бы один символ из списка: ".alph_upper_case."\n";
		}
	else if(password_need_special_chars)
		if(!passwordSomeInAlph($password,alph_special_chars))
		{
			$passwordValid = False;
			$msg = $msg. "В пароле должен быть хотя бы один символ из списка: ".alph_special_chars."\n";
		}
	else if(password_need_numbers)
		if(!passwordSomeInAlph($password,alph_numbers))
		{
			$passwordValid = False;	
			$msg = $msg. "В пароле должен быть хотя бы один символ из списка: ".alph_numbers."\n";
		}
	/*if($passwordValid)
	{
		$msg = "Пароль подходит!";
	}*/
	//echo "<script>alert('".str_replace("'","",$msg)."');</script>";
	return $msg;
}

function passwordSomeInAlph($password,$alph)
{
	$inAlph = False;	
	for($i=0;$i<strlen($password);$i++)
	{
		$ps = strpos($alph,$password[$i]);
		if($ps>=0)
		{
			if($ps!='')
			{			
				$inAlph = True;
				break;
			}
		}
	}
	return $inAlph;
}

function passwordIsValid($password){
	$passwordValid = True;	
	if(strlen($password)<password_min_len)
		$passwordValid = False;

	if(password_need_lower_case)
		if(!passwordSomeInAlph($password,alph_lower_case))
			$passwordValid = False;
	if(password_need_upper_case)
		if(!passwordSomeInAlph($password,alph_upper_case))
			$passwordValid = False;
	if(password_need_special_chars)
		if(!passwordSomeInAlph($password,alph_special_chars))
			$passwordValid = False;
	if(password_need_numbers)
		if(!passwordSomeInAlph($password,alph_numbers))
			$passwordValid = False;
	return $passwordValid;
}