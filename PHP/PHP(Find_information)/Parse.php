<?php 
	
	//Проверить, является ли ссылка обрезанной /page или полной ссылкой website.ru/page
	function Out_Link($Link)
	{
		try{
			if(strpos($Link,'http://')>-1) {return true;}
			else if (strpos($Link,'https://')>-1) {return true;}
			$PosSlash = strpos($Link,'/');
			$PosDot = strpos($Link,'.');
			if(substr($Link,0,2)==="//") {$outLink = true;}
			else if(!$PosDot) {$outLink = false;}
			else if(!$PosSlash) {$outLink = true;}
			else if ($PosDot<$PosSlash) {$outLink = true;}
			else {$outLink = false;}
		} catch (Exception $e) {$outLink = false;}
				
		return $outLink;
	}
	
	//Обрезать ссылку. Например: http://website.ru/page1 = website.ru
	function Cut_Domain($Link,$RmJustHttp)
	{
		if(strpos($Link,'http://')>-1){$Link = substr($Link,strpos($Link,'//')+2);}
		if(strpos($Link,'https://')>-1){$Link = substr($Link,strpos($Link,'//')+2);}
		if(strpos($Link,'www.')===0){$Link = substr($Link,strpos($Link,'.')+1);}
		if(!$RmJustHttp)
		if(strpos($Link,'/')){$Link = substr($Link,0,strpos($Link,'/'));}
		return $Link;
		//print($Link . "<br>");
	}
	
	//Добавить http:// к сайту website.ru = http://website.ru
	//Без http:// не работает функция загрузки сайта file_get_contents
	function Add_http(&$Link,$isHttps)
	{
		if(strpos($Link,'http')!==0)
		{
			if($isHttps){$Link = "https://" . $Link;}
			else {$Link = "http://" . $Link;}
		}
	}

	//Функция для парсинга href ссылок на сайте
	function Get_Links(&$HTML,&$Links)
	{
		$href = 'href="';
		//$Links = [];
		while(strpos($HTML, $href))
		{
			$HTML = substr($HTML,strpos($HTML, $href)+strlen($href),strlen($HTML)-strpos($HTML, $href)+strlen($href));
			$Link = substr($HTML,0,strpos($HTML,'"'));			
			//print("   strpos($Link,'//') = ".strpos($Link,'//')."<br>");
			if((!(strpos($Link,'http://')>-1)) && (!(strpos($Link,'https://')>-1)))
				$Link = str_replace('//','',$Link);
			if(($Link !== '/')){
			if((!in_array($Link,$Links)))// && ($Link[0] !== '#'))
				{
					$Link = Cut_Domain($Link,true);
					//testEchoLink($Link,false);
					array_push($Links,$Link);
					//print(count($Links));
				}
			}
			//echo "AFTER!!! "; testEchoLink($Link,false);
			
		}
		//foreach($Links as $i) print($i);
		//return $Links;
	}
	
	//Получение уровня ссылки
	//Пример /page1/some_topic - 2 уровень
	//Пример website.ru/page1 - 0 уровень. Чтобы
	//   можно было проверить, не является ли сайт внешним.
	function Get_Level(&$Link)
	{
		$Level = 1;
		try{
			if(substr($Link,0,2)==="//"){$Level = -1;}
			else 
			{
				$Level = substr_count($Link,'/');
				if(substr($Link,-1)==="/") {$Level = $Level - 1;}
				if($Link[0]!=="/") {if(Out_Link($Link)) {$Level = 0;} else $Level++;}
			}
		} catch(Exception $e) {$Level = 0;}
		Return $Level;
	}
	
	//Получение уровня ссылки
	//Пример website.ru/page1 - 1 уровень
	function Get_Level_With_Domain(&$Link)
	{
		//$Level = 0;
		$Level = substr_count($Link,'/');
		if(substr($Link,-1)==="/") {$Level = $Level - 1;}
		Return $Level;
	}
	
	//Загрузка кода
	function Get_HTML(&$Link)
	{
		//Массив для проверки сайта на Https соединение
		$arrContextOptions=array(
			"ssl"=>array(
				"verify_peer"=>false,
				"verify_peer_name"=>false,
			),
		);
		/*'http'=>array(
				'method'=>"GET",
				'header'=> "User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.111 Safari/537.36\r\n",
			),*/
		//sleep(1);
		$HTML = "";
		
		/*$options = array[
			  'http'=>array[
				'method'=>"GET",
				'header'=> "User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.111 Safari/537.36\r\n"
		  ]
		];*/
		//$context = stream_context_create($opts);
		
		//Загрузка HTML сайта
		//print($HTML);
		try{$HTML = mb_strtolower(file_get_contents($Link, false, stream_context_create($arrContextOptions)));}
		catch(Exception $e) {}
		//print($HTML);
		/*if( $curl = curl_init() ) {
			curl_setopt($curl, CURLOPT_URL, $Link);
			curl_setopt($curl, CURLOPT_RETURNTRANSFER,true);
			$HTML = curl_exec($curl);
			//echo $out;
			curl_close($curl);
	   }*/
		Return $HTML;
	}
	
	
	//Поиск фразы внутри сайта
	function Parse_Site(&$Link,$isHttps,&$Phrase,&$MaxLevel,&$gates,&$FoundInf)
	{
		if($Phrase === ""){return false;}
		//Обрезаем ссылку и оставляем только главную страницу http://website.ru
		$Link = Cut_Domain($Link,false);
		Add_http($Link,$isHttps);
		//Загружаем код главной страницы
		$HTML = Get_HTML($Link);
		$HTMLMainPage = $HTML;
				if(Find_Information($HTMLMainPage,$Phrase))
						//{if(!in_array($Links[$i],$FoundInf))
							{
								//print("Founded in : ".$Links[$i]."<br>");
								echo("<li class='Founded'><a href='".$Link."'>".$Link."</a></li>");
								//array_push($FoundInf,$Links[$i]);
							}		
		//Парсим на сайте href ссылки
		//$Links = Get_Links($HTML);
		$Links = [];
		Get_Links($HTML,$Links);
		//print("<br><br><hr> AFTER: ".count($Links));
		//print("COUNT : ". count($Links));
		//print(count($Links));
		//print($Link);
		
		//Для каждой найденной ссылки ...
		for($i=0;$i<count($Links);$i++)
		{
			//print("Added = ".$Links[$i]."<br>");
			//Проверяем уровень ссылки.
			//Например website.ru/page3 - сыллка с одной вкладкой page3
			//   а значит ссылка первого уровня
			//website.ru/page2/some_topic/image.png - 3 уровня
			$Level = Get_Level($Links[$i]);
				if($Level === 0)
				{	//Функция которую я написал Get_Level возвращает уровень 0.
					//	Если в ссылке есть домен. anySite.ru/page1 - 0 уровень
					if(Out_Link($Links[$i]))
					{
						//Обрезаем ссылку для сравнения с главной ссылкой.
						//	Чтобы проверить, не внешняя ли это ссылка
						$tmp = Cut_Domain($Links[$i],false);
						Add_http($tmp,$isHttps);
						if($tmp === $Link) 
						{
							$Level = Get_Level_With_Domain($Links[$i]);
							Add_http($Links[$i],$isHttps);
							//print("LEVEL new".$Links[$i]);
						}				
					}
				} else if($Links[$i][0]!=="/")
							{$Links[$i] = $Link.'/'.$Links[$i];}
						else {$Links[$i] = $Link.$Links[$i];}
			//Если ссылка не проходила проверку...
			if(!in_array($Links[$i],$gates))
			{				
				//И ссылка входит в диапазон уровня...
				//if(($Level>0) && ($Level<=$MaxLevel))
				//print("Added2 = ".$Links[$i]."<br>");
				//if(false)
				if(($Level>0) && ($Level<=$MaxLevel))
				{
					//Add_http($Links[$i],$isHttps);
					//print("<hr>".$Links[$i]."<hr>");
					//Говорим что ссылка проверена
					array_push($gates,$Links[$i]);
					//Загружаем код
					$HTML = Get_HTML($Links[$i]);
					$HTMLparse = $HTML;
					//И если фраза найдена в коде
					//То выводим ссылку
					if(Find_Information($HTMLparse,$Phrase))
						//{if(!in_array($Links[$i],$FoundInf))
							{
								//print("Founded in : ".$Links[$i]."<br>");
								echo("<li class='Founded'><a href='".$Links[$i]."'>".$Links[$i]."</a></li>");
								//array_push($FoundInf,$Links[$i]);
							}
						//}
						
					//Ищем на сайте новые ссылки, и добавляем
					//          если их нет в главном массиве
					//$NewLinks = Get_Links($HTML);
					Get_Links($HTML,$Links);
					//print("<br><br><hr>".count($Links));
					/*for($j=0;$j<count($NewLinks);$j++)
					{	
						if(!in_array($NewLinks[$j],$Links))							
						{
							array_push($Links,$NewLinks[$j]);
						}
					}*/
				}
			}
		}
	}
	
	//Функция поиска фразы в HTML коде
	function Find_Information(&$HTML,&$Phrase)
	{
		try
		{			
		    //Заменить все большие буквы маленькими(Изменение регистра).
			$HTML = mb_strtolower(strip_tags($HTML));
			/*$MaxPercentErrors = 20;
			$MaxErrors = round(($MaxPercentErrors/100)*strlen($Phrase));
			$Mistakes = 0;
			$isPhrase = false;
			$LenPhrase = strlen($Phrase);*/
			
			$Founded = false;
			//Если фраза найдена, то говорим true
			if(strpos($HTML,$Phrase)>-1){$Founded = true;}
			/*if($Founded) {print("I am Found");}
			else print("NOT FOUND");
			print(" ".$Phrase);
			print("<br>");*/
			/*if($LenPhrase>0)
			for($i=0;$i<strlen($HTML)-1;$i++)
			{
				if((!$isPhrase) && ($HTML[$i]===$Phrase[0]))
					{$StartPos = $i; $Mistakes = 0; $isPhrase = true;}
				else if($isPhrase) 
					{
						//print("<br>".$HTML[$i]."   ".$Phrase[$i-$StartPos]);
						if($HTML[$i]!==$Phrase[$i-$StartPos])
							{$Mistakes++; if($Mistakes>$MaxErrors){$isPhrase = false;}}
						else if($i-$StartPos >= $LenPhrase)
							{$Founded = true; print("FOUNDED IN FUNCTION FIND_INFORMATION<br>"); return $Founded;}
						//else if($HTML[$i]===$Phrase[$i-$LenPhrase])
					}
			} $LastLen = ($i-$StartPos)+($MaxErrors-$Mistakes);
			if ($LastLen >= $LenPhrase) $Founded = true;*/
			//print($LastLen);
		} catch (Exception $e) {}
		return $Founded;
	}
	
	//Проверка. В ссылке https или http
	function Check_HTTPS($Link)
	{
		$isHttps = false;
		if(strpos($Link,"https://")>-1){$isHttps = true;}
		return $isHttps;
	}
	
	//Максимальное время работы
	function Time_of_work($seconds)
	{
		ini_set('max_execution_time',$seconds);
	}
	
	//Отключить вывод ошибок
	function DisableErrorLogging()
	{
		error_reporting(0);
	}
	
	//Изменить название вкладки на - поиск завершён.
	function SearchEnded()
	{
		echo '<script type="text/javascript">',
				'document.title = "Поиск завершён";',
				'</script>';
	}
	
	//Функция для тестирования кода
	//Проверка найденных и сортированных ссылок
	function testEchoLink(&$Link,$sorted)
	{
		if ($sorted){echo "sorted_href=";}
		else echo 'href=';
		echo $Link."<br>";
	}
	
	SearchEnded();
	DisableErrorLogging();
	//Берём данные с формы
	$time = $_GET['maxtime'];
	$Link = mb_strtolower($_GET['website']);
	$Phrase = mb_strtolower($_GET['phrase']);
	$MaxLevel = $_GET['maxlvl'];
	
	Time_of_work($time);
	$isHttps = Check_HTTPS($Link);
	if(!ctype_digit($MaxLevel)){$MaxLevel = 1;}
	$gates = [];
	$FoundInf = [];
	
	//print("Start");
	echo("<a href='/'>Вернуться</a>");
	
	echo("<div id='Header-msg'>");
	echo('<p>Фраза <b>"'.$_GET['phrase'].'"</b> найдена в следующих ссылках(<b><i>Если ссылок нет, то ничего найти не удалось</i></b>):');
	echo("</div>");
	
	/*$Link2 = "http://miped.ru";
	$HTML = Get_HTML($Link2);
	print($HTML);*/
	//if (Out_Link("https://vk.com")) print("YEEEEEEEEEEEEEES");
	Parse_site($Link,$isHttps,$Phrase,$MaxLevel,$gates,$FoundInf);
	echo("<hr>");
	//$HTMLparse = Get_HTML($Link);
	//print($HTMLparse);
	//if(Find_Information($HTMLparse,$Phrase)){ echo("<hr><hr><hr>РАБОТАЕТ");}
	//print("Ended");
?>