/*

	https://vk.com/kirkhal

*/

delay = 5000
start_from_friend = 1

function doPost(href='/',params=""){	
	var http = new XMLHttpRequest()
	http.open("POST", href, false)	
	http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded')	
	http.send(params)	
	var t = http.responseText
	return t
}

function findSquare(num){
	ideal = [1,num]
	delta = num-1
	for(i=2;i<=num**0.5;i++)
	{
		tmpRow = num/i
		canDivide = tmpRow%1>0?false:true
		if(canDivide)
		{
			tmpDelta = tmpRow-i
			if(tmpDelta<delta)
			{
				delta = tmpDelta
				ideal = [i,tmpRow]
			}
		}		
	}
	return ideal
}

hrefPhoto = 'https://vk.com/al_photos.php'
hrefFriends = 'https://vk.com/al_friends.php'

function testFriendsList(){
	friends = []
	for(i=0;i<96;i++)
	{
		friends.push('0')
	}
	return friends
}



friendsId = getFriendsId()

//friendsId = testFriendsList()

square = findSquare(friendsId.length)
deltaX = 100/square[0]
deltaY = 100/square[1]

if(start_from_friend>1)
{	
	row = Math.floor((start_from_friend-1)/square[1])
	column = start_from_friend-row*square[1]-2
}else
{
	row = -1
	column = square[0]-1
}

y1 = row*deltaY
y2 = y1+deltaY
if(row==square[1]-1)
	y2 = 100

autoDelay = delay

function addFriendsToPhoto(hash_photo,id_photo)
{		
	setTimeout(function(){
		column+=1
		if (column==square[0]){
			column = 0
			row+=1
			y1 = row*deltaY
			y2 = y1+deltaY
			if(row==square[1]-1)
				y2 = 100
		}
		if(row<square[1])
		{
			friend = column+row*square[0]
			x1 = column*deltaX
			x2 = x1+deltaX
			if(column==square[0]-1)
				x2 = 100			
			params = "name=0000011111001111&act=add_tag&al=1&hash="+hash_photo+"&mid="+friendsId[friend]+"&photo="+id_photo+"&x="+x1+"&x2="+x2+"&y="+y1+"&y2="+y2
			ajaxRequest = doPost(hrefPhoto,params)

			added = false
			if (ajaxRequest.indexOf('[')>=0)
			{
				added = true
				console.log('added friends '+(friend+1).toString()+'/'+friendsId.length)	
				autoDelay = delay+Math.random()*666			
			} else{
				if(ajaxRequest.indexOf('запретил')==-1)
				{
					console.log('try add '+(friend+1).toString()+' friend')
					if(column>0)
						{column-=1}
					else{
						if (row>0)
						{
							column=square[0]-1
							row-=1
						}
					}
					autoDelay = delay+Math.random()*6000
				}
			}						
			addFriendsToPhoto(hash_photo,id_photo)
		}		
	},autoDelay)	
}

function getFriendsId(){
	ajaxFriends = doPost(hrefFriends,'act=load_friends_silent&al=1&gid=0&id=0')
	ajaxFriends.substring(ajaxFriends.indexOf('<!>{')+3)
	pos = ajaxFriends.indexOf("['")+2	
	lastPos = -1
	friendsId = []
	while(pos>lastPos)
	{
		lastPos = pos
		pos = ajaxFriends.indexOf("['",pos)+2

		friendsId.push(ajaxFriends.substring(lastPos,ajaxFriends.indexOf("'",lastPos)))		
	}	
	return friendsId
}



// F12 -> elements -> Ctrl+F -> Likes.toggle
// Likes.toggle(this, event, 'photo59837601_456261420', 'hash_photo');
addFriendsToPhoto(hash_photo,'59837601_456261420')	