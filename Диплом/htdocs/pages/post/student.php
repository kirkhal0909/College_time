<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/need_login.php');

//print_r($_POST);
if((!$needLogin) && (isset($_POST['method'])))
{
	//echo "loginned";	
	if($status>0){//if status not banned user registered
		include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/teacher.php');							
				if(($_POST['method'] == 'create') && (isset($_POST['group_uniq_id'])) && (isset($_POST['student_first_name'])) && (isset($_POST['student_middle_name'])) && (isset($_POST['student_second_name'])) && (isset($_POST['student_gender'])) && (isset($_POST['student_birth'])) && (isset($_POST['student_phone'])) && (isset($_POST['student_email'])) && (isset($_POST['student_more_info'])))
				{		
					$user->getTeacher();
					$created = $user->teacher->addStudentToCuratorGroup($_POST['group_uniq_id'],$_POST['student_first_name'],$_POST['student_gender'],$_POST['student_second_name'],$_POST['student_middle_name'],$_POST['student_birth'],$_POST['student_more_info'],$_POST['student_phone'],$_POST['student_email']);
					if($created)
					{
						echo "True";
					}
					else echo "False";
				} 			
		}	
}