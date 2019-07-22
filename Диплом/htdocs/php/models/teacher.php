<?php
if (isset($conn)==False)
    include_once($_SERVER['DOCUMENT_ROOT'].'/php/conn.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/group_uniq.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/group.php');

	class teacher
	{		        
        private $id = '0';
		private $first_name = '';
        private $second_name = '';
        private $middle_name = '';
        private $phone = '';
        private $email = '';
        private $birth = '';  
        private $registration_code = '';      
        public $curator_groups = [];

		//ИНИЦИАЛИЗАЦИЯ ОБЪЕКТА - teacher
        //$obj = new teacher(id); - Загружает учителя из БД
        //$obj = new teacher('name',[...]); - создаёт новый экземпляр, которого нет в БД
		public function __construct($id_or_first_name='',$second_name = '',$middle_name = '',$phone='',$email='',$birth='') {	
			if(is_numeric($id_or_first_name))
            {
                $this->id = $id_or_first_name;
                $sql = "SELECT * from teachers where teacher_id = '".escape_sql($id_or_first_name)."';";                
                if($result = mysqli_query($GLOBALS['conn'],$sql))
                { 
                    $row = mysqli_fetch_assoc( $result);                
                    $this->first_name = $row['teacher_name'];
                    $this->second_name = $row['teacher_second_name'];
                    $this->middle_name = $row['teacher_middle_name'];
                    $this->phone = $row['teacher_phone'];
                    $this->email = $row['teacher_email'];
                    $this->birth = $row['teacher_birth'];  
                }
                $sql = "SELECT account_registration_code from accounts_registration WHERE account_link_to_teacher_id = '".escape_sql($this->id)."';";
                if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    $row = $result->fetch_row();
                    $this->registration_code = $row[0];
                }
            } else {                
                $this->first_name = $id_or_first_name;
                $this->second_name = $second_name;
                $this->middle_name = $middle_name;
                $this->phone = $phone;
                $this->email = $email;
                $this->birth = $birth;
            }
    	}

        private function createRegistrationCode(){
            $alph = "23456789qwertyupasdfghjkzxcvbnmQWERTYUPASDFHGJKLZXCVBNM";
            srand(time()*1.1232512);
            $registration_code_length = 16;
            $code = '';
            for($i=0;$i<$registration_code_length;$i++)
            {
                $code = $code . $alph[rand() % strlen($alph)];
            }
            return $code;
        }

        public function findCuratorGroups(){
            if(empty($this->curator_groups))
            {
                $sql = "SELECT * from groups_curators where teacher_id = '".escape_sql($this->id)."';";
                if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    while($row = mysqli_fetch_assoc( $result))
                    {
                        //$sql = "SELECT * from groups where group_id = '".escape_sql($this->id)."';";
                        //$result2 = mysqli_query($GLOBALS['conn'],$sql)
                        //$row = mysqli_fetch_assoc( $result)
                        $sql = "SELECT * from groups_now where group_unique_group_id = '".escape_sql($row['group_unique_group_id'])."';";                        
                        $result2 = mysqli_query($GLOBALS['conn'],$sql);
                        $row2 = mysqli_fetch_assoc( $result2);                        
                        $group = new group($row2["group_id"]);
                        //print_r($group);

                        $curator_group = new group_uniq();
                        //$group_unique_group_id,$group_id,$group_by_number,$group_start_year,$group_end_year,$group_short_name,$group_full_name
                        //print_r($group);
                        $curator_group->setData($row2["group_unique_group_id"],$row2["group_id"],$row2["group_by_number"],$row2["group_start_year"],$row2["group_end_year"]);
                        array_push($this->curator_groups, $curator_group);
                    }
                    //print_r($this->students);                    
                }
            }
        }

        public function teacherIsCurator($group_now_id){
            $isCurator = False;
            $this->findCuratorGroups();
            //print($this->getID());
            //print_r($this->curator_groups);
            for($i=0;$i<count($this->curator_groups);$i++)
            {
                if($this->curator_groups[$i]->getID()==$group_now_id)
                {                    
                    $isCurator = True;
                    break;
                }
            }
            return $isCurator;
        }

        public function addStudentToCuratorGroup($group_uniq_id,$first_name,$gender = student::gender_boy,$second_name,$middle_name,$birth,$more_info='',$phone='',$email=''){
            $status = False;
            for($i=0;$i<count($this->curator_groups);$i++)
            {
                if($this->curator_groups->getID()==$group_uniq_id)
                {
                    $status = $this->curator_groups->student_create($first_name,$gender,$second_name,$middle_name,$birth,$more_info,$phone,$email);
                    break;
                }
            }
            return $status;
        }

        public function createCuratorGroup($group_id,$group_by_number,$group_start_year='',$group_end_year=''){
            $created = False;
            $curator_group = new group_uniq();                    
            $curator_group->setNumberGroup($group_by_number);
            $curator_group->setGroupID($group_id);
            $curator_group->setGroupStartYear($group_start_year);
            $curator_group->setGroupEndYear($group_end_year);
            //print_r($curator_group);
            //$curator_group->setGroupID($group_id);
            /*if($group_start_year)
                $curator_group->setGroupStartYear($group_start_year);
            if($group_end_year)
                $curator_group->setGroupEndYear($group_end_year);*/
            if($curator_group->groupUniq_create())
            {
                array_push($this->curator_groups,$curator_group);
                $sql = "INSERT INTO `groups_curators`(`group_unique_group_id`, `teacher_id`) VALUES ('".escape_sql($curator_group->getID())."','".escape_sql($this->id)."');";                
                $result = mysqli_query($GLOBALS['conn'],$sql);
                $created = True;

                //echo($curator_group->getID().' '.$this->id);
            }
            return $created;
        }

        public function setData($id,$first_name,$second_name,$middle_name,$phone,$email,$birth,$registration_code){
            $this->id = $id;
            $this->first_name = $first_name;
            $this->$second_name = $second_name;
            $this->$middle_name = $middle_name;
            $this->$phone = $phone;
            $this->$email = $email;
            $this->$birth = $birth;
            $this->$registration_code = $registration_code;
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

        public function teacher_update($first_name='',$second_name = '',$middle_name = '',$phone='',$email='',$birth=''){
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
                $sql = "UPDATE `teachers` SET `teacher_name`='". escape_sql($this->first_name) ."',`teacher_second_name`='". escape_sql($this->second_name) ."',`teacher_middle_name`='". escape_sql($this->middle_name) ."',`teacher_phone`='". escape_sql($this->phone) ."',`teacher_email`='". escape_sql($this->email) ."',`teacher_birth`='". escape_sql($this->birth) ."' WHERE teacher_id = '".escape_sql($this->id) ."';";
                $result = mysqli_query($GLOBALS['conn'],$sql); 
        }        

    	public function teacher_create(){               
            $sql = "INSERT INTO `teachers`(`teacher_name`, `teacher_second_name`, `teacher_middle_name`, `teacher_phone`, `teacher_email`, `teacher_birth`) VALUES ('".escape_sql($this->first_name)."',
                '".escape_sql($this->second_name)."',
                '".escape_sql($this->middle_name)."',
                '".escape_sql($this->phone)."',
                '".escape_sql($this->email)."',
                '".escape_sql($this->birth)."');";               
            $result = mysqli_query($GLOBALS['conn'],$sql); 
            $this->id = $GLOBALS['conn']->insert_id;

            $doNewCode = True;
            $code = $this->createRegistrationCode();            
            while ($doNewCode){                
                $sql = "SELECT * from accounts_registration where account_registration_code = '".escape_sql($code)."';";
                if($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    if(mysqli_num_rows($result) == 0)
                    {                 
                      $doNewCode = False;
                    } else
                    {
                        $code = $this->createRegistrationCode();
                    }
                }
            }
            $sql = "INSERT INTO `accounts_registration`(`account_registration_code`, `account_link_to_teacher_id`) VALUES ('".escape_sql($code)."','".escape_sql($this->id)."')";
            $result = mysqli_query($GLOBALS['conn'],$sql);
            $this->registration_code = $code;
            return $this->registration_code;
        }

        public function teacher_delete(){
            $sql = "SELECT * FROM `bindings_accounts` WHERE teacher_id = '".$this->id ."';";            
            if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    $row = mysqli_fetch_assoc( $result);
                    $acc_id = $row['account_id'];
                    $sql = "SELECT * FROM `accounts` WHERE `account_id` = '".$acc_id."';";
                    if ($result = mysqli_query($GLOBALS['conn'],$sql))
                    {
                        $row = mysqli_fetch_assoc($result);
                        $acc_name = $row['account_username'];
                        $sql = "DELETE FROM `sessions` WHERE `account_username` = '".$acc_name."';";
                    }
                    $sql = "DELETE FROM `accounts` WHERE `account_id` = '".$acc_id."';";
                    //echo $sql;
                    $result = mysqli_query($GLOBALS['conn'],$sql);
                }            
                //echo "<br><hr>".$sql;
            $sql = "DELETE FROM teachers WHERE teacher_id = '".$this->id ."';";
            $result = mysqli_query($GLOBALS['conn'],$sql);            
            $sql = "DELETE FROM `accounts_registration` WHERE `account_link_to_teacher_id` = '".$this->id ."';";
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

        public function getFIO(){
            $FIO = '';
            if($this->second_name){
                $FIO = $this->second_name.' ';
            }
            if($this->first_name)
            {
                $FIO = $FIO.$this->first_name.' ';            
            }
            $FIO = $FIO.$this->middle_name;
            return $FIO;
        }

        public function getInitials(){
            $Initials = $this->second_name;
            try{
                if($this->first_name)
                    $Initials = $Initials ." " . $this->first_name[0].$this->first_name[1].".";
                if($this->middle_name)
                $Initials = $Initials ." " . $this->middle_name[0].$this->middle_name[1].".";
            }
            catch(Exception $ex){

            }
            return $Initials;
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

        public function getBirthYear(){
            return substr($this->birth,0,strpos($this->birth,'-'));
        }

        public function getBirthMonth(){
            $fPos = strpos($this->birth,'-')+1;
            return substr($this->birth,$fPos,strpos($this->birth,'-',$fPos)-$fPos);
        }

        public function getBirthDay(){
            $fPos = strpos($this->birth,'-')+1;
            $sPos = strpos($this->birth,'-',$fPos)+1;
            return substr($this->birth,$sPos,2);
        }

        public function getRegistrationCode(){
            return $this->registration_code;
        }

	}

/*function getAllTeachers(){
    $teachers = [];
    $sql = "SELECT * FROM teachers";
    $result = mysqli_query($GLOBALS['conn'],$sql); 
    while($row = mysqli_fetch_assoc( $result))
    {
        //$id,$first_name,$second_name,$middle_name,$phone,$email,$birth,$registration_code
        $teacher = new teacher();
        $teacher->setData($row['teacher_id'],$row['teacher_name'],$row['teacher_second_name'],$row['teacher_middle_name'],$row['teacher_phone'],$row['teacher_email'],$row['teacher_birth'],$row['teacher_']);
    }
    return $teachers;
}*/


//$tmp = new teacher('1241qewr5','s','m','p','e','1999-10-1');
//$tmp = new teacher('1');
//$tmp->createCuratorGroup("3",2000,2005);
//echo $tmp->createRegistrationCode();
//$tmp->teacher_create();
//$tmp->teacher_update("testName");
//$tmp->teacher_delete();