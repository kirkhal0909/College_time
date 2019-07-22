/*

	https://vk.com/kirkhal

*/

delay = 6800

if_like_error_try_times = 3

function doPost(href='/',params="",request="POST"){	
	var http = new XMLHttpRequest()
	http.open(request, href, false)	
	http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded')				
	http.send(params)	
	var t = http.responseText
	return t
}


hrefPhoto = 'https://vk.com/al_photos.php'
hrefFriends = 'https://vk.com/al_friends.php'

hrefWall = 'https://vk.com/al_wall.php'

hrefMembers = 'https://vk.com/al_page.php'

hrefLike = 'https://vk.com/like.php'

function doLike(hash_photo,id_photo)
{
	ajaxLike = doPost(hrefLike,"wall=2&act=a_do_like&al=1&from=photo_viewer&hash="+hash_photo+"&object=photo"+id_photo)
	if(ajaxLike.indexOf('like')!=-1)
	{		
		window.allLikes+=1
		console.log("	"+window.allLikes+" likes")
		return true
	} else{
		console.log('Like error')
		return false
	}
}

function tryDoLikeAgain()
{
	if(window.tries>0)
	{
		setTimeout(function(){
				tries-=1			
				if(doLike(window.hash_photo,window.id_photo))
				{
					window.wait_before_next_like = false
				} else{
					tryDoLikeAgain()
				}				
		},window.constDelay*2+Math.random()*1000)
	} else{
		window.wait_before_next_like = false
	}
}

function findPhotoAndDoLike(link){
	window.wait_before_next_like = true
	/*var http = new XMLHttpRequest()
	http.open("GET", link, false)	
	http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded')				
	http.send(params)	
	ajaxPage = http.responseText*/
	ajaxPage = doPost(link,'',"GET")

	startPos = 'link" href="/photo'
	pos = ajaxPage.indexOf(startPos)+startPos.length	
	if(pos-startPos.length==-1)
	{
		window.wait_before_next_like = false
		return;
	}	
	id_photo = ajaxPage.substring(pos, ajaxPage.indexOf('"',pos))
	delay = window.constDelay/2
	setTimeout(function(){
		ajaxPhoto = doPost("https://vk.com/photo"+id_photo,'',"GET")	

		startPos = "photo"+id_photo+"', '"
		pos = ajaxPhoto.indexOf(startPos)+startPos.length	
		if(pos-startPos.length==-1)
		{
			window.wait_before_next_like = false
			return;
		}
		hash = ajaxPhoto.substring(pos, ajaxPhoto.indexOf("'",pos))
		
		setTimeout(function(){
			if(doLike(hash,id_photo))
			{
				window.wait_before_next_like = false			
			} else{
				window.hash_photo = hash
				window.id_photo = id_photo
				window.tries = 3
				tryDoLikeAgain()
			}
		},delay-Math.random()*(delay*0.1337))
	},delay-Math.random()*(delay*0.1337))
}

function getPeopleLinks(page=0,group_id){	
	ajaxPeople = doPost(hrefMembers,'act=box&al=1&al_ad=0&tab=members&offset='+((page)*60).toString()+'&oid='+group_id)	
	//ajaxPeople.substring(ajaxPeople.indexOf('<!>{')+3)
	//console.log(ajaxPeople)
	startPos = ' " href="'	
	pos = ajaxPeople.indexOf(startPos)+startPos.length	
	lastPos = -1
	PeopleLinks = []
	if(pos-startPos.length!=-1)
	while(pos>lastPos)
	{
		lastPos = pos
		pos = ajaxPeople.indexOf(startPos,pos)+startPos.length

		PeopleLinks.push('https://vk.com'+ajaxPeople.substring(lastPos,ajaxPeople.indexOf('"',lastPos)))		
	}		
	return PeopleLinks
}

function downloadAndDoLikes(delay){
	setTimeout(function(){
		if(window.wait_before_next_like)
		{
			downloadAndDoLikes(constDelay+Math.random()*456)
		}
		else if(window.downloadList)
		{
			window.peopleList = getPeopleLinks(window.page,window.group_id)
			window.page+=1
			console.log('next page '+window.page)
			window.downloadList = false
			window.person = 0
			if(peopleList.length!=0)
			{
				downloadAndDoLikes(constDelay-Math.random()*999)
			}
		} else{
			if(window.person<window.peopleList.length)
			{
				findPhotoAndDoLike(window.peopleList[window.person])
				window.person+=1
				downloadAndDoLikes(constDelay+Math.random()*999)
			} else{
				window.downloadList = true
				downloadAndDoLikes(123+Math.random()*123)
			}		
		}
	},delay)
}

function startDoLikes(group_id='-66084425',delay=3337,startFromPage=1){
	window.page = startFromPage
	window.person = 0
	window.downloadList = true
	//window.needLikes = people
	window.constDelay = delay
	window.group_id = group_id	

	window.wait_before_next_like = false

	window.allLikes = 0

	downloadAndDoLikes(100)
}

// F12 -> elements -> Ctrl+F -> Likes.toggle
// Likes.toggle(this, event, 'photo59837601_456261420', 'hash_photo');
//getPeopleLinks(1,'-66084425')


//window.constDelay = 3337
//findPhotoAndDoLike('https://vk.com/kirkhal')
startDoLikes('-66084425',delay,9)