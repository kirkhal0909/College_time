<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/need_login.php');

//print_r($_POST);
if((!$needLogin) && (isset($_POST['method'])))
{
	//echo "loginned";	
	include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/group.php');
	if($status == user::status_admin){		
		if( (isset($_POST['group_name'])) && (isset($_POST['group_short_name'])))
		{
			if($_POST['method'] == 'create')
			{		
				$new_group = new group($_POST['group_short_name'],$_POST['group_name']);
				if($new_group->group_create())
				{
					echo "True".','.$new_group->getID();
				}
				else echo "False";
			} else if(($_POST['method'] == 'edit') && (isset($_POST['group_id'])))
			{
				$edit_group = new group($_POST['group_id']);
				//echo $edit_group->getName();
				//$edit_group->setName();
				//$edit_group->setShortName();
				$edit_group->group_update($_POST['group_name'],$_POST['group_short_name']);
				
				$check_group = new group($_POST['group_id']);
				if ($check_group->getName()==$_POST['group_name'] && $check_group->getShort_name()==$_POST['group_short_name'])
					{echo "True";}
				else echo "False";
			} 
		}else if (($_POST['method'] == 'delete') && (isset($_POST['group_id'])) )
		{
			$delete_group = new group($_POST['group_id']);
			//$delete_group->getUniq_groups();
			if($delete_group->group_delete())
				{echo "True";}
			else echo "False";
		}
	}
	if(($status>0) && ($_POST['method']=='get'))
	{
		$groups = getGroups();
		//echo "get";
		for($i=0;$i<count($groups);$i++)
		{
			echo del_main_chars($groups[$i]["group_id"]).','.del_main_chars($groups[$i]["group_name"]).','.del_main_chars($groups[$i]["group_short_name"]).';';
			//$group = ['group_id'=>$row["group_id"],'group_name'=>$row["group_name"],'group_short_name'=>$row["group_short_name"]];
			
		}
	}
	/*else 
	echo "Access denied!";*/	
}