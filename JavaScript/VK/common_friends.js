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
			if(true)
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

f1 = getFriendsInfo('321978516')
f2 = getFriendsInfo('239660514')

feq = []
for(i1=0;i1<f1.length;i1++)
{
	for(i2=0;i2<f2.length;i2++)
	{
		if (f1[i1][0]==f2[i2][0])
		{			
			feq.push(f2[i2])
			break
		}
	}
}

for(i1=0;i1<feq.length;i1++)
{
	console.log(feq[i1])
	console.log('https://vk.com/id'+feq[i1][0])
}

console.log('\n\n   '+feq.length+' common friends')