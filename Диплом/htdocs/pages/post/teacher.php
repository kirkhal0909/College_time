<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/need_login.php');

//print_r($_POST);
if((!$needLogin) && (isset($_POST['method'])))
{
	//echo "loginned";	
	if($status>0){//if status not banned user registered
		include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/teacher.php');	
			if( (isset($_POST['teacher_name'])) && (isset($_POST['teacher_second_name'])) && (isset($_POST['teacher_middle_name'])))
			{			
				if(($_POST['method'] == 'create') && ($user::status_admin))
				{		
					$new_teacher = new teacher($_POST['teacher_name'],$_POST['teacher_second_name'],$_POST['teacher_middle_name']);
					$reg_code = $new_teacher->teacher_create();
					if($reg_code)
					{
						echo $reg_code.','.$new_teacher->getId();
					}
					else echo "False";
				} 
			}
			else if(($_POST['method'] == 'getUsers') && ($user::status_admin))
				{		
					//echo "GOOD";
					include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/user.php');
					$users = findUsersAndTeachers();
					for ($i=0;$i<count($users);$i++)
					{						
						echo $users[$i]->getID().','.$users[$i]->getUsername();
						if ($users[$i]->teacher)
							echo ','.$users[$i]->teacher->getID().','.$users[$i]->teacher->getFIO();
						echo ';';
					}
				} else if(($_POST['method'] == 'getNewTeachers') && ($user::status_admin))
				{		
					include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/user.php');
					$teachers = findNewTeachers();
					for ($i=0;$i<count($teachers);$i++)
					{
						echo $teachers[$i]->getID().','.$teachers[$i]->getFIO().','.$teachers[$i]->getRegistrationCode().';';
					}
				} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
				{
					$remove_teacher = new teacher($_POST['teacher_id']);
					$remove_teacher->teacher_delete();
					echo "True";
				}
		}	
}