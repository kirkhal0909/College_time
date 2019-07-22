/*localStorage.getItem('ok-last')
"https://ok.ru/profile/554652633560"
localStorage.getItem('ok-last-group')
"https://ok.ru/armyansk.info/members"*/

function doGet(href="/"){
	var http = new XMLHttpRequest();
	http.open("GET", href, false);	
	http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');	
	http.send();		
	var t = http.responseText; 
	return t;
}

upl_more = document.getElementsByClassName('js-show-more link-show-more')

function clickUpload(){
	if (upl_more.length>0)
	{
		upl_more[0].click()
	}
}

function removeCards(){
	blocks = document.getElementsByClassName('ugrid_i')
	var removed = blocks.length;
	for(i=blocks.length-1;i>=0;i--)
	{
		blocks[i].remove()
	}
	return removed
}

var firstRun = 1

function storageData(){
	blocks = document.getElementsByClassName('user-grid-card_avatar')
	localStorage.setItem("Count-People",blocks.length-1)
	for(i=1;i<=blocks.length-1;i++)
	{
		localStorage.setItem("ok-"+i.toString(),blocks[i].firstChild.href)
		//console.log(i)
	}
	window.people = localStorage.getItem("Count-People")
	window.step = 1
	firstRun = 0
	removeCards()
	clickUpload()	
}

function uploadWhileNotFound(href='',fnd=true)
{
	storageData()
	if (localStorage.getItem("ok-last"))
	{
		if(href=='')
			href = localStorage.getItem("ok-last")
	}
	window.hr = href;
	
	if((window.hr) && (fnd) &&(window.location.href.replace('#','') == localStorage.getItem("ok-last-group")) && (localStorage.getItem("ok-last-group")))
	{findLoop();}
	else {
			window.w = openLink(localStorage.getItem("ok-"+step.toString()))	
			window.step+=1
			localStorage.setItem("ok-last-group",window.location.href.replace('#','')); doLoop();
		}
}

function findLoop()
{
	found = false		
	setTimeout(function(){
		for(window.step=1;window.step<= window.people;window.step++)
		{
			if(localStorage.getItem("ok-"+step.toString())==window.hr)
			{
				window.w = openLink(localStorage.getItem("ok-"+step.toString()))	
				window.step+=1
				found = true
				doLoop()
			}
		}
		storageData()		
		//console.log('after,storage')
		if((window.people>0) && (found==false))
			findLoop()
	},1000)
}


function addData(){	
	var blocks = document.getElementsByClassName('user-grid-card_avatar')
	if (blocks.length>0)
	{
		localStorage.setItem("Count-People",parseInt(localStorage.getItem("Count-People"))+blocks.length)
		lastAll = localStorage.getItem("Count-People")
		for(i=0;i<blocks.length;i++)
		{
			localStorage.setItem("ok-"+(lastAll-i).toString(),blocks[i].firstChild.href)
		}
		window.people = localStorage.getItem("Count-People")
		removeCards()
	}
	clickUpload()
}

function openLink(hr){//,tm=2050){
	//var 
	w = window.open(hr)
	return w
	//setTimeout(function(){w.close();},tm)
}

function closePage(w){
	w.close()	
}

function getByLinks(){
	storageData()
	
	window.w = openLink(localStorage.getItem("ok-"+step.toString()))	
	window.step+=1
	doLoop()
	//, 3000 * i);
}

function doLoop(){
	setTimeout(function () {    //  call a 3s setTimeout when the loop is called	  
	  closePage(window.w)
	  localStorage.setItem('ok-today',localStorage.getItem('ok-today')-1)
      //console.log(localStorage.getItem("ok-"+step.toString()))			
		window.w = openLink(localStorage.getItem("ok-"+step.toString()))
		//var t = doGet(localStorage.getItem("ok-"+i.toString()))
		//try{document.write(t)} catch(err){}
		//console.log('redirect ')
		//console.log(step)
      window.step++;   
	  //addData()
	  if(localStorage.getItem('ok-today')<=0) return false;
      if (window.step <= window.people) { 
		 localStorage.setItem("ok-last",localStorage.getItem("ok-"+window.step.toString()))		 
         doLoop();             
      }else {storageData(); if(window.step<=window.people){doLoop();} else{localStorage.setItem("ok-last",'');}}          
   }, 4300)
}

function doUpload(){
	//var 
	blocks = document.getElementsByClassName('user-grid-card_avatar')
	localStorage.setItem("Count-People",blocks.length-1)
	for(i=1;i<blocks.length;i++)
	{
		localStorage.setItem("ok-"+i.toString(),blocks[i].firstChild.href)
	}
}

function newDate(){
	var dt = new Date();
	tmpDt = dt.getYear()+' '+dt.getMonth()+' '+dt.getDate()
	if (tmpDt!=localStorage.getItem('ok-last-date'))
	{
		localStorage.setItem('ok-last-date',tmpDt)
		localStorage.setItem('ok-today',parseInt(Math.random()*40)+950)		
	}
}
//localStorage.setItem("ok-last",'')

newDate()
uploadWhileNotFound('')
//getByLinks()

/*var hidedDiv = document.createElement("div");
hidedDiv.id = 'by-KirKhal'
hidedDiv.style.display = 'none'
document.body.appendChild(hidedDiv);*/