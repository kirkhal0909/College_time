<?php
header('Content-Type: text/html; charset=utf-8');
if (isset($conn)==False)
    include_once($_SERVER['DOCUMENT_ROOT'].'/php/conn.php');

	class student
	{		
        const gender_boy = 1;
        const gender_girl = 2;

        private $id = '0';
		private $first_name = '';
        private $second_name = '';
        private $middle_name = '';
        private $phone = '';
        private $email = '';
        private $birth = '';
        private $group_unique_group_id = '0';
        private $more_info = '';
        private $gender = 1;

		//ИНИЦИАЛИЗАЦИЯ ОБЪЕКТА - student
		public function __construct($id_or_first_name = '',$group_unique_group_id = '',$gender = self::gender_boy,$second_name = '',$middle_name = '',$phone='',$email='',$birth='',$more_info = '') {	            
			if(is_numeric($id_or_first_name))
            {
                $this->id = $id_or_first_name;
                $sql = "SELECT * from students where student_id = '".$id_or_first_name."';";                
                $result = mysqli_query($GLOBALS['conn'],$sql); 
                $row = mysqli_fetch_assoc( $result);                
                $this->first_name = $row['student_name'];
                $this->second_name = $row['student_second_name'];
                $this->middle_name = $row['student_middle_name'];
                $this->phone = $row['student_phone'];
                $this->email = $row['student_email'];
                $this->birth = $row['student_birth'];   
                $this->group_unique_group_id = $row['group_unique_group_id'];                   
                $this->more_info = $row['student_more_info'];
                $this->gender = $row['student_gender'];
            } else {
                $this->group_unique_group_id = $group_unique_group_id;
                $this->first_name = $id_or_first_name;
                $this->second_name = $second_name;
                $this->middle_name = $middle_name;
                $this->phone = $phone;
                $this->email = $email;
                $this->birth = $birth;
                $this->more_info = $more_info;
                $this->gender = $gender;
            }
    	}

        public function setData($id,$group_unique_group_id,$first_name,$second_name,$middle_name,$phone,$email,$birth,$more_info,$gender)
        {
                $this->id = $id;
                $this->group_unique_group_id = $group_unique_group_id;
                $this->first_name = $first_name;
                $this->second_name = $second_name;
                $this->middle_name = $middle_name;
                $this->phone = $phone;
                $this->email = $email;
                $this->birth = $birth;
                $this->more_info = $more_info;
                $this->gender = $gender;
        }

        public function student_update($group_unique_group_id = '',$gender = '',$first_name='',$second_name = '',$middle_name = '',$phone='',$email='',$birth='',$more_info = ''){
                //echo $group_unique_group_id.' '.$gender.' '.$first_name.' '.$second_name.' '.$middle_name.' '.$phone.' '.$email.' '.$birth.' '.$more_info;
                if ($group_unique_group_id)
                    $this->group_unique_group_id = $group_unique_group_id;
                if ($gender)
                    $this->gender = $gender;
                if ($first_name)
                    $this->first_name = $first_name;
                if ($second_name)
                    $this->second_name = $second_name;
                if ($middle_name)
                    $this->middle_name = $middle_name;
                if ($phone)
                    $this->phone = $phone;
                if ($email)
                    $this->email = $email;
                if ($birth)
                    $this->birth = $birth;
                if ($more_info)
                    $this->more_info = $more_info;
                $sql = "UPDATE `students` SET `student_more_info`='". escape_sql($this->more_info) ."', `group_unique_group_id`='". escape_sql($this->group_unique_group_id) . "', `student_gender`='". escape_sql($this->gender) ."',`student_name`='". escape_sql($this->first_name) ."',`student_second_name`='". escape_sql($this->second_name) ."',`student_middle_name`='". escape_sql($this->middle_name) ."',`student_phone`='". escape_sql($this->phone) ."',`student_email`='". escape_sql($this->email) ."',`student_birth`='". escape_sql($this->birth) ."' WHERE student_id = '".escape_sql($this->id) ."';";                
                $result = mysqli_query($GLOBALS['conn'],$sql);
        }        

        public function setFirstName($first_name){
            $this->first_name = $first_name;
        }

        public function setSecondName($second_name){
            $this->second_name = $second_name;
        }

        public function setMiddleName($middle_name){
            $this->middle_name = $middle_name;
        }

        public function setPhone($phone){
            $this->phone = $phone;
        }

        public function setEmail($email){
            $this->email = $email;
        }

        public function setBirth($birth){
            $this->birth = $birth;
        }

        public function setMoreInfo($more_info)
        {
            $this->more_info = $more_info;
        }        

        public function queryUniqGoupInDB(){
            $inDB = False;
            $sql = "SELECT * FROM groups_now WHERE group_unique_group_id = '". escape_sql($this->group_unique_group_id) . "';";            
            if($result = mysqli_query($GLOBALS['conn'],$sql))
            {                
                if(mysqli_num_rows($result) > 0){
                    $inDB = True;
                }
            }
            return $inDB;
        }

    	public function student_create(){
            $created = False;   
            $this->id = -1;
            if($this->queryUniqGoupInDB())
            {
                $sql = "INSERT INTO `students`(`group_unique_group_id`,`student_name`, `student_second_name`, `student_middle_name`, `student_phone`, `student_email`, `student_birth`,`student_gender`) VALUES ('".escape_sql($this->group_unique_group_id)."','".escape_sql($this->first_name)."',
                    '".escape_sql($this->second_name)."',
                    '".escape_sql($this->middle_name)."',
                    '".escape_sql($this->phone)."',
                    '".escape_sql($this->email)."',
                    '".escape_sql($this->birth)."',
                    '".escape_sql($this->gender)."');"; 
                //echo $sql+' ';              
                if($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    $created = True;
                    $this->id = $GLOBALS['conn']->insert_id;
                }                
            }
            return $this->id;
        }

        public function student_delete(){
            $sql = "DELETE FROM students WHERE student_id = '".$this->id ."';";
            $result = mysqli_query($GLOBALS['conn'],$sql); 
        }

        public function getID(){
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
        }

    }

/*$name = "Иван";
$s_name = "Иванов";
$m_name = "Иванович";
for($i = 0;$i<10;$i++)
{
    $tmp = new student($name . $i,1,$s_name . $i,$m_name . $i);
    $tmp->student_create();
}*/
//echo $tmp->getUniqGroupID();
//echo $tmp->queryUniqGoupInDB();
//date('');
//$tmp = new student('1241qewr5','s','m','p','e','1999-10-1');
//$tmp = new student('1qewt');
//$tmp->student_create();
//$tmp->student_update("testName");
//$tmp->student_delete();