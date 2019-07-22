<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/group.php');

include_once($_SERVER['DOCUMENT_ROOT'].'/php/session.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/sort_rus.php');


$user = getAuthUser();
function checkNeedLogin($userNow){
	$needLogin = True;
	if(is_object($userNow))
	{		
		$needLogin = False;					
	}	
	return $needLogin;
}

$needLogin = checkNeedLogin($user);
if((!$needLogin) && (isset($_POST['course']))){
	$Groups = getUniqGroupsByCourse();
	/*$Groups = sort_array($UniqGroups,2);
	//print_r($UniqGroups);
	for($i = 0;$i<count($UniqGroups);$i++)
	{
		echo $UniqGroups[$i][0].','.$UniqGroups[$i][1].','.$UniqGroups[$i][2].','. $UniqGroups[$i][3]->getID().','. $UniqGroups[$i][3]->getInitials().','. $UniqGroups[$i][3]->getFIO().';';
	}	*/
	//echo "Some groups";
}

//echo $_POST['course'];