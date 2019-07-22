<?php
include_once($_SERVER['DOCUMENT_ROOT'].'/php/models/group_uniq.php');


echo '<script type="text/javascript">block_list("groups")</script>';
/*echo "<div class='block-for-create'>
			<h2 id='create-btn' onclick='block_create(\"group_now\")'>Создать группу <!--<span id='vsl_btn_create'>▲</span>--></h2>
		</div>";

$courses = queryCountCourses();
foreach ($courses as $course => $count) {
	echo "<div class='submain-block'>
			<h2 id='course_".$course."' onclick='uploadGroups(\"".$course."\")'>".$course."-курс (групп:".$count.") <span id='vsl_btn_course_".$course."'>▲</span></h2>
				
				<div id='course_block_".$course."'class='submain-block-with-objects'>
					<h2 class='group-name'>• 	" .$course."-курс (групп:".$count.") ▼</h2>
					<h2 class='group-name'>".$course."-курс (групп:".$count.") ▼</h2>
				</div>
		</div>";
}*/
//echo "1-курс (12 групп) ▼</h2></div>";
//print_r($courses);