<?php
if (isset($conn)==False)
    include_once($_SERVER['DOCUMENT_ROOT'].'/php/conn.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/group_uniq.php');

	class group
	{		
        private $id = '0';
		private $name = '';
        private $short_name = '';      
        private $uniq_groups = [];

		//ИНИЦИАЛИЗАЦИЯ ОБЪЕКТА - group
        //$obj = new group(id); - Загружает группу из БД
        //$obj = new group('name',[...]); - создаёт новый экземпляр, которого нет в БД
		public function __construct($id_or_short_name,$name = '') {	            
			if(is_numeric($id_or_short_name))
            {
                $this->id = $id_or_short_name;
                $sql = "SELECT * from groups where group_id = '".escape_sql($id_or_short_name)."';";                
                $result = mysqli_query($GLOBALS['conn'],$sql); 
                $row = mysqli_fetch_assoc( $result);                
                $this->name = $row['group_name'];
                $this->short_name = $row['group_short_name'];                
            } else {
                $this->name = $name;
                $this->short_name = $id_or_short_name;            
            }
    	}

        public function findUniqGroups(){
            if(empty($this->uniq_groups))
            {
                $sql = "SELECT * from groups_now where group_id = '".escape_sql($this->id)."';";
                if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    while($row = mysqli_fetch_assoc( $result))
                    {
                        $uniq_group = new group_uniq();
                        //$group_unique_group_id,$group_id,$group_by_number,$group_start_year,$group_end_year,$group_short_name,$group_full_name
                        $uniq_group->setData($row["group_unique_group_id"],$row["group_id"],$row["group_by_number"],$row["group_start_year"],$row["group_end_year"],$this->short_name,$this->name);
                        array_push($this->uniq_groups, $uniq_group);
                    }
                    //print_r($this->uniq_groups);                    
                }
            }
        }

        public function findUniqGroupsWithStudents(){
            $this->findUniqGroups();
            foreach ($this->uniq_groups as $uniq_group) {
                $uniq_group->findStudents();
            }
            print_r($this->uniq_groups);
        }

        public function setID($id)
        {
            $this->id = $id;
        }

        public function setName($name){
            $this->name = $name;
        }

        public function setShortName($short_name){
            $this->short_name = $short_name;
        }

        public function group_update($name='',$short_name = ''){
                $status = False;                
                if ($name)
                    $this->name = $name;
                if ($short_name)
                    $this->short_name = $short_name;                
                $sql = "UPDATE `groups` SET `group_name`='". escape_sql($this->name) ."',`group_short_name`='". escape_sql($this->short_name) ."' WHERE `group_id` = ".escape_sql($this->id).";";
                //echo '<br>'.$sql;
                $result = mysqli_query($GLOBALS['conn'],$sql); 
                /*if($result)
                if(mysqli_num_rows($result) > 0) $status = True;
                return $status;*/
        }        

    	public function group_create(){
            $status = False;
            if(!($this->queryGroupNameInDB() && $this->queryGroupShortNameInDB()))
            {
                $sql = "INSERT INTO `groups`(`group_name`, `group_short_name`) VALUES ('".escape_sql($this->name)."',
                    '".escape_sql($this->short_name)."');";               
                $result = mysqli_query($GLOBALS['conn'],$sql); 
                $this->id = $GLOBALS['conn']->insert_id;
                if ($GLOBALS['conn']->insert_id)
                {
                    $status = True;
                }
            }
            return $status;
        }

        public function group_delete(){
            $this->findUniqGroups();
            $status = False;
            if(empty($this->uniq_groups))
            {
                $sql = "DELETE FROM groups WHERE group_id = '".$this->id ."';";
                $result = mysqli_query($GLOBALS['conn'],$sql); 
                if($result) $status = True;
            }
            return $status;
        }

        public function getUniq_groups(){
            $this->findUniqGroups();
            return $this->uniq_groups;
        }

        public function getID(){
            return $this->id;
        }

        public function getName(){
            return $this->name;
        }

        public function getShort_name(){
            return $this->short_name;
        }

        public function queryGroupNameInDB(){
            $inDB = False;            
            $sql = "SELECT * FROM groups WHERE group_name = '" . escape_sql($this->name) . "';";            
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

        public function queryGroupShortNameInDB(){
            $inDB = False;            
            $sql = "SELECT * FROM groups WHERE group_short_name = '" . escape_sql($this->short_name) . "';";            
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

        public function create_uniq_group($group_start_year = 0,$group_end_year = 0){
            if($this->id > 0)
            {
                $uniq_group = new group_uniq();
                $uniq_group->setGroupID($this->id);
                if($group_start_year){
                    $uniq_group->setGroupStartYear($group_start_year);
                    if($group_end_year)
                    {
                        $uniq_group->setGroupEndYear($group_end_year);
                    }
                    else{
                        $uniq_group->setGroupEndYear($group_start_year+$uniq_group::default_years_of_studying);
                    }
                }
                $uniq_group->groupUniq_create();
                array_push($this->uniq_groups, $uniq_group);
            }
        }
        
	}

function getGroups(){
    $sql = "SELECT * from groups where 1;";
    $groups = [];
                if ($result = mysqli_query($GLOBALS['conn'],$sql))
                {
                    while($row = mysqli_fetch_assoc( $result))
                    {
                        $group = ['group_id'=>$row["group_id"],'group_name'=>$row["group_name"],'group_short_name'=>$row["group_short_name"]];
                        array_push($groups, $group);
                    }
                }
    return $groups;
}

//$pcs = new group("1");
//$pcs->findUniqGroupsWithStudents();
//$pcs->create_uniq_group(1999,2015);
//$pcs = new group("PCS211","09.02.03 programming in computer systems2123"); 
//$pcs->group_create();
//echo $pcs->queryGroupNameInDB();
//echo $pcs->queryGroupShortNameInDB();
//$pcs->group_delete();