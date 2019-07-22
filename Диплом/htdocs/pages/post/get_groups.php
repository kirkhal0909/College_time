<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/group_uniq.php');

//include_once($_SERVER['DOCUMENT_ROOT'].'/php/session.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/sort_rus.php');


/*$user = getAuthUser();
function checkNeedLogin($userNow){
	$needLogin = True;
	if(is_object($userNow))
	{		
		$needLogin = False;					
	}	
	return $needLogin;
}

$needLogin = checkNeedLogin($user);*/

include_once($_SERVER['DOCUMENT_ROOT'].'/php/need_login.php');

if((!$needLogin) && (isset($_POST['course']))){
	$UniqGroups = getUniqGroupsByCourse($_POST['course']);
	$UniqGroups = sort_array($UniqGroups,2);
	//print_r($UniqGroups);
	for($i = 0;$i<count($UniqGroups);$i++)
	{
		echo del_main_chars($UniqGroups[$i][0]).','.del_main_chars($UniqGroups[$i][1]).','.del_main_chars($UniqGroups[$i][2]).','. del_main_chars($UniqGroups[$i][3]->getID()).','. del_main_chars($UniqGroups[$i][3]->getInitials()).','. del_main_chars($UniqGroups[$i][3]->getFIO()).';';
	}	
	//echo "Some groups";
}

//echo $_POST['course'];