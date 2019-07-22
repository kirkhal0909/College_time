//Menu function
function toggleSidebar(){
	document.getElementById("sidebar").classList.toggle('active');
}

//Functions for requests
function changeLocation(pathLocation){
	document.location.href = pathLocation;
}

function doPost(href="/",params=""){
	var http = new XMLHttpRequest();
	http.open("POST", href, false);	
	http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');	
	http.send(params);		
	var t = http.responseText; 
	return t;
}

function methodInsert(newNode, referenceNode){
	referenceNode.parentNode.insertBefore(newNode, referenceNode.nextSibling);
}

function insertAfter(newNode, referenceNode) {		
	/*try{
	    methodInsert(newNode, referenceNode)
	} catch(err)*/
	{//console.log('end download')
		window.refreshIntervalId = setInterval(function(){
			try{
				methodInsert(newNode, referenceNode);
				clearInterval(window.refreshIntervalId);

			} catch(err){}
		}, 400);
	}
}

function uploadGroup(group_id){
	block_id = 'group_block_students_id_'+group_id;
	main_block = document.getElementById(block_id)
	//console.log(block_id)
	
	
	/*{
		if (main_block.style.display == 'none')
		{
			main_block.style.display = 'block';
		} else main_block.style.display = 'none';
	}*/
	if (main_block == null){
		//console.log(main_block)
		var students_block = document.createElement('div')
		students_block.id = block_id
		students_block.className = 'student-parent-block';	
		/*window.onresize = function(){
			max_left = 0
			blocks = document.getElementsByClassName('student-block')
			for(i=0;i<blocks.length;i++){
				block = blocks[i]
				var tmp = block.offsetLeft+block.width
				if (tmp>max_left)
				{
					max_left = tmp
				}
				else{
					break
				}
			}
			//console.log(max_left)

		}*/
		//insertAfter(students_block,);
		document.getElementById('group_id_'+group_id).after(students_block)
		var students = doPost('/pages/post/group_now.php','method=getStudents&group_now_id='+group_id)
		var students = students.split(';')

		var access_edit = doPost('/pages/post/group_now.php','method=accessDelete&group_now_id='+group_id)

		if (access_edit == 'True')
		{
			var block_add =  document.createElement('div')
			block_add.className = 'student-block'
			students_block.appendChild(block_add)

			var block_card = document.createElement('div')
			block_card.className = 'student-card'
			block_add.appendChild(block_card)

			var block_avatar = document.createElement('div')
			block_avatar.className = 'student-avatar student-add'
			block_avatar.id = 'add-group-now-'+group_id;
			block_avatar.onclick = function(e){id_group = e.target.id.split('-'); id_group = id_group[id_group.length-1]; block_create("student",id_group);}
			block_card.appendChild(block_avatar)


			var blockControl = document.createElement('div')
			blockControl.className = 'group-control'
			blockControl.id = 'delete_'+block_id;			


			var btn_delete = document.createElement('button')
			btn_delete.className = 'button button-delete-group';
			btn_delete.id = 'group_delete_'+group_id;
			btn_delete.innerText = 'Удалить'	
			btn_delete.onclick = function(e){
					id_block = e.target.id.split('_');					
					id_group = id_block[id_block.length-1];
					//(($_POST['method']=='studentDelete') && isset($_POST['group_now_id']) && isset($_POST['student_id']))
					group = document.getElementById('group_block_students_id_'+(id_group).toString())
						//if(student!=null) user_name = user.innerText;
						if(confirm("Вы точно хотите удалить группу "+group.firstChild.wholeText+"?"))
						{
							//} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
							t = doPost("/pages/post/group_now.php","method=delete&group_now_id="+id_group+'&group_uniq_id='+id_group);
							if (t=='True')
							{								
								group.previousSibling.remove()
								group.remove()
								document.getElementById('delete_group_block_students_id_'+id_group).remove()
								setTimeout(function(){alert('Группа успешно удалена')},100)
							} else{
								alert('Не удалось удалить\n'+t)
							}							
						}
							

				}
			blockControl.appendChild(btn_delete)
			//insertAfter(blockControl,students_block);
			students_block.after(blockControl)
		}
		//console.log(access_edit);
		//$student->
		//getID().','.$student->getFirst_name().','.$student->getSecond_name().','.$student->getMiddle_name().','.$gender.','.$student->getPhone().','.$student->getEmail().','.$student->getBirth().','.$student->getMoreInfo().';'
		for(i=0;i<students.length-1;i++)
		{
			student = students[i].split(',');
			//echo $student->getID().','.$student->getFirst_name().','.$student->getSecond_name().','.$student->getMiddle_name().','.$gender.','.$student->getPhone().','.$student->getEmail().','.$student->getBirth().','.$student->getMoreInfo().';';
			addBlock('student',access_edit+','+student[0]+','+group_id+','+student[4]+','+student[2]+','+student[1]+','+student[3]+','+student[7]+','+student[5]+','+student[6]+','+student[8])
			/*addBlock('student',access_edit+student[0]+','+group_now_id.value+','+student_gender.value+','+student_second_name.value+','+student_name.value+','+student_middle_name.value+','+student_birth.value+','+student_phone.value+','+student_email.value+','+student_info.value)				
			var student_block = document.createElement('div')
			student_block.className = 'student-block'
			student_block.id = 'student-id-'+student[0];
			students_block.appendChild(student_block)

			if (access_edit == 'True')
			{
				var btn_delete = document.createElement('button')
				btn_delete.className = 'button button-delete-student';
				btn_delete.id = group_id+'-group-delete-student-'+student[0];
				btn_delete.innerText = 'Удалить'
				btn_delete.onclick = function(e){
					id_block = e.target.id.split('-');
					id_group = id_block[0]
					id_student = id_block[id_block.length-1];
					//(($_POST['method']=='studentDelete') && isset($_POST['group_now_id']) && isset($_POST['student_id']))
					student = document.getElementById('student-id-'+id_student)
						//if(student!=null) user_name = user.innerText;
						if(confirm("Вы точно хотите удалить студента?"))
						{
							//} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
							t = doPost("/pages/post/group_now.php","method=studentDelete&group_now_id="+id_group+'&student_id='+id_student);
							if (t=='True')
							{
								student.remove()								
							} else{
								alert('Не удалось удалить')
							}							
						}
							

				}

				student_block.appendChild(btn_delete);
			}

			var student_card = document.createElement('div')
			student_card.className = 'student-card'
			student_block.appendChild(student_card)

			var student_avatar = document.createElement('div')
			student_avatar.className = 'student-avatar'
			if(student[4]=='boy')
				{student_avatar.className = student_avatar.className+' student-boy'}
			else{student_avatar.className = student_avatar.className+' student-girl'}
			student_card.appendChild(student_avatar)		

			student_FIO = student[2]+' '+student[1]+' '+student[3]
			var student_info = document.createElement('p')
			student_info.innerText = student_FIO

			student_card.appendChild(student_info)*/
			showGroup(group_id,show=true)
		}
	} else{
		if (document.getElementById(block_id).style.display != 'none')
			{showGroup(group_id,show=false)}
		else{showGroup(group_id,show=true)}
	}
	//console.log(students)
}

function showGroup(group_id,show=true)
{			
	if (show)
	{
		//console.log("true");
		document.getElementById('group_block_students_id_'+group_id).style.display = 'block'; //display: block;
		//document.getElementById('course_'+group_id).onclick = function(){showGroups(course,false);}
		//document.getElementById('course_block_'+course).style.margin = '1em 0em -1em 0em';
		//console.log(group_id)
		document.getElementById('vsl_btn_group_'+group_id).innerText = '▼'
		document.getElementById('group_delete_'+group_id).style.display = 'block';
	} else
	{
		//console.log("false");
		document.getElementById('group_block_students_id_'+group_id).style.display = 'none';
		//document.getElementById('course_'+group_id).onclick = function(){showGroups(course,true);}
		document.getElementById('vsl_btn_group_'+group_id).innerText = '▲'
		document.getElementById('group_delete_'+group_id).style.display = 'none';
	}
}

//Functions for working with groups
function uploadGroups(course)
{	
	var ret = doPost("/pages/post/get_groups.php","course="+course);
	ret = ret.split(';');
	var course_block = document.createElement('div')
	course_block.id = 'course_block_'+course
	course_block.className = 'submain-block-with-objects'
	course_block.style.display = 'block'
	//insertAfter(course_block,document.getElementById("course_"+course))
	document.getElementById("course_"+course).after(course_block);
	var hr = document.createElement('hr')
	course_block.appendChild(hr);
	for(i=0;i<ret.length-1;i++)
		{			
			block = ret[i].split(',')
			var group_id = block[0].toString()
			group_block = document.createElement('h2')			
			group_block.innerHTML = block[1]+'<span title="'+block[5]+'" id="teacher_id_'+block[3]+'">('+block[4]+')</span> <span id="vsl_btn_group_'+group_id+'">▲</span>'
			group_block.title = block[2]
			group_block.id = 'group_id_'+group_id		
			group_block.className = 'group-name'			
			group_block.onclick = function(e){ id_block = e.target.id.split('_'); if(id_block[0]=='teacher'){id_block = e.target.parentNode.id.split('_');} id_block = id_block[id_block.length-1]; uploadGroup(id_block);}
			course_block.appendChild(group_block)
			var hr = document.createElement('hr')
			course_block.appendChild(hr);
		}
	showGroups(course)
}
	
function showGroups(course,show=true)
{		
	if (show)
	{		
		try{
			document.getElementById('course_block_'+course).style.display = 'block'; //display: block;
		}catch(er){}
		document.getElementById('course_'+course).onclick = function(){showGroups(course,false);}
		document.getElementById('vsl_btn_course_'+course).innerText = '▼'
	} else
	{		
		document.getElementById('course_block_'+course).style.display = 'none';
		document.getElementById('course_'+course).onclick = function(){showGroups(course,true);}
		document.getElementById('vsl_btn_course_'+course).innerText = '▲'
	}
}

function uploadSpecialities(){
	var ret = doPost("/pages/post/group.php","method=get");
	ret = ret.split(';');
	for(i=0;i<ret.length-1;i++)
	{
		ret[i] = ret[i].split(',')
	}
	return ret
}

function block_list(obj='groups')
{
	obj_id = 'block_'+obj
	main_blocks = document.getElementsByClassName('main-block main-block-with-objects')
	for(i = 0;i<main_blocks.length;i++) main_blocks[i].style.display = 'none';
	needObj = document.getElementById(obj_id);
	if(document.getElementById("sidebar").className == 'active')
	{
		toggleSidebar();
	}
	//console.log(obj);
	if(needObj==null)
	{

		var main_block = document.createElement("div");
		main_block.id = obj_id;
		main_block.className = 'main-block main-block-with-objects';
		document.body.appendChild(main_block);

		var block_for_create = document.createElement("div");
		block_for_create.className ='block-for-create';
		var create_btn = document.createElement('h2');	
		create_btn.innerText = 'Создать';
		create_btn.id = 'create-btn';

		block_for_create.appendChild(create_btn);		

		if (obj=='groups')
		{			
			create_btn.onclick = function(){block_create("group_now");}		
			create_btn.innerText = 'Создать группу';			
			main_block.appendChild(block_for_create);

			var courses = doPost('pages/post/group_now.php','method=getCourses')			
			var courses = courses.split(';')
			for(i=0;i<courses.length-1;i++)
			{
				var block = courses[i].split(',')
				var course = block[0]
				var count_groups = block[1]				 
				var course_block = document.createElement('div');
				course_block.className = 'submain-block';				

				var btn_course = document.createElement('h2');
				btn_course.id = 'course_'+course;
				btn_course.onclick = function(test){crs = test.target.id.split('_'); uploadGroups(crs[crs.length-1]);}
				btn_course.innerText = course+'-курс (групп:'+count_groups+') '

				var spoiler = document.createElement('span');
				spoiler.id ='vsl_btn_course_'+course;
				spoiler.innerText = '▲'				
				course_block.appendChild(btn_course)
				btn_course.appendChild(spoiler)
				main_block.appendChild(course_block)
			}
		} else if (obj == 'teachers')
		{			
			create_btn.onclick = function(){block_create("teacher");}		
			create_btn.innerText = 'Добавить преподавателя';			
			main_block.appendChild(block_for_create);
			

			/*var block = courses[i].split(',')
			var course = block[0]
			var count_groups = block[1]*/			
			/*var btn_users = document.createElement('h2');
			btn_users.id = 'get_users';
			btn_users.onclick = function(e){*/
			
			var users = doPost('pages/post/teacher.php','method=getUsers');
			var users = users.split(';');				
				//targ = e.target.onclick; targ.onclick = function(){};				
				for(i=0;i<users.length-1;i++)
				{
					var block = document.createElement('div');
					block.className = 'submain-block';
					main_block.appendChild(block);

					user = users[i].split(',');
					var user_block = document.createElement('h2');
					user_block.id = user[0]+"_user_teacher_"+user[2];
					user_block.innerText = user[3]+' ('+user[1]+')';					

					//ADD
					var btn_delete = document.createElement('h2');
					btn_delete.className = "btn_delete"
					btn_delete.id = user[0]+"_user_delete_teacher_"+user[2];
					btn_delete.innerText = "X";

					btn_delete.onclick = function(e)
					{
						id_block = e.target.id.split('_');
						id_teacher_block = id_block[id_block.length-1];
						id_user_block = id_block[0];
						user_name = ''
						user = document.getElementById(id_user_block+'_user_teacher_'+id_teacher_block)
						if(user!=null) user_name = user.innerText;
						if(confirm("Вы точно хотите удалить преподавателя "+user_name+"?"))
						{
							//} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
							t = doPost("/pages/post/teacher.php","method=removeTeacher&teacher_id="+id_teacher_block)
							if (t=='True')
							{
								user.parentElement.remove()								
							} else{
								alert('Не удалось удалить')
							}							
						}
					}
					block.append(btn_delete)
					block.append(user_block);
				}
				var newTeachers = doPost('pages/post/teacher.php','method=getNewTeachers')
				var newTeachers = newTeachers.split(';')
				for(i=0;i<newTeachers.length-1;i++)
				{
					user = newTeachers[i]
					addBlock('teacher',user);					
					/*var block = document.createElement('div');
					block.className = 'submain-block';
					main_block.appendChild(block);
					
					user = newTeachers[i].split(',');
					//console.log(user);
					var user_block = document.createElement('h2');
					user_block.id = "teacher_"+user[0];
					user_block.innerText = user[1]+" (ещё не зарегистрирован)";


					var btn_delete = document.createElement('h2');
					btn_delete.className = "btn_delete"
					btn_delete.id = "delete_teacher_"+user[0];
					btn_delete.innerText = "X";

					btn_delete.onclick = function(e)
					{
						id_block = e.target.id.split('_');
						id_teacher_block = id_block[id_block.length-1];						
						user_name = ''
						user = document.getElementById('teacher_'+id_teacher_block)
						if(user!=null) user_name = user.innerText;
						if(confirm("Вы точно хотите удалить преподавателя "+user_name+"?"))
						{
							//} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
							t = doPost("/pages/post/teacher.php","method=removeTeacher&teacher_id="+id_teacher_block)
							if (t=='True')
							{
								user.parentElement.remove()								
							} else{
								alert('Не удалось удалить')
							}							
						}
					}
					block.append(btn_delete)
					block.append(user_block);*/
				}
			//}			
					


		} 
		else if (obj = 'specialities'){
			create_btn.onclick = function(){block_create("group");}		
			create_btn.innerText = 'Добавить специальность';			
			main_block.appendChild(block_for_create);
			var specs = doPost('/pages/post/group.php','method=get')
			var specs = specs.split(';');

			for(i=0;i<specs.length-1;i++)
			{
				addBlock('spec',specs[i])
				/*spec = specs[i].split(',');

					var btn_delete = document.createElement('h2');
					btn_delete.className = "btn_delete"
					btn_delete.id = "spec_delete_"+spec[0];
					btn_delete.innerText = "X";

					btn_delete.onclick = function(e)
					{
						id_block = e.target.id.split('_');
						id_spec_block = id_block[id_block.length-1];												
						spec = document.getElementById('spec_'+id_spec_block)
						if(spec!=null) spec_name = spec.innerText;
						if(confirm("Вы точно хотите удалить специальность "+spec_name+"?"))
						{
							//} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
							t = doPost("/pages/post/group.php","method=delete&group_id="+id_spec_block)
							if (t=='True')
							{
								spec.parentElement.remove()								
							} else{
								alert('Не удалось удалить')
							}							
						}
					}					

				var block = document.createElement('div');
				block.className = 'submain-block';
				main_block.appendChild(block);
				block.append(btn_delete)
				
				var spec_block = document.createElement('h2');
				spec_block.id = "spec_"+spec[0];
				spec_block.innerText = spec[2]+' ('+spec[1]+')';
				block.append(spec_block);*/
			}

			//console.log(specs)
		}

	}
	else needObj.style.display = 'block';
}

function addBlock(obj="teacher",params)
{	
	if(obj=="teacher"){
		main_block = document.getElementById('block_teachers')
		var block = document.createElement('div');
		block.className = 'submain-block';
		main_block.appendChild(block);
		user = params.split(',');
		main_block.insertBefore(block, main_block.childNodes[1]);			
									
		var user_block = document.createElement('h2');
		user_block.id = "teacher_"+user[0];
		user_block.innerText = user[1]+" (ещё не зарегистрирован)";

		var btn_delete = document.createElement('h2');
		btn_delete.className = "btn_delete"
		btn_delete.id = "delete_teacher_"+user[0];
		btn_delete.innerText = "X";

		btn_delete.onclick = function(e)
		{
			id_block = e.target.id.split('_');
			id_teacher_block = id_block[id_block.length-1];						
			user_name = ''
			user = document.getElementById('teacher_'+id_teacher_block)
			if(user!=null) user_name = user.innerText;
			if(confirm("Вы точно хотите удалить преподавателя "+user_name+"?"))
			{
				//} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
				t = doPost("/pages/post/teacher.php","method=removeTeacher&teacher_id="+id_teacher_block)
				if (t=='True')
				{
					user.parentElement.remove()								
				} else{
					alert('Не удалось удалить')
				}							
			}
		}
		block.append(btn_delete)
		block.append(user_block);
	} else if(obj=="spec"){		
		main_block = document.getElementById('block_specialities')		

		params = params.split(',')
		var btn_delete = document.createElement('h2');
		btn_delete.className = "btn_delete"
		btn_delete.id = "spec_delete_"+params[0];
		btn_delete.innerText = "X";

		btn_delete.onclick = function(e)
		{
			id_block = e.target.id.split('_');
			id_spec_block = id_block[id_block.length-1];												
			spec = document.getElementById('spec_'+id_spec_block)
			if(spec!=null) spec_name = spec.innerText;
			if(confirm("Вы точно хотите удалить специальность "+spec_name+"?"))
			{
				//} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
				t = doPost("/pages/post/group.php","method=delete&group_id="+id_spec_block)
				if (t=='True')
				{
					spec.parentElement.remove()								
				} else{
					alert('Не удалось удалить')
				}							
			}
		}					

		var block = document.createElement('div');
		block.className = 'submain-block';
		main_block.appendChild(block);
		block.append(btn_delete)
		
		var spec_block = document.createElement('h2');
		spec_block.id = "spec_"+params[0];
		spec_block.innerText = params[2]+' ('+params[1]+')';
		block.append(spec_block);

		main_block.insertBefore(block, main_block.childNodes[1]);
	} else if(obj=='student'){
		//'method=studentCreate&group_now_id='+group_now_id.value+'&student_gender='+student_gender.value+'&student_second_name='+student_second_name.value+'&student_name='+student_name.value+'&student_middle_name='+student_middle_name.value+'&student_birth='+student_birth.value+'&student_phone='+student_phone.value+'&student_email='+student_email.value+'&student_info='+student_info.value
		//console.log('student add')
		//console.log(params)
		student = params.split(',');
		students_block = document.getElementById('group_block_students_id_'+student[2]);

		//addBlock('student',outPage+','+group_now_id.value+','+student_gender.value+','+student_second_name.value+','+student_name.value+','+student_middle_name.value+','+student_birth.value+','+student_phone.value+','+student_email.value+','+student_info.value)				
		//student_birth.value+','+student_phone.value+','+student_email.value+','+student_info.value)				
		msg = student[4]+' '+student[5]+' '+student[6]+'\n\n'+(student[7]?'Дата рождения: '+student[7]+'\n':'')+(student[8]?'Телефон: '+student[8]+'\n':'')+(student[9]?'E-mail: '+student[9]+'\n':'')+(student[10]?'Дополнительная информация: '+student[10]+'\n':'')
		//console.log(msg)
		/*let isDown = false;
		let startX;
		let scrollLeft;
		students_block.addEventListener('mousedown', (e) => {
			  isDown = true;  
			  startX = e.pageX - e.target.offsetLeft;
			  scrollLeft = e.target.scrollLeft;
			});
		students_block.addEventListener('mouseleave', () => {
			  isDown = false;  
			});
		students_block.addEventListener('mouseup', () => {
			  isDown = false;  
			});
		students_block.addEventListener('mousemove', (e) => {
			  if(!isDown) return;
			  //e.preventDefault();    
			  const walk = (e.pageX - e.target.offsetLeft - startX) * 3; //scroll-fast
			  e.target.scrollLeft = scrollLeft - walk;  
			});*/

		var student_block = document.createElement('div')
		student_block.className = 'student-block'
		student_block.id = 'student-id-'+student[1];		
		student_block.setAttribute('info',msg)
		student_block.onclick = function(e){
			if (e.target.className!='button button-delete-student' && e.target.className!='student-card-edit student-edit')
			{
						id_block = e.currentTarget.id.split('-');			
						id_student = id_block[id_block.length-1];
					//(($_POST['method']=='studentDelete') && isset($_POST['group_now_id']) && isset($_POST['student_id']))
						student = document.getElementById('student-id-'+id_student)			
						alert(student.getAttribute('info'))
			}
		}

		var student_avatar = document.createElement('div')

		//console.log(params)
		if (student[0] == 'True')
		{		
			var student_card_edit = document.createElement('div');
			student_card_edit.className = 'student-card-edit student-edit';
			student_card_edit.setAttribute('params',student[2]+';'+student[1]);
			student_card_edit.onclick = function(e){block_create('student-edit',e.target.getAttribute('params'));}

			student_avatar.appendChild(student_card_edit);
			var btn_delete = document.createElement('button')
			btn_delete.className = 'button button-delete-student';
			btn_delete.id = student[2]+'-group-delete-student-'+student[1];
			btn_delete.innerText = 'Удалить'
			btn_delete.onclick = function(e){
				id_block = e.target.id.split('-');
				id_group = id_block[0]
				id_student = id_block[id_block.length-1];
				//(($_POST['method']=='studentDelete') && isset($_POST['group_now_id']) && isset($_POST['student_id']))
				student = document.getElementById('student-id-'+id_student)
				//if(student!=null) user_name = user.innerText;
				if(confirm("Вы точно хотите удалить студента?"))
				{
					//} else if (($_POST['method']=='removeTeacher') && (isset($_POST['teacher_id'])) && ($user::status_admin))
					t = doPost("/pages/post/group_now.php","method=studentDelete&group_now_id="+id_group+'&student_id='+id_student);
					if (t=='True')
					{
						student.remove()								
					} else{
						alert('Не удалось удалить')
					}							
				}
							
			}
			student_block.appendChild(btn_delete);
			//students_block.appendChild(student_block)
			
			if(students_block.children.length>=2)
				{students_block.insertBefore(student_block, students_block.childNodes[1]);}
			else
				{students_block.appendChild(student_block);}
		} 
		else{
			if(students_block.children.length>0)
				{students_block.insertBefore(student_block, students_block.childNodes[0]);}
			else
				{students_block.appendChild(student_block);}
			}

		var student_card = document.createElement('div')
		student_card.className = 'student-card'
		student_block.appendChild(student_card)
		
		student_avatar.className = 'student-avatar'
		if(student[3]=='boy')
			{student_avatar.className = student_avatar.className+' student-boy'}
		else{student_avatar.className = student_avatar.className+' student-girl'}
		student_card.appendChild(student_avatar)		

		student_FIO = student[4]+' '+student[5]+' '+student[6]
		var student_info = document.createElement('p')
		student_info.innerText = student_FIO

		student_card.appendChild(student_info)			
	
	}
}

function block_create(obj='group_now',id_obj='')
{
	//console.log(id_obj);
	var id_block = 'create_'+obj+'_'+id_obj;
	if(document.getElementById(id_block)==null)
	{		
		var par_block = document.createElement("div");
		par_block.onmousedown = function(e){if (e.target !== this) return; document.getElementById(id_block).style.display = 'none';}
		par_block.className = 'block-back';
		par_block.id = id_block;		
		var main_block = document.createElement('div');
		main_block.className = 'main-block form';
		par_block.appendChild(main_block);
		var frm = document.createElement('form');
		main_block.appendChild(frm);

		var head1 = document.createElement('h1');
		head1.className = 'caption';
		frm.appendChild(head1);

		var sb_btn = document.createElement('button');
		sb_btn.id = 'create_submit';
		sb_btn.className = 'button';
		sb_btn.type = 'button';
		sb_btn.innerText = 'Создать';
		if(obj == 'group')
		{			
			head1.innerText = 'Добавить специальность';

			var group_name = document.createElement('input')
			group_name.type = 'text'
			group_name.id = 'group-name'
			group_name.placeholder = 'Специальность'
			frm.appendChild(group_name);

			var group_short_name = document.createElement('input')
			group_short_name.type = 'text'
			group_short_name.id = 'group-short-name'
			group_short_name.placeholder = 'Сокращённое название'
			frm.appendChild(group_short_name);

			//<p id='error-code' class='error-message'>Неправильный код регистрации</p>

			var error_message = document.createElement('p')
			error_message.id = 'error-group-name-exists';
			error_message.className = 'error-message';
			error_message.innerText = 'Такое название специальности или сокращённое название уже существует!';
			error_message.style.display = 'none';
			frm.appendChild(error_message);

			var error_message2 = document.createElement('p')
			error_message2.id = 'error-group-name-exists';
			error_message2.className = 'error-message';
			error_message2.innerText = 'Необходимо заполнить все поля!';
			error_message2.style.display = 'none';
			frm.appendChild(error_message2);

			sb_btn.onclick = function(){
				//grp_name = document.getElementById('group-name').value;
				grp_name = group_name.value;
				grp_shrt_name = group_short_name.value;
				outPage = doPost('/pages/post/group.php','method=create&group_name='+grp_name+"&group_short_name="+grp_shrt_name).split(',')
				//console.log(outPage)
				if ((outPage[0] == "True") && (grp_name) && (grp_shrt_name))
					{
						error_message.style.display = 'none'; 
						error_message2.style.display = 'none'; 
						addBlock('spec',outPage[1]+','+grp_shrt_name+','+grp_name)
						document.getElementById(id_block).remove(); 
						alert('Специальность добавлена успешно')
					}
				else
					{
						if((!grp_name) || (!grp_shrt_name))
							{
								error_message2.style.display = 'block'; 
								error_message.style.display = 'none'
							} 							
								else {error_message.style.display = 'block'; error_message2.style.display = 'none'}				
					}
			}
			sb_btn.innerText = 'Добавить';
		
		}
		else if(obj=='group_now')
		{
			var div_spec = document.createElement('div');
			div_spec.className = 'styled-select slate';
			var div_sel = document.createElement('select');									

			/*var default_option = document.createElement('option')
			default_option.innerText = 'Специальность:'
			div_sel.appendChild(default_option);			*/
			div_spec.appendChild(div_sel);		
			frm.appendChild(div_spec);

			specs = uploadSpecialities()
			spec_options = []
			for(i=0;i<specs.length-1;i++)
			{
				var spec_option = document.createElement('option');
				spec_option.innerText = specs[i][2]+' ('+specs[i][1]+')'
				spec_option.value = specs[i][0]
				spec_options.push(spec_option)
				div_sel.appendChild(spec_options[i])
			}

			var inp_num = document.createElement('input')
			inp_num.type = 'number'
			inp_num.id = 'group-num'
			inp_num.placeholder = 'Номер группы'
			//inp_num.value = doPost('/pages/post/group_now.php','method=getFreeNumber&group_id=')
			inp_num.onkeydown = function(){return ((event.keyCode !== 69) && (event.keyCode !== 43) &&(event.keyCode !== 45))};

			var inp_start_year = document.createElement('input')
			inp_start_year.type = 'number'
			inp_start_year.id = 'group-start-year'
			inp_start_year.placeholder = 'Год начала обучения'
			inp_start_year.onkeydown = function(){return ((event.keyCode !== 69) && (event.keyCode !== 43) &&(event.keyCode !== 45))};

			var inp_end_year = document.createElement('input')
			inp_end_year.type = 'number'
			inp_end_year.id = 'group-end-year'
			inp_end_year.placeholder = 'Год окончания обучения'
			inp_end_year.onkeydown = function(){return ((event.keyCode !== 69) && (event.keyCode !== 43) &&(event.keyCode !== 45))};

			frm.appendChild(inp_num)
			frm.appendChild(inp_start_year)
			frm.appendChild(inp_end_year)


			var error_message = document.createElement('p')
			error_message.id = 'error-group-name-exists';
			error_message.className = 'error-message';
			error_message.innerText = 'Необходимо заполнить все поля!';
			error_message.style.display = 'none';
			frm.appendChild(error_message);

			var error_message2 = document.createElement('p')
			error_message2.id = 'error-group-name-exists';
			error_message2.className = 'error-message';
			error_message2.innerText = 'Года должны состоять ровно из 4 цифр!';
			error_message2.style.display = 'none';
			frm.appendChild(error_message2);

			var error_message3 = document.createElement('p')
			error_message3.id = 'error-group-name-exists';
			error_message3.className = 'error-message';
			error_message3.innerText = 'Такая группа уже существует!';
			error_message3.style.display = 'none';
			frm.appendChild(error_message3);


			head1.innerText = 'Создание группы';

			sb_btn.onclick = function(){
				//grp_name = document.getElementById('group-name').value;
				grp_id = spec_options[div_sel.selectedIndex].value;
				grp_number = inp_num.value;
				grp_start_year = inp_start_year.value;
				grp_end_year = inp_end_year.value;
				//console.log(grp_start_year+' '+grp_end_year)
				//doPost('pages/post/group_now.php',"method=create&group_by_number=405&group_id=3&group_start_year=1999&group_end_year=2003")
				outPage = doPost('/pages/post/group_now.php','method=create&group_by_number='+grp_number+'&group_id='+grp_id+'&group_start_year='+grp_start_year+'&group_end_year='+grp_end_year)
				//console.log(outPage)
				if ((outPage == "True") && (grp_id) && (grp_number) && (grp_start_year) && (grp_end_year) && (grp_start_year.length==4) && (grp_end_year.length==4))
					{
						error_message.style.display = 'none';
						error_message2.style.display = 'none';
						error_message3.style.display = 'none'; 
						document.getElementById(id_block).remove(); 
						alert('Группа создана успешно')
					}
				else
					{						
						if(!((grp_id)&&(grp_number)&&(grp_start_year)&&(grp_end_year)))
						{
							error_message2.style.display = 'none'
							error_message3.style.display = 'none'
							error_message.style.display = 'block'							
						} else if((grp_start_year.length<4) || (grp_end_year.length<4))
						{
							error_message.style.display = 'none'
							error_message3.style.display = 'none'
							error_message2.style.display = 'block'							
						} else 
						{
							error_message.style.display = 'none'
							error_message2.style.display = 'none'
							error_message3.style.display = 'block'
						}
					}
				//alert(outPage)
			}
		} else if(obj == 'teacher')
		{			
			head1.innerText = 'Добавить преподавателя';			

			var teacher_second_name = document.createElement('input')
			teacher_second_name.type = 'text'
			teacher_second_name.id = 'teacher-second-name'
			teacher_second_name.placeholder = 'Фамилия'
			frm.appendChild(teacher_second_name);

			var teacher_name = document.createElement('input')
			teacher_name.type = 'text'
			teacher_name.id = 'teacher-name'
			teacher_name.placeholder = 'Имя'
			frm.appendChild(teacher_name);

			var teacher_middle_name = document.createElement('input')
			teacher_middle_name.type = 'text'
			teacher_middle_name.id = 'teacher-middle-name'
			teacher_middle_name.placeholder = 'Отчество'
			frm.appendChild(teacher_middle_name);

			//<p id='error-code' class='error-message'>Неправильный код регистрации</p>
		
			var error_message = document.createElement('p')
			error_message.id = 'error-group-name-exists';
			error_message.className = 'error-message';
			error_message.innerText = 'Необходимо заполнить все поля!';
			error_message.style.display = 'none';
			frm.appendChild(error_message);

			sb_btn.onclick = function(){
				//grp_name = document.getElementById('group-name').value;
				tchr_scnd_name = teacher_second_name.value;
				tchr_name = teacher_name.value;
				tchr_mdl_name = teacher_middle_name.value;				
				outPage = doPost('/pages/post/teacher.php','method=create&teacher_name='+tchr_name+'&teacher_second_name='+tchr_scnd_name+'&teacher_middle_name='+tchr_mdl_name).split(',')				
				regCode = outPage[0]
				if ((outPage != "False") && (tchr_scnd_name) && (tchr_name) && (tchr_mdl_name))
					{
						error_message.style.display = 'none'; 
						//error_message2.style.display = 'none'; 
						document.getElementById(id_block).remove();
						prompt('Преподаватель добавлен успешно\nСообщите данный код - '+regCode+' преподавателю, чтобы он зарегистрировался!',regCode)						
						addBlock(obj="teacher",outPage[1]+','+(tchr_scnd_name) +' '+ (tchr_name) +' '+ (tchr_mdl_name))
					}
				else
					{
						if(!((tchr_scnd_name) && (tchr_name) && (tchr_mdl_name)))
							{								
								error_message.style.display = 'block'
							} 							
								//else {error_message.style.display = 'block'; error_message2.style.display = 'none'}				
					}
			}
			sb_btn.innerText = 'Добавить';
		
		} else  if(obj == 'student')	  	
		{			
			head1.innerText = 'Добавить студента';

			var group_now_id = document.createElement('input')
			group_now_id.type = 'hidden'
			group_now_id.id = 'group-now-id'
			group_now_id.value = id_obj;
			frm.appendChild(group_now_id)


			/*var student_gender_inp = document.createElement('student-gender')
			student_gender_inp.type = 'hidden';
			student_gender_inp.id = 'student-gender-inp'
			student_gender_inp.name = 'student-gender-inp'
			frm.appendChild(student_gender_inp)			*/

			var student_gender = document.createElement('select')			
			student_gender.id = "student-gender"

			var option_boy = document.createElement('option')
			option_boy.innerText = 'Парень'
			option_boy.value = 'boy'			
			student_gender.appendChild(option_boy)

			var option_girl = document.createElement('option')
			option_girl.innerText = 'Девушка'
			option_girl.value = 'girl'
			student_gender.appendChild(option_girl)


			frm.appendChild(student_gender)




			var student_second_name = document.createElement('input')
			student_second_name.type = 'text'
			student_second_name.id = 'student-second-name'
			student_second_name.placeholder = 'Фамилия'
			frm.appendChild(student_second_name);

			var student_name = document.createElement('input')
			student_name.type = 'text'
			student_name.id = 'student-name'
			student_name.placeholder = 'Имя'
			frm.appendChild(student_name);

			var student_middle_name = document.createElement('input')
			student_middle_name.type = 'text'
			student_middle_name.id = 'student-middle-name'
			student_middle_name.placeholder = 'Отчество'
			frm.appendChild(student_middle_name);

			var student_birth = document.createElement('input')
			student_birth.type = 'date'
			student_birth.id = 'student-birth'
			frm.appendChild(student_birth);

			var student_phone = document.createElement('input')
			student_phone.type = "tel"
			student_phone.id = 'student-phone'
			student_phone.placeholder = 'Телефон'
			frm.appendChild(student_phone)

			var student_email = document.createElement('input')
			student_email.type = "tel"
			student_email.id = 'student-email'
			student_email.placeholder = 'E-mail'
			frm.appendChild(student_email)

			var student_info = document.createElement('input')
			student_info.type = "tel"
			student_info.id = 'student-info'
			student_info.placeholder = 'Доп. информация'
			frm.appendChild(student_info)

			//<p id='error-code' class='error-message'>Неправильный код регистрации</p>
		
			var error_message = document.createElement('p')
			error_message.id = 'error-group-name-exists';
			error_message.className = 'error-message';
			error_message.innerText = 'Необходимо заполнить ФИО!';
			error_message.style.display = 'none';
			frm.appendChild(error_message);

			sb_btn.onclick = function(){
				//grp_name = document.getElementById('group-name').value;				
				//group_now_id = document.getElementById('group-now-id').value				
				//isset($_POST['student_gender']) && isset($_POST['student_second_name']) && isset($_POST['student_name']) && isset($_POST['student_middle_name']) && isset($_POST['student_birth']) && isset($_POST['student_phone']) && isset($_POST['student_email']) && isset($_POST['student_info']))				
				outPage = doPost('/pages/post/group_now.php','method=studentCreate&group_now_id='+group_now_id.value+'&student_gender='+student_gender.value+'&student_second_name='+student_second_name.value+'&student_name='+student_name.value+'&student_middle_name='+student_middle_name.value+'&student_birth='+student_birth.value+'&student_phone='+student_phone.value+'&student_email='+student_email.value+'&student_info='+student_info.value)				
				addBlock('student',outPage+','+group_now_id.value+','+student_gender.value+','+student_second_name.value+','+student_name.value+','+student_middle_name.value+','+student_birth.value+','+student_phone.value+','+student_email.value+','+student_info.value)				
				document.getElementById(id_block).remove(); 				

				/*tchr_scnd_name = teacher_second_name.value;
				tchr_name = teacher_name.value;
				tchr_mdl_name = teacher_middle_name.value;				
				outPage = doPost('/pages/post/teacher.php','method=create&teacher_name='+tchr_name+'&teacher_second_name='+tchr_scnd_name+'&teacher_middle_name='+tchr_mdl_name)
				if ((outPage != "False") && (tchr_scnd_name) && (tchr_name) && (tchr_mdl_name))
					{
						error_message.style.display = 'none'; 
						//error_message2.style.display = 'none'; 
						document.getElementById(id_block).remove(); 
						prompt('Преподаватель добавлен успешно\nСообщите данный код - '+outPage+' преподавателю, чтобы он зарегистрировался!',outPage)						
					}
				else
					{
						if(!((tchr_scnd_name) && (tchr_name) && (tchr_mdl_name)))
							{								
								error_message.style.display = 'block'
							} 							
								//else {error_message.style.display = 'block'; error_message2.style.display = 'none'}				
					}*/
			}
			sb_btn.innerText = 'Добавить';
		
		} else  if(obj == 'student-edit')	  	
		{			
			head1.innerText = 'Редактировать';

			student = id_obj.split(';');

			student_full = doPost('/pages/post/group_now.php','method=studentGet&student_id='+student[1]).split(';')			
			console.log(student_full);
			/*var group_now_id = document.createElement('input')
			group_now_id.type = 'hidden'
			group_now_id.id = 'group-now-id'
			group_now_id.value = student[0];
			frm.appendChild(group_now_id)

			var student_id = document.createElement('input')
			student_id.type = 'hidden'
			student_id.id = 'student-edit-id'
			student_id.value = student[1];
			frm.appendChild(student_id)*/


			/*var student_gender_inp = document.createElement('student-gender')
			student_gender_inp.type = 'hidden';
			student_gender_inp.id = 'student-gender-inp'
			student_gender_inp.name = 'student-gender-inp'
			frm.appendChild(student_gender_inp)			*/

			var student_gender = document.createElement('select')			
			student_gender.id = "student-gender-"+student[1]


			
			var option_boy = document.createElement('option')
			option_boy.innerText = 'Парень'
			option_boy.value = 'boy'			
			student_gender.appendChild(option_boy)

			var option_girl = document.createElement('option')
			option_girl.innerText = 'Девушка'
			option_girl.value = 'girl'
			student_gender.appendChild(option_girl)

			student_gender.value = student_full[7];			

			frm.appendChild(student_gender)




			var student_second_name = document.createElement('input')
			student_second_name.type = 'text'
			student_second_name.id = 'student-second-name-'+student[1]
			student_second_name.placeholder = 'Фамилия'
			student_second_name.value = student_full[1]
			frm.appendChild(student_second_name);

			var student_name = document.createElement('input')
			student_name.type = 'text'
			student_name.id = 'student-name-'+student[1]
			student_name.placeholder = 'Имя'
			student_name.value = student_full[0]
			frm.appendChild(student_name);

			var student_middle_name = document.createElement('input')
			student_middle_name.type = 'text'
			student_middle_name.id = 'student-middle-name-'+student[1]
			student_middle_name.placeholder = 'Отчество'
			student_middle_name.value = student_full[2]
			frm.appendChild(student_middle_name);

			var student_birth = document.createElement('input')
			student_birth.type = 'date'
			student_birth.id = 'student-birth-'+student[1]
			student_birth.value = student_full[5]
			frm.appendChild(student_birth);

			var student_phone = document.createElement('input')
			student_phone.type = "tel"
			student_phone.id = 'student-phone-'+student[1]
			student_phone.placeholder = 'Телефон'
			student_phone.value = student_full[3]
			frm.appendChild(student_phone)

			var student_email = document.createElement('input')
			student_email.type = "tel"
			student_email.id = 'student-email-'+student[1]
			student_email.placeholder = 'E-mail'
			student_email.value = student_full[4]
			frm.appendChild(student_email)

			var student_info = document.createElement('input')
			student_info.type = "tel"
			student_info.id = 'student-info-'+student[1]
			student_info.placeholder = 'Доп. информация'
			student_info.value = student_full[6]
			frm.appendChild(student_info)

			//<p id='error-code' class='error-message'>Неправильный код регистрации</p>
		
			var error_message = document.createElement('p')
			error_message.id = 'error-group-name-exists';
			error_message.className = 'error-message';
			error_message.innerText = 'Необходимо заполнить ФИО!';
			error_message.style.display = 'none';
			frm.appendChild(error_message);

			sb_btn.id = 'btn_edit_'+student[0]+'_'+student[1]
			sb_btn.onclick = function(e){
				//grp_name = document.getElementById('group-name').value;				
				//group_now_id = document.getElementById('group-now-id').value				
				//isset($_POST['student_gender']) && isset($_POST['student_second_name']) && isset($_POST['student_name']) && isset($_POST['student_middle_name']) && isset($_POST['student_birth']) && isset($_POST['student_phone']) && isset($_POST['student_email']) && isset($_POST['student_info']))				
				id = e.target.id.split('_')
				group_now_id = id[id.length-2]
				student_id = id[id.length-1]
				outPage = doPost('/pages/post/group_now.php','method=studentEdit&student_id='+student_id+'&group_now_id='+group_now_id+'&student_gender='+student_gender.value+'&student_second_name='+student_second_name.value+'&student_name='+student_name.value+'&student_middle_name='+student_middle_name.value+'&student_birth='+student_birth.value+'&student_phone='+student_phone.value+'&student_email='+student_email.value+'&student_info='+student_info.value)				
				console.log(outPage);
				//addBlock('student',outPage+','+student[0]+','+student_gender.value+','+student_second_name.value+','+student_name.value+','+student_middle_name.value+','+student_birth.value+','+student_phone.value+','+student_email.value+','+student_info.value)				
				document.getElementById(id_block).remove(); 				

				/*tchr_scnd_name = teacher_second_name.value;
				tchr_name = teacher_name.value;
				tchr_mdl_name = teacher_middle_name.value;				
				outPage = doPost('/pages/post/teacher.php','method=create&teacher_name='+tchr_name+'&teacher_second_name='+tchr_scnd_name+'&teacher_middle_name='+tchr_mdl_name)
				if ((outPage != "False") && (tchr_scnd_name) && (tchr_name) && (tchr_mdl_name))
					{
						error_message.style.display = 'none'; 
						//error_message2.style.display = 'none'; 
						document.getElementById(id_block).remove(); 
						prompt('Преподаватель добавлен успешно\nСообщите данный код - '+outPage+' преподавателю, чтобы он зарегистрировался!',outPage)						
					}
				else
					{
						if(!((tchr_scnd_name) && (tchr_name) && (tchr_mdl_name)))
							{								
								error_message.style.display = 'block'
							} 							
								//else {error_message.style.display = 'block'; error_message2.style.display = 'none'}				
					}*/
			}
			sb_btn.innerText = 'Редактировать';
		
		} else if(obj == 'password-edit')
		{			
			head1.innerText = 'Изменить пароль';

			var old_pass = document.createElement('input')
			old_pass.type = 'password'
			old_pass.id = 'old-pass'
			old_pass.placeholder = 'Текущий пароль'
			frm.appendChild(old_pass);

			var new_pass = document.createElement('input')
			new_pass.type = 'password'
			new_pass.id = 'pass'
			new_pass.placeholder = 'Новый пароль'
			frm.appendChild(new_pass);

			var new_pass2 = document.createElement('input')
			new_pass2.type = 'password'
			new_pass2.id = 'pass2'
			new_pass2.placeholder = 'Повтор паоля'
			frm.appendChild(new_pass2);

			//<p id='error-code' class='error-message'>Неправильный код регистрации</p>			

			var error_message = document.createElement('p')
			error_message.id = 'error-group-name-exists';
			error_message.className = 'error-message';
			error_message.innerText = 'Необходимо заполнить все поля!';
			error_message.style.display = 'none';
			frm.appendChild(error_message);

			sb_btn.onclick = function(){
				//grp_name = document.getElementById('group-name').value;								
				outPage = doPost('/php/options_save.php',"pass="+old_pass.value+'&pass-new='+new_pass.value+'&pass-new2='+new_pass2.value)
				//console.log(outPage)				
				if(old_pass.value && new_pass.value && new_pass2.value)				
				{
						error_message.style.display = 'none'; 												
						document.getElementById(id_block).remove(); 
						alert(outPage)
					}
				else
					{
						error_message.style.display = 'block'
					}
			}
			sb_btn.innerText = 'Изменить';
		
		}
		 
		frm.appendChild(sb_btn);
		document.body.appendChild(par_block);
	}
	 else{
	 	if(obj == 'student')
	 		document.getElementById('group-now-id').value = id_obj;
	 	document.getElementById(id_block).style.display = 'block';

	 }

}

/*function hideGroups(course)
{
	course_block.onclick = 'showGroups("'+course+'")';
}*/