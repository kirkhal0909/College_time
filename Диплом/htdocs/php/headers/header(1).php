<?php

$head = '<html>
	<head>
		<link rel="stylesheet" type="text/css" href="/css/style.css"> 
		<script src="/js/script.js"> </script>
	</head>
	<body>';
$startMenu = "
	<!--<div class='block-back'>
		  <div class='main-block form'>
		    <form>  
		      <h1 class='caption'>Создание группы</h1>

				<div class='styled-select slate'>
				  <select>
				    <option>Специальность:</option>
				    <option>The second option</option>
				    <option>The third option</option>
				  </select>
				</div>

		      <input id='group-num' placeholder='Номер группы' type='text'>
		      <input id='group-start-year' placeholder='Год начала обучения' type='text'>
		      <input id='group-end-year' placeholder='Год окончания обучения' type='text'>
		      <button id='login-submit' onclick='' type='button' class='button'>
		    		Создать группу
		      </button>
		    </form> 
		  </div>
	</div>

	<div class='block-back'>
		  <div class='main-block form'>
		    <form>  
		      <h1 class='caption'>Добавление специальности</h1>

		      <input id='group-name' placeholder='Название специальности' type='text'>
		      <input id='group-short-name' placeholder='Сокращённое название' type='text'>		      
		      <button id='login-submit' onclick='' type='button' class='button'>
		    		Добавить специальность
		      </button>
		    </form> 
		  </div>
	</div>

	<div class='block-back'>
		  <div class='main-block form'>
		    <form>  
		      <h1 class='caption'>Добавить преподавателя</h1>

		      <input id='teacher-second-name' placeholder='Фамилия' type='text'>
		      <input id='teacher-name' placeholder='Имя' type='text'>
		      <input id='teacher-middle-name' placeholder='Отчество' type='text'>
		      <button id='login-submit' onclick='' type='button' class='button'>
		    		Добавить преподавателя
		      </button>
		    </form> 
		  </div>
	</div>

	<div class='block-back'>
		  <div class='main-block form'>
		    <form>  
		      <h1 class='caption'>Добавить студента</h1>

				<div class='styled-select slate'>
				  <select>
				    <option>Специальность:</option>
				    <option>The second option</option>
				    <option>The third option</option>
				  </select>
				</div>

		      <input id='student-second-name' placeholder='Фамилия' type='text'>
		      <input id='student-name' placeholder='Имя' type='text'>
		      <input id='student-middle-name' placeholder='Отчество' type='text'>
		      <button id='login-submit' onclick='' type='button' class='button'>
		    		Добавить студента
		      </button>
		    </form> 
		  </div>
	</div>-->

	<div id='parent-div'>
	<div id='sidebar'> 
		<div class='toggle-button' onclick='toggleSidebar()'>
		<span></span><span></span><span></span>
		</div>
		<div class='main-panel'>
		<div class='main-panel-inner-block'>
			<ul>
				<li id='user_login'>";
$endMenu = "
				<li id='page-groups' onclick='block_list(\"groups\")'>Все группы</li>
				<!--<li id='page-my-groups'>Мои группы</li>-->
				<li id='page-mng-users' onclick='block_list(\"teachers\");'>Управление пользователями</li>
				<li id='page-mng-spec' onclick='block_list(\"specialities\");'>Управление специальностями</li>
				<!--<li id='page-mng-groups'>Управление группами</li>-->
				<li id='page-my-options' onclick='block_create(\"password-edit\")'>Мои настройки</li>
				<li id='exit-button' onclick='changeLocation(\"/php/login.php?logout=true\")'>Выйти</li>
			</ul>
		</div></div>
	</div>";


include_once($_SERVER['DOCUMENT_ROOT'].'/php/need_login.php');

echo $head;
if ($needLogin)
{		
	$posLogin = -1;
	$posRegistry = -1;
	//echo $URInow;
	if(is_string($URInow))
	{		
		$posLogin = strpos($URInow,login_page);	
		$posRegistry = strpos($URInow,registry_page);		
	}		
	//echo strpos($URInow,'login')!==0;
	if (($posLogin!==0)&&($posRegistry!==0))
	{

		header('Location: '.'.././login'); 
	}	
} else{
	if (($URInow==login_page)||($URInow==registry_page))
	{
		header('Location: '.'.././'); 
	} else{	//Если пользователь был авторизован		
		//$status = $user->getStatus();
		
		$fullUsername = $user->getUsername();
		if($user->teacher)
		{
			$fullUsername = $fullUsername . " (" . $user->teacher->getFIO() . ")";
		}
		if($status == user::status_banned)
		{
			echo "<p style='color:red;'>Аккаунт заблокирован!</p>";
		}
		else{
			$menu = '';
			echo $startMenu . $fullUsername . $endMenu;
			if($status == user::status_teacher){
				//page-mng-users page-mng-spec page-mng-groups
				echo "<script>
						document.getElementById('page-mng-users').remove();
						document.getElementById('page-mng-spec').remove();						
					</script>";
			} else if($status == user::status_admin)
			{				
			}			
		}
		echo "</div>";
	}
}


/*
Все группы
Мои группы
Создать группу
*/


//echo $user_status;

//echo $user_status;


//$_SESSION['favcolor'] = 'green';
//echo $_SESSION['favcolor'];