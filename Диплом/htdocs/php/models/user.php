<?php

include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/teacher.php');
if (isset($conn)==False)
    include_once($_SERVER['DOCUMENT_ROOT'].'/php/conn.php');

	class user
	{
        const status_banned = -1;
		const status_need_activate = 0;
		const status_admin = 1;
		const status_teacher = 5;

		public $username = '';		
		private $id = '0';
		private $password = '';
		private $passwordDB = '';
		private $dateCreated = '';
		public $teacher;
        private $userStatus = 0;
		/*private $userExists = False;
		
		private $correctPassword = False;*/

		//ИНИЦИАЛИЗАЦИЯ ОБЪЕКТА - user
		public function __construct($username,$password,$preLoad=true) {			
			$username = strtolower($username);				
	        $this->username = $username;	        
	        $this->setPassword($password);
            if($preLoad)
            {
    	        $sql = "SELECT * FROM accounts WHERE account_username = '" . escape_sql($this->username) . "';";
    	        if ($result = mysqli_query($GLOBALS['conn'],$sql))
    	        {
    	        	if($row = mysqli_fetch_assoc( $result))
    				{			      			      	
    			      	$this->id = $row["account_id"];
                        $this->userStatus = $row["account_status"];
                        //echo $this->userStatus;
    			      	$this->getTeacher();			      		
    			  	}
    	        }	        
            }
    	}
        
        public function setData($id,$userStatus,$dateCreated){
            $this->id = $id;
            $this->userStatus = $userStatus;
            $this->dateCreated = $dateCreated;
        }

    	public function getTeacher(){
    		$sql = "SELECT teacher_id FROM bindings_accounts WHERE account_id = '".escape_sql($this->id)."';";
    		if ($result = mysqli_query($GLOBALS['conn'],$sql))
	        {	        	
	        	if(mysqli_num_rows($result) > 0)
				{			      
			      	$row = $result->fetch_row();
			      	$teacher_id = $row[0];
			      	$this->teacher = new teacher($teacher_id);			      	
			  	}
	        }
    	}

    	//Хеширование пароля
    	private function encryptPass($password){
    		return sha1($this->username . $password);
    	}
    	//Установка пароля в переменной объекта, зашифроваа строку пароля
    	public function setPassword($password)
    	{
    		$this->password = $this->encryptPass($password);
    	}
    	//Получение хэша пароля
    	public function getPasswordHash(){
    		return $this->password;
    	}  

        public function getUsername()  	
        {
            return $this->username;
        }

    	public function getID(){
    		return $this->id;
    	}    	

        public function getStatus(){
            return $this->userStatus;
        }

    	private function queryUserDateCreated(){
    		$sql = "SELECT account_date_created FROM accounts WHERE account_username = '" . escape_sql($this->username) . "';"; 
    		if($result = mysqli_query($GLOBALS['conn'],$sql))
    		{    			    			
    			if(mysqli_num_rows($result) > 0)
			    {			      
			      $row = $result->fetch_row();
			      $this->dateCreated = $row[0];			      
			    }
    		}   
    	}

    	public function getUserDateCreated(){
    		if ($this->dateCreated=='')
    		{    			
    			$this->queryUserDateCreated();
    		}
    		return $this->dateCreated;
    	}

    	//Запрос, False - пользователя нет в БД; True - пользователь зарегистрирован!
    	public function queryUserInDB(){
    		$inDB = False;
    		//echo $this->username;
    		$sql = "SELECT * FROM accounts WHERE account_username = '" . escape_sql($this->username) . "';";    
    		//echo $sql;		
    		if($result = mysqli_query($GLOBALS['conn'],$sql))
    		{    			
    			if(mysqli_num_rows($result) > 0)
			    {			      
			      $inDB = True;
			    }
    		}    		
    		//$this->userExists = $inDB;
    		return $inDB;
    	}
    	//Получение статуса аккаунта 0 - требует активации; 1 - админ;
    	public function queryUserStatus(){
    		$userStatus = 0;
    		$sql = "SELECT account_status FROM accounts WHERE account_username = '" . escape_sql($this->username) . "';";
			if($result = mysqli_query($GLOBALS['conn'],$sql))
    		{
    			if(mysqli_num_rows($result) > 0)
			    {			      
			      $row = $result->fetch_row();
			      $userStatus = $row[0];			     
			    }
    		}
    		$this->userStatus = $userStatus;
    		return $userStatus;
    	}
    	//Проверка является ли пользователь админом
    	public function queryMeAdmin(){
    		$meAdmin = False;
    		if($this->queryUserStatus()==self::status_admin)
    			$meAdmin = True;
    		return $meAdmin;
    	}

    	//Проверка пароля False - пароль не правильный; True - пароль совпадает с паролем в БД
    	public function queryPasswordIsCorrect(){
    		$passCorrect = False;
    		$sql = "SELECT account_password FROM accounts WHERE account_username = '" . escape_sql($this->username) . "';";            
			if($result = mysqli_query($GLOBALS['conn'],$sql))
    		{                
    			if(mysqli_num_rows($result) > 0)
			    {			      
			      $row = $result->fetch_row();
                  /*print_r(strlen($row[0]));
                  echo "<br>";
                  print_r(strlen($this->password));*/
			      if($row[0]==$this->password)
                  {
                    //echo "pass equal";
			      	$passCorrect = True;	                    
                  }
			    }
    		}
    		//$this->userStatus = $userStatus;            
    		return $passCorrect;
    	}

    	//Проверка, существует ли определённый ник в БД
    	public function specificQueryUserInDB($username){
			$inDB = False;
    		$sql = "SELECT * FROM accounts WHERE account_username = '" . escape_sql($username) . "';";    		
    		if($result = mysqli_query($GLOBALS['conn'],$sql))
    		{
    			if(mysqli_num_rows($result) > 0)
			    {			      
			      $inDB = True;
			    }
    		}    		
    		//$this->userExists = $inDB;
    		return $inDB;
    	}
    	//Изменение статуса пользователя
    	public function user_ChangeStatus($status){
    		//if (($userAdmin->queryMeAdmin()) && ($userAdmin->queryPasswordIsCorrect()))
    		//{
    			if($this->queryUserInDB())
    			{    				
    				$sql = "UPDATE accounts SET account_status = '". escape_sql($status) ."	' WHERE account_username = '" . escape_sql($this->username). "';";
    				$result = mysqli_query($GLOBALS['conn'],$sql);
    			}
    		//}
    	}
    	//Изменение пароля
    	public function user_ChangePassword($password){
    			if($this->queryUserInDB())
    			{
    				$this->setPassword($password);
    				$sql = "UPDATE accounts SET account_password = '". escape_sql($this->password) ."' WHERE account_username = '" . escape_sql($this->username). "';";                    
    				$result = mysqli_query($GLOBALS['conn'],$sql);
    			}    	
    	}
    	//Изменени логина
    	public function user_ChangeUsername($username){    			
    			$username = strtolower($username);    			
    			if($this->queryUserInDB() && ($this->specificQueryUserInDB($username) == False))
    			{ 	
    				$sql = "UPDATE accounts SET account_username = '". escape_sql($username) ."' WHERE account_username = '" . escape_sql($this->username). "';";
    				$result = mysqli_query($GLOBALS['conn'],$sql);
    			}    		
    	}
    	

        public function queryCodeInDB($registration_code)
        {
            $inDB = false;
            $sql = "SELECT account_link_to_teacher_id from accounts_registration WHERE account_registration_code = '".escape_sql($registration_code)."';";
            if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    if(mysqli_num_rows($result) > 0)
                    {
                        $inDB = true;
                    }
                }
            return $inDB;
        }

		public function user_createByCode($registration_code,$status = self::status_teacher){
    		$created = False;
    		if($this->user_create($status))
    		{
    			$sql = "SELECT account_link_to_teacher_id from accounts_registration WHERE account_registration_code = '".escape_sql($registration_code)."';";
    			if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                	if(mysqli_num_rows($result) > 0)
                	{
                    	$row = $result->fetch_row();
                    	$teacher_id = $row[0];

                    	$sql = "INSERT INTO `bindings_accounts`(`account_id`, `teacher_id`) VALUES ('".escape_sql($this->id)."','".escape_sql($teacher_id)."');";
                    	$result = mysqli_query($GLOBALS['conn'],$sql);

                    	$sql = "DELETE FROM accounts_registration WHERE account_registration_code = '".escape_sql($registration_code)."';";
    					$result = mysqli_query($GLOBALS['conn'],$sql);
                    	//echo $teacher_id;
                    }
                }
    		}
    		return $created;
    	}

		//Создание пользователя
    	public function user_create($status = self::status_teacher){
    		$created = False;
    		if($this->queryUserInDB() == False)
    		{    			
    			$sql = "INSERT INTO accounts (account_username, account_password, account_status) VALUES ('".escape_sql($this->username)."','".escape_sql($this->getPasswordHash())."','". $status ."');";    			 
    			$result = mysqli_query($GLOBALS['conn'],$sql);    			
    			$this->id = $GLOBALS['conn']->insert_id;
    			if ($this->id > 0){
    				$created = True;
    			}
    		}
    		return $created;
    	}
    	//Удаление пользователя
    	public function user_delete(){
    		$sql = "DELETE FROM accounts WHERE account_username = '".$this->username."';";
    		$result = mysqli_query($GLOBALS['conn'],$sql); 

    		$sql = "DELETE FROM bindings_accounts WHERE account_id = '".$this->id."';";
    		$result = mysqli_query($GLOBALS['conn'],$sql);

    		$this->teacher->teacher_delete();
    	}
	}

function findUsersAndTeachers()
{
    $users = [];
    $sql = "SELECT * FROM accounts";
    $result = mysqli_query($GLOBALS['conn'],$sql); 
    while($row = mysqli_fetch_assoc( $result))
    {        
        //$id,$userStatus,$dateCreated        
        $user = new user($row['account_username'],'',False);
        $user->setData($row['account_id'],$row['account_status'],$row['account_date_created']);        
        $user->getTeacher();            
        array_push($users,$user);
    }    
    //print_r($users);
    return $users;
}

function findNewTeachers(){
    $teachers =[];
    $sql = "SELECT * FROM teachers WHERE teachers.teacher_id IN (SELECT accounts_registration.account_link_to_teacher_id FROM accounts_registration)";
    $result = mysqli_query($GLOBALS['conn'],$sql); 
    while($row = mysqli_fetch_assoc( $result))
    {        
        //$id,$userStatus,$dateCreated
        //print_r($row);
        $teacher = new teacher($row['teacher_id']);
        //$teacher->setData($row['teacher_id'],$row['teacher_name'],$row['teacher_second_name'],$row['teacher_middle_name'],$row['teacher_phone'],$row['teacher_email'],$row['teacher_birth'],"");//,$row['account_registration_code']);
        //$user->setData($row['account_username'],$row['account_status'],$row['account_date_created']);
        //$user->getTeacher();
        array_push($teachers,$teacher);
    }
    //print_r($teachers[count($teachers)-1]->getFIO());
    return $teachers;
}

//findNewTeachers();

function getAllUsers(){
    $users = [];
    $sql = "SELECT * FROM accounts";
    $result = mysqli_query($GLOBALS['conn'],$sql); 
    while($row = mysqli_fetch_assoc( $result))
    {        
        //$id,$userStatus,$dateCreated
        $user = new user($row['account_username'],'');
        $user->setData($row['account_id'],$row['account_status'],$row['account_date_created']);
        $user->getTeacher();
        array_push($users,$user);
    }    
    return $users;
}


/*
$testUser = new user("testCreateChanged","");
$testUser->user_delete();
*/

//$tmp = new user("kirkhal","pass");
//$tmp->user_create();

//$tmp->user_createByCode('zEAhbFjbQEZLChTs');
//$tmp->user_delete();
//$tmp->user_delete();
//echo $tmp->getUserDateCreated();
//$tmp->user_delete();