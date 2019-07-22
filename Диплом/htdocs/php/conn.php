<?php
	$DBHOST = "localhost";
	$DBUSERNAME = "root";
	$DBPASSWORD = "";
	$DBNAME = "db_students";	

	$GLOBALS['conn'] = mysqli_connect($DBHOST,$DBUSERNAME,$DBPASSWORD,$DBNAME);
	mysqli_set_charset($GLOBALS['conn'], "utf8");
	//$conn = mysqli_connect($DBHOST,$DBUSERNAME,$DBPASSWORD,$DBNAME);

function escape_sql($text)
{
	//$text = mysqli_real_escape_string($GLOBALS['conn'],$text);
	//$text = str_replace(";", "", $text);
	return mysqli_real_escape_string($GLOBALS['conn'],$text);
}

$main_chars = ['/;/','/,/'];

function del_main_chars($text)
{	
	return preg_replace($GLOBALS['main_chars'],"",$text);
}
//escape_sql(