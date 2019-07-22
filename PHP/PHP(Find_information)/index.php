<html>
<head>
	<link rel='stylesheet' href='style.css'>
	<script>
		//var sBut = document.getElementById("subBut");		
		function change(){			
			var Stmr = document.getElementById("start-tmr");
			var mtime = document.getElementById("max-time");
			var t = parseInt(mtime.value,10);
			//subBut.innerHTML = '<div style="color:red;" id="update" color="red" onload="timer()">Оставшееся время на поиск:<div id="t">'+t+'</div></div>';
			Stmr.innerHTML = 'Осталось искать <span style="color:red;" id="t">'+t+'</span> с.';
			
			window.setTimeout("timer()",1000);			
		}
		
		function timer(){
			var tmr = document.getElementById("t");
			var t = tmr.textContent;			
			t--;
			if(t>-1) tmr.innerHTML = t;
			
			window.setTimeout("timer()",1000);
		}
	</script>


</head>
<body>
	<div align="center" id="main-Block">
		<h1>Поиск фразы</h1>
		<form action="Parse.php">
		Ссылка:<br>
		<input type="text" name="website" placeholder="http://site.ru" value=""/><br><hr>
		Фраза:<br>
		<input type="text" name="phrase" placeholder="..." value=""/><br><hr>
		Максимальный уровень ссылки:<br>
		<input type="text" name="maxlvl" value="3"/><br><hr>
		Максимальное время в секундах, на поиск фразы:<br>
		<input id="max-time" type="text" name="maxtime" value="100"/><br><hr>
		<div id='subBut'><input onclick='document.title = "Идёт поиск фразы...";this.style.display="none"; change();' type="submit" value="Искать"/></div>
		<span id="start-tmr"></span>
		</form>
	</div>
</body>
</html>

<!--  -->