/*

	https://vk.com/kirkhal

*/

hash='bd2b38b40b5b2c0146'

function doPost(href='/',params=""){	
	var http = new XMLHttpRequest()
	http.open("POST", href, false)	
	http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded')	
	http.send(params)	
	var t = http.responseText
	return t
}

hrefFriends = 'https://vk.com/al_friends.php'
hrefWall = 'https://vk.com/al_wall.php'

function getFriendsInfo(id='0',maxFriends=0){
	ajaxFriends = doPost(hrefFriends,'act=load_friends_silent&al=1&gid=0&id='+id)	
	ajaxFriends.substring(ajaxFriends.indexOf('<!>{')+3)
	
	pos = ajaxFriends.indexOf("['")+2

	lastPos = -1
	friendsInfo = []
	w = 0
	m = 0
	while(pos>lastPos)
	{
		//console.log(maxFriends,friendsInfo.length)
		if(maxFriends==0 || maxFriends>friendsInfo.length)
		{
			lastPos = pos		
			friend_id = ajaxFriends.substring(lastPos,ajaxFriends.indexOf("'",pos))
			if(friendsInfoGlobal.indexOf(friend_id)==-1)
			{
				pos = ajaxFriends.indexOf("','",pos)+3
				pos = ajaxFriends.indexOf("','",pos)+3
				pos = ajaxFriends.indexOf("','",pos)+3
				friend_gender = ajaxFriends.substring(pos,ajaxFriends.indexOf("'",pos))
				if (friend_gender == '2')
				{
					m+=1
				} else
				{
					w+=1
				}
				pos = ajaxFriends.indexOf("','",pos)+3
				pos = ajaxFriends.indexOf("','",pos)+3
				friend_full_name = ajaxFriends.substring(pos,ajaxFriends.indexOf("'",pos)).split(' ')
				friendsInfo.push([friend_id,friend_gender,friend_full_name[0],friend_full_name[friend_full_name.length-1]])		
				pos = ajaxFriends.indexOf("['",pos)+2
			}
		} else{pos = lastPos-1}
	}	
	console.log(w+' women and '+m+' men in friends')
	if(id==0)
		for(friend = 0;friend<friendsInfo.length;friend++)
		{
			replaceTo = Math.round(Math.random()*friendsInfo.length)-1
			if(replaceTo<0)
				replaceTo = 0
			tmp = friendsInfo[replaceTo]
			friendsInfo[replaceTo] = friendsInfo[friend]
			friendsInfo[friend] = tmp
		}
	return friendsInfo
}



function getFriendsInfoOfFriends(limitFriendsCheck=30,friendsFormOnePerson=20,delay=1337)
{			
	setTimeout(function(){		
		friend += 1
		console.log('	friend '+friend)
		if(friend<friendsInfoGlobal.length && friend<limitFriendsCheck)
		{			
			console.log('load friends list '+(friend+1).toString()+'/'+limitFriendsCheck<friendsInfoGlobal.length?limitFriendsCheck:friendsInfoGlobal.length)						
			friendsLists.push(getFriendsInfo(friendsInfoGlobal[friend][0],friendsFormOnePerson))			
			var linkToList = friendsInfoGlobal[friend]
			console.log('	downloaded friends of '+linkToList[2]+' '+linkToList[3]+' id'+linkToList[0])
			getFriendsInfoOfFriends(limitFriendsCheck,friendsFormOnePerson,delay)
		} else {
			s = "Hello world!\nГо wall-чат)\n\n" + formattingMessage()
			sendMessage(s)			
		}
	},delay*Math.random()+321)	
}

function formattingMessage(friendsInfo=[]){	
	message = ''
	for(friendsList=0;friendsList<friendsLists.length;friendsList++)		
	{		
		for(friend = 0;friend<friendsLists[friendsList].length;friend++)
		{		
			message = message+'@id'+friendsLists[friendsList][friend][0]+'('+friendsLists[friendsList][friend][2]+')'
			if(friend!=friendsLists[friendsList].length-1)
				message = message+','
		}
	}
	console.log(' length of message - '+message.length)
	return message;
}

function sendMessage(message='Hello world!'){	
	params = "act=post&al=1&type=all&fixed=0&from=0&mute_notifications=0&status_export=0&mark_as_ads=0&"	
			+"close_comments=0&anonymous=0&friends_only=0&signed=0&official=0&update_admin_tips=0&"
			+"hash="+hash+"&to_id="+user_id+"&Message="+message
	doPost(hrefWall,params)
}

function getId(){
	t = doPost('https://vk.com/support','')
	pos = t.indexOf('/albums')
	id = t.substring(pos+7,t.indexOf('"',pos))
	return id
}

user_id = getId()

setTimeout(function(){
	friendsInfoGlobal = []
	friendsInfoGlobal = getFriendsInfo()
	friendsLists = [friendsInfoGlobal]
	friend = -1
	getFriendsInfoOfFriends(friendsInfoGlobal.length)		
},567)