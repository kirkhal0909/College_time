<?php

include_once($_SERVER['DOCUMENT_ROOT'].'/php/conn.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/user.php');

//$now = time();
define('session_max_time',time()+2592000); //

session_start();
function setSession($user){
    $user_agent = $_SERVER['HTTP_USER_AGENT'];
    $_SESSION["auth"] = True;
    $sess = $_COOKIE["PHPSESSID"];    
    //$now = time();    

    $sql = "INSERT INTO `sessions`(`session_id`, `user_agent`, `session_time_end`, `account_username`) VALUES ('".escape_sql($sess)."','".escape_sql($user_agent)."','".escape_sql(session_max_time)."','".escape_sql($user->getUsername())."');";    
    $result = mysqli_query($GLOBALS['conn'],$sql);
}

function destroySession(){
    if(isset($_SESSION))
    {
        if(isset($_COOKIE["PHPSESSID"]))
        {
            $sql = "DELETE FROM sessions WHERE session_id = '".escape_sql($_COOKIE["PHPSESSID"])."' AND user_agent = '".escape_sql($_SERVER['HTTP_USER_AGENT'])."';";
            $result = mysqli_query($GLOBALS['conn'],$sql);            
            session_destroy();
            $_SESSION = array();            
            unset($_COOKIE["PHPSESSID"]);
            setcookie("PHPSESSID", null, -1,'/');            
        }
    }
}

function validSession(){
    $isValid = False;
    if(isset($_SESSION))
    {
        if(isset($_COOKIE["PHPSESSID"]))
        {
            $sql = "SELECT * FROM sessions WHERE session_id = '".escape_sql($_COOKIE["PHPSESSID"])."' AND user_agent = '". escape_sql($_SERVER['HTTP_USER_AGENT']) ."';";
            //echo $sql;            
            if($result = mysqli_query($GLOBALS['conn'],$sql))
            {
                if($row = mysqli_fetch_assoc( $result))
                    {                                            
                            $end_time = $row['session_time_end'];
                            $now = time();                            
                            if ($now<=$end_time)
                            {                                     
                                $isValid = new user($row["account_username"],"pass");                           
                                //echo $isValid->getUsername();
                                //$user = new user($row["account_username"],"pass");
                                //$isValid = True;
                            }
                            else{
                                destroySession();
                            }                        
                    }
            }
        }        
    }
    return $isValid;
}

function userAuth(){
    $auth = False;
    if(isset($_SESSION))
    {
        if(isset($_SESSION["auth"]))
        {
            $auth = True;
        }
    }
    return $auth;
}

/*function getUserStatus(){
    $status = -123;
    if(userAuth())
    {
        $status = $_SESSION["status"];                
    }    
    return $status;
}*/

function getAuthUser(){
    return validSession();
}

//echo getUserStatus();
//setSession("qetqwetqwetweq");
//destroySession();