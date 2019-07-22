<?php
//print_r($user);
//$user->teacher->setBirth("1999-5-31");
//$user->teacher->teacher_update();


echo '<div class="data-form">
	<form method="post" action="/php/options_save.php">';
if(is_object($user->teacher))
{
	$birthDay = $user->teacher->getBirthDay();
	$birthMonth = $user->teacher->getBirthMonth();
	$birthYear = $user->teacher->getBirthYear();

	$monthes = ["Месяц","Январь","Февраль","Март","Апрель","Май","Июнь","Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"];
	$maxYears = 120;
	$yearNow = date('Y');
	$birthOptions = '<select name="day">';
	for($day=0;$day<=31;$day++)
	{
		$birthOptions = $birthOptions.'<option value="'.$day.'" ';
		if ($birthDay == $day)
			$birthOptions = $birthOptions.'selected';
		if($day==0)
			$birthOptions = $birthOptions.'>День</option>';
		$birthOptions = $birthOptions.'>'.$day.'</option>';
	}
	$birthOptions = $birthOptions .'</select><select name="month">';
	for($month=0;$month<count($monthes);$month++)
	{
		$strMonth = $month;
		if($month<10)
			$strMonth = '0'.$strMonth;
		$birthOptions = $birthOptions.'<option value="'.$strMonth.'" ';
		if ($birthMonth == $strMonth)
			$birthOptions = $birthOptions.'selected';
		$birthOptions = $birthOptions.'>'.$monthes[$month].'</option>';
	}
	$birthOptions = $birthOptions .'</select><select name="year">';
	$birthOptions = $birthOptions.'<option value="0">Год</option>';
	for($year=$yearNow;$year>$yearNow-$maxYears;$year--)
	{	
		$birthOptions = $birthOptions.'<option value="'.$year.'" ';
		if ($birthYear == $year)
			$birthOptions = $birthOptions.'selected';
		$birthOptions = $birthOptions.'>'.$year.'</option>';
	}
	$birthOptions = $birthOptions .'</select><br>';


	//echo $birthYear." ".$birthMonth." ".$birthDay;
	//$user->teacher->teacher_update();
	//$birth = $user->teacher->getBirth();

	echo '<!--<input class="input-field" value="'.$user->teacher->getPhone().'" placeholder="Телефон" type="text" name="phone"><br>
		<input class="input-field" value="'.$user->teacher->getEmail().'" placeholder="E-mail@mail.dom" type="text" name="email"><br>
		'.$birthOptions.'		    -->';
}
echo	'<input class="input-field" placeholder="Новый пароль" type="password" name="pass-new"><br>
	    <input class="input-field" placeholder="Повтор нового пароля" type="password" name="pass-new2"><br>
	    <input class="input-field" placeholder="Текущий пароль" type="password" name="pass"><br>
	    <input type="submit" value="Сохранить изменения">
	</form>
</div>';