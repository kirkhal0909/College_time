<?php
if (isset($conn)==False)
    include_once($_SERVER['DOCUMENT_ROOT'].'/php/conn.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/student.php');

	class group_uniq
	{		
        const default_years_of_studying = 4;    //4 года
        const monthStartEnd = 9; //Месяц начала обучения - сентябрь

        private $id = '0';
		private $group_id = '3';
        private $group_number = '1';
        private $group_start_year;
        private $group_end_year;   
        private $group_short_name = '';
        private $group_uniq_short_name = '';
        private $group_full_name = '';   
        public $students = [];


		//ИНИЦИАЛИЗАЦИЯ ОБЪЕКТА - group_uniq
		public function __construct($id = 0) {	   
            $notCreated = True;                  
            if($id>0)           
            {
                $this->id = $id;                              
                $sql = "SELECT * from groups_now where group_unique_group_id = '".escape_sql($id)."';";                
                if($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    if(mysqli_num_rows($result) > 0)
                    {
                        $row = mysqli_fetch_assoc( $result);
                        $this->setGroupID($row['group_id']);                 
                        //$this->group_id = ;
                        $this->group_number = $row['group_by_number'];
                        $this->group_start_year = $row['group_start_year'];
                        $this->group_end_year = $row['group_end_year'];
                        //echo print_r($row);
                        $notCreated = False;
                    }
                }
            }
            if($notCreated){                
                $this->group_start_year = date("Y");
                $this->group_end_year = date("Y")+self::default_years_of_studying;
            }            
    	}        

        public function setData($group_unique_group_id,$group_id,$group_by_number,$group_start_year,$group_end_year,$group_short_name='',$group_full_name=''){
            $this->id = $group_unique_group_id;
            $this->group_id = $group_id;
            $this->group_number = $group_by_number;
            $this->group_start_year = $group_start_year;
            $this->group_end_year = $group_end_year;
            $this->group_short_name = $group_short_name;
            $this->group_full_name = $group_full_name;
        }

        private function queryGroupIDInDB(){
            $inDB = False;
            $sql = "SELECT group_id from groups where group_id = '". escape_sql($this->group_id) ."';";
            //echo $sql;  
            if($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    if(mysqli_num_rows($result) > 0)
                    {                        
                        $inDB = True;
                    }
                }
            return $inDB;
        }

        private function findNumberGroup(){
            $sql = "SELECT MAX(group_by_number) from groups_now where group_id = '". escape_sql($this->group_id) . "';";            
            if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {                    
                    $row = $result->fetch_row();
                    $this->group_number = $row[0]+1;                                                         
                }                
        }

        public function queryGroupExists(){
            $groupExists = False;
            $sql = "SELECT * from `groups_now` where `group_id` = '" . escape_sql($this->group_id). "' AND `group_by_number` = '".escape_sql($this->group_number)."';";
            if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                     if(mysqli_num_rows($result) > 0)
                    {
                        $groupExists = True;
                    }
                }
            return $groupExists;
        }

        public function setNumberGroup($group_number)
        {
            $this->group_number = $group_number;
        }

        public function setID($id){
            $this->id = $id;
        }

        public function setGroupID($group_id){            
            $sql = "SELECT * from groups where group_id = '". escape_sql($group_id) . "';";
            $found = False;
            if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                     if(mysqli_num_rows($result) > 0)
                    {
                        $row = mysqli_fetch_assoc( $result);
                        $found = True;
                        $this->group_short_name = $row["group_short_name"];
                        $this->group_full_name = $row["group_name"];
                    }
                }
            if ($found == False)
                $this->group_id = '';
            $this->group_id = $group_id;
        }

        public function setGroupStartYear($grp_start_year){
            $this->group_start_year = $grp_start_year;
        }

        public function setGroupEndYear($grp_end_year){
            $this->group_end_year = $grp_end_year;
        }

        public function getGroupGeneralName(){
            return $this->group_full_name;
        }

        public function getGroupCourse(){
            $yearNow = date('Y');       
            $monthNow = date('m');
            if ($yearNow>$this->group_end_year)
                $yearNow = $this->group_end_year;
            $numberOfCourse = $yearNow-$this->group_start_year+1;            
                if ($monthNow<self::monthStartEnd){
                    $numberOfCourse -= 1;
                    if ($numberOfCourse == 0)
                    {
                        $numberOfCourse = 1;
                    }
                }  
            return $numberOfCourse;
        }

        public function getGroupUniqShortName(){
            if (!$this->group_uniq_short_name)
            {
                $numberOfCourse = $this->getGroupCourse();
                $this->group_uniq_short_name = $numberOfCourse . $this->group_short_name . $this->group_number;
            }
            return $this->group_uniq_short_name;
        }

        public function getID(){
            return $this->id;
        }

        public function getGroupID(){
            return $this->group_id;
        }

        public function getGroupNumber(){
            return $this->group_number;
        }

        public function getGroupStartYear(){
            return $this->group_start_year;
        }

        public function getGroupEndYear(){
            return $this->group_end_year;
        }

        public function groupUniq_create(){
            $created = False;
            //$this->findNumberGroup(); 

            //echo ($this->queryGroupIDInDB());            
            //echo "<script>alert('".$this->group_start_year.' '.$this->group_end_year."');</script>";
            if(($this->queryGroupIDInDB()) && (!$this->queryGroupExists()))
            {           
                $sql = "INSERT INTO `groups_now`(`group_id`, `group_by_number`, `group_start_year`, `group_end_year`) VALUES ('".escape_sql($this->group_id) ."','".escape_sql($this->group_number) ."',".escape_sql($this->group_start_year) .",".escape_sql($this->group_end_year) .")";                
                if($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    $this->id = $GLOBALS['conn']->insert_id;   
                    $this->findGeneralName();         
                    $created = True;
                }
            }            
            return $created;
        }

        public function student_create($first_name,$gender = student::gender_boy,$second_name,$middle_name,$birth,$more_info='',$phone='',$email=''){
            $new_student = new student($first_name,$this->id,$gender,$second_name,$middle_name,$phone,$email,$birth,$more_info);
            return $new_student->student_create();
            //($id_or_first_name = '',$group_unique_group_id = '',$gender = self::gender_boy,$second_name = '',$middle_name = '',$phone='',$email='',$birth='',$more_info = '')

        }

        public function groupUniq_delete(){
            $status = False;
            $this->findStudents();
            if(empty($this->students))
            {
                $sql = "DELETE FROM groups_now WHERE group_unique_group_id = '".$this->id ."';";
                $result = mysqli_query($GLOBALS['conn'],$sql); 
                $status = True;
            }
            return $status;
        }

        private function findGeneralName(){
            $sql = "SELECT group_name FROM groups WHERE group_id = '".escape_sql($this->group_id)  ."';";
            if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {                    
                    $row = $result->fetch_row();
                    $this->group_full_name = $row[0];
                } 
        }

        public function findStudents()
        {
            if(empty($this->students))
            {
                $sql = "SELECT * from students where group_unique_group_id = '".escape_sql($this->id)."';";
                if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    while($row = mysqli_fetch_assoc( $result))
                    {
                        $student = new student();
                        //$id,$group_unique_group_id,$first_name,$second_name,$middle_name,$phone,$email,$birth,$more_info
                        $student->setData($row["student_id"],$row["group_unique_group_id"],$row["student_name"],$row["student_second_name"],$row["student_middle_name"],$row["student_phone"],$row["student_email"],$row["student_birth"],$row["student_more_info"],$row["student_gender"]);
                        array_push($this->students, $student);
                    }
                    //print_r($this->students);                    
                }
            }
        }        
	}

function queryCountCourses(){
    $sql = "SELECT group_unique_group_id from groups_now where 1";
    $courses = [];    
    if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    while($row = mysqli_fetch_assoc( $result))
                    {
                        $uniq_group = new group_uniq($row["group_unique_group_id"]);                        
                        $course = $uniq_group->getGroupCourse();
                        //echo $course;
                        if (isset($courses[$course])){
                            $courses[$course]++;
                            
                        } else{
                            $courses[$course] = 1;                            
                        }
                        
                    }
                } 
    ksort($courses);
    return $courses;
}

function getUniqGroupsByCourse($course)
{
    $sql = "SELECT * from groups_now where 1;";
    $groupsByCourse = [];
    if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {//echo mysqli_num_rows($result);
                    while($row = mysqli_fetch_assoc( $result))
                    {
                        $uniq_group = new group_uniq();                                           
                        $uniq_group->setData($row["group_unique_group_id"],$row["group_id"],$row["group_by_number"],$row["group_start_year"],$row["group_end_year"],"","");
                        //echo $uniq_group->getGroupCourse(). ' '. $course. ' = '.($uniq_group->getGroupCourse()==$course).'<br>';                        
                        if($uniq_group->getGroupCourse()==$course)
                        {
                            $uniq_group->setGroupID($row["group_id"]);

                            $id = $uniq_group->getID();
                            $uniq_short_name = $uniq_group->getGroupUniqShortName();
                            $teacher_id = 0;
                            $sql = "SELECT teacher_id from groups_curators where group_unique_group_id = '".escape_sql($id)."';";                            
                            $result2 = mysqli_query($GLOBALS['conn'],$sql);
                            if($row = mysqli_fetch_assoc( $result2))
                            {
                                //if(isset())
                                $teacher_id = $row['teacher_id'];
                            }
                            $teacher = new teacher($teacher_id);
                            array_push($groupsByCourse, [$id,$uniq_short_name,$uniq_group->getGroupGeneralName(),$teacher]);
                        }
                    }
                } 
    return $groupsByCourse;
}

//include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/teacher.php');
//print_r(getUniqGroupsByCourse(1));

//print_r(queryCountCourses());

//$obj = new group_uniq(1);
//$obj->findStudents();
//echo $obj->getGroupShortName();
//$obj->findNumberGroup();
//$obj->setGroupID(1);
//$obj->groupUniq_create();

//$pcs = new group("PCS211","09.02.03 programming in computer systems2123"); 
//$pcs->group_create();
//echo $pcs->queryGroupNameInDB();
//echo $pcs->queryGroupShortNameInDB();
//$pcs->group_delete();