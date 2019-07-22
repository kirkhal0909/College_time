inps = document.getElementsByTagName('input');
for(i=0;i<inps.length;i++)
{	
	inps[i].addEventListener("keyup", function(event) {		
	  if (event.keyCode === 13) {	    
	    event.preventDefault();	    
	    document.getElementById("login-submit").click();
	  }
	});
}

function showAuth(){
	document.getElementById('error-msg').classList.remove("show-error-message");
	//console.log(document.getElementById('error-msg'));
	document.getElementById('login-form-caption').innerText = 'Авторизация';
	document.getElementById('pass2').type = 'hidden';
	document.getElementById('reg-code').type = 'hidden';
	document.getElementById('show-auth-button').classList.add("active");
	document.getElementById('show-reg-button').classList.remove("active");
	document.getElementById('error-pass2').classList.remove("show-error-message");
	s = document.getElementById('login-submit');
	s.innerText = 'Войти';
	s.onclick = doAuth;
}

function showReg(){
	document.getElementById('login-form-caption').innerText = 'Регистрация';
	document.getElementById('pass2').type = 'password';
	document.getElementById('reg-code').type = 'text';
	document.getElementById('show-auth-button').classList.remove("active");
	document.getElementById('show-reg-button').classList.add("active");	
	document.getElementById('error-pass').classList.remove("show-error-message");
	s = document.getElementById('login-submit')
	s.innerText = 'Зарегистрироваться';	
	s.onclick = doReg;
}

function doAuth(){	
	var phrase_to_reload = 'reload';

	var http = new XMLHttpRequest();
	http.open("POST", "/php/login.php", false);
	http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
	var params = "login="+document.getElementById('login').value+"&pass="+document.getElementById('pass').value;	
	http.send(params);	
	var t = http.responseText;	
	if(t==phrase_to_reload)
	{
		document.location.href = '/';
	} else{
		document.getElementById('error-pass').classList.add("show-error-message");
	}
}

function doPost(href="/",params=""){
	var http = new XMLHttpRequest();
	http.open("POST", href, false);	
	http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');	
	http.send(params);		
	var t = http.responseText; 
	return t;
}

function doReg(){	
	var phrase_to_reload = 'reload';	
	var params = "login="+document.getElementById('login').value+"&pass="+document.getElementById('pass').value+"&pass2="+document.getElementById('pass2').value+"&code="+document.getElementById('reg-code').value;
	t = doPost('/php/login.php',params)
	if(t==phrase_to_reload)
	{
		document.location.href = '/';
	} else
	{

		errLbl = document.getElementById('error-msg');
		//errLbl.style.display = 'block';
		errLbl.innerText = t;
		console.log(t);
		errLbl.classList.add("show-error-message");
	}
}