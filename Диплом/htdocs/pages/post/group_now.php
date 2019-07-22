<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/need_login.php');


function accessDelete($group_now_id){
	$accessDel = False;
	$status = $GLOBALS['status'];
	$user = $GLOBALS['user'];
	if($status==user::status_admin)
		{$accessDel = True;}
	else if ($status>0)
	{
		$user->getTeacher();
		if($user->teacher->teacherIsCurator($group_now_id)){
			$accessDel = True;
		}				
	}				
	return $accessDel;
}

//print_r($_POST);
if((!$needLogin) && (isset($_POST['method'])))
{
	//echo "loginned";	
	if($status>0){//if status not banned user registered
		include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/group_uniq.php');
		if( (isset($_POST['group_id'])) && (isset($_POST['group_by_number'])) && (isset($_POST['group_start_year'])) && (isset($_POST['group_end_year'])))
		{
			if($_POST['method'] == 'create')
			{		
				$user->getTeacher();				
				if($user->teacher->createCuratorGroup($_POST['group_id'],$_POST['group_by_number'],$_POST['group_start_year'],$_POST['group_end_year']))
				{
					echo "True";
				}
				else echo "False";
			} 
		} else if (($_POST['method'] == 'delete') && (isset($_POST['group_uniq_id'])) )
		{
			$delete_group = new group_uniq($_POST['group_uniq_id']);
			//$delete_group->getUniq_groups();
			if(accessDelete($_POST['group_uniq_id']))
			{
				if($delete_group->groupUniq_delete())
					{echo "True";}
				else {echo "Группу нельзя удалить. Из группы необходимо удалить всех студентов";}
			} else{echo "Нет доступа!";}
		} else if (($_POST['method'] == 'getFreeNumber') && isset($_POST['group_id']))
		{
			$new_group = new group_uniq();
			$new_group->setGroupID(($_POST['group_id']));
			$new_group->findNumberGroup();
			echo $new_group->getGroupNumber();
		} else if (($_POST['method']=='getCourses'))
		{
			$courses = queryCountCourses();
			foreach ($courses as $course => $count)
			{
				echo $course.','.$count.';';
			}			
		} else if (($_POST['method']=='getStudents') && isset($_POST['group_now_id']))
		{
			$group = new group_uniq($_POST['group_now_id']);
			$group->findStudents();
			for($i=0;$i<count($group->students);$i++)
			{
				$student = $group->students[$i];
				$gender = 'boy';
				if($student->getGender()==$student::gender_girl)
				{
					$gender = 'girl';
				}
				echo $student->getID().','.$student->getFirst_name().','.$student->getSecond_name().','.$student->getMiddle_name().','.$gender.','.$student->getPhone().','.$student->getEmail().','.$student->getBirth().','.$student->getMoreInfo().';';
			}
		} else if (($_POST['method']=='accessDelete') && isset($_POST['group_now_id']))
		{
			if(accessDelete($_POST['group_now_id']))
				{echo "True";}
			else {echo "False";}
		}else if (($_POST['method']=='studentDelete') && isset($_POST['group_now_id']) && isset($_POST['student_id']))
		{
			if(accessDelete($_POST['group_now_id']))
			{
				$del_student = new student($_POST['student_id']);
				$del_student->student_delete();
				echo "True";
			} else {echo "False";}
		}	else if (($_POST['method']=='studentCreate') && isset($_POST['group_now_id']) && isset($_POST['student_gender']) && isset($_POST['student_second_name']) && isset($_POST['student_name']) && isset($_POST['student_middle_name']) && isset($_POST['student_birth']) && isset($_POST['student_phone']) && isset($_POST['student_email']) && isset($_POST['student_info']))
		{			
			if(accessDelete($_POST['group_now_id']))
			{				
				$group_to_add = new group_uniq($_POST['group_now_id']);
				$gender = student::gender_boy;				
				if ($_POST['student_gender'] == 'girl')					
					$gender = student::gender_girl;				
				$student_id = $group_to_add->student_create($_POST['student_name'],$gender,$_POST['student_second_name'],$_POST['student_middle_name'],$_POST['student_birth'],$_POST['student_info'],$_POST['student_phone'],$_POST['student_email']);
				//($first_name,$gender = student::gender_boy,$second_name,$middle_name,$birth,$more_info='',$phone='',$email='')
				echo "True,".$student_id;
			} else {echo "False";}
		} else if (($_POST['method']=='studentEdit')  && isset($_POST['group_now_id']) && isset($_POST['student_gender']) && isset($_POST['student_second_name']) && isset($_POST['student_name']) && isset($_POST['student_middle_name']) && isset($_POST['student_birth']) && isset($_POST['student_phone']) && isset($_POST['student_email']) && isset($_POST['student_info']) && isset($_POST['student_id']))
		{
			$student = new student($_POST['student_id']);
			$grp_uniq_id = $student->getUniqGroupID();
			if(accessDelete($grp_uniq_id))
			{
				$gender = student::gender_boy;				
				if ($_POST['student_gender'] == 'girl')					
					$gender = student::gender_girl;	
//($group_unique_group_id = '',$gender = '',$first_name='',$second_name = '',$middle_name = '',$phone='',$email='',$birth='',$more_info = ''){  				
				$student->student_update($_POST['group_now_id'],$gender,$_POST['student_name'],$_POST['student_second_name'],$_POST['student_middle_name'],$_POST['student_phone'],$_POST['student_email'],$_POST['student_birth'],$_POST['student_info']);
			}
		} else if (($_POST['method']=='studentGet') && isset($_POST['student_id']))
		{
			$student = new student($_POST['student_id']);
			$gender = 'boy';
			if($student->getGender()==student::gender_girl)
				$gender = 'girl';
			echo $student->getFirst_name().';'.$student->getSecond_name().';'.$student->getMiddle_name().';'.$student->getPhone().';'.$student->getEmail().';'.$student->getBirth().';'.$student->getMoreInfo().';'.$gender;
			/*public function getID(){
            return $this->id;
        }

        public function getFirst_name(){
            return $this->first_name;
        }

        public function getSecond_name(){
            return $this->second_name;
        }

        public function getMiddle_name(){
            return $this->middle_name;
        }

        public function getPhone(){
            return $this->phone;
        }

        public function getEmail(){
            return $this->email;
        }

        public function getBirth(){
            return $this->birth;
        }

        public function getUniqGroupID(){
            return $this->group_unique_group_id;
        }

        public function getMoreInfo()
        {
            return $this->more_info;
        }

        public function getGender()
        {
            return $this->gender;
        }*/
		}
	} else echo "Access denied!";
}