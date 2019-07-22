<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/session.php');


$user = getAuthUser();	
//getAllUsers();
//$user->user_ChangePassword("pass1");

function checkNeedLogin($userNow){
	$needLogin = True;
	if(is_object($userNow))
	{		
		$needLogin = False;					
	}	
	return $needLogin;
}

const login_page = 'login';
const registry_page = 'loginregistry';

$needLogin = checkNeedLogin($user);

if(!$needLogin)
	$status = $user->getStatus();

$URInow = str_replace("/","",$_SERVER['REQUEST_URI']);