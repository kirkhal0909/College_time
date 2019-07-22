<?php
function sort_array($array,$by_column=-1)
{
	//create_function('$a,$b', $comparer)	
	$GLOBALS['$strcmp_rus_by_column'] = $by_column;
    usort($array, 'strcmp_rus');
    return $array;
}

function strcmp_rus($v1, $v2)
{	
	if($GLOBALS['$strcmp_rus_by_column']>=0)
	{		
		$v1 = $v1[$GLOBALS['$strcmp_rus_by_column']];
		$v2 = $v2[$GLOBALS['$strcmp_rus_by_column']];
	}
    if (is_array($v1) AND is_array($v2))
    {
        $v1 = reset($v1);
        $v2 = reset($v2);
    }
    $v1 = mb_string_to_array($v1);
    $v2 = mb_string_to_array($v2);      
    
    $abc = array('0','1','2','3','4','5','6','7','8','9','А','а','Б','б','В','в','Г','г','Д','д','Е','е','Ё','ё','Ж','ж','З','з','И','и','Й','й','К','к','Л','л','М','м','Н','н','О','о','П','п','Р','р','С','с','Т','т','У','у','Ф','ф','Х','х','Ц','ц','Ч','ч','Ш','ш','Щ','щ','Ь','ь','Ю','ю','Я','я'); 
    
    $len = min(count($v1), count($v2));
    
    for ($i = 0; $i < $len; $i++)
    {
        $abc_len = $s1 = $s2 = count($abc);                
        for ($j = 0; $j < $abc_len; $j++) if ($v1[$i] == $abc[$j]) $s1 = $j;
        for ($k = 0; $k < $abc_len; $k++) if ($v2[$i] == $abc[$k]) $s2 = $k;
        if ($s1 < $s2) return -1;
        else if ($s1 > $s2) return 1;    
    }
    return 0;
}

function mb_string_to_array($string) 
{ 
    $strlen = mb_strlen($string); 
    while ($strlen) 
    { 
        $array[] = mb_substr($string, 0, 1, 'UTF-8'); 
        $string = mb_substr($string, 1, $strlen, 'UTF-8'); 
        $strlen = mb_strlen($string); 
    } 
    return $array; 
}

//$example=array(["4","","банка"],["3","","Борис"],["2","","вид"],["1","","анкета"]);  
//print_r(sort_array($example,2));

?>