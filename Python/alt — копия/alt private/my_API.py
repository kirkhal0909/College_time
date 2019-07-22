import requests,time,datetime,random,os,threading


file_proxy = open('https.txt','r')
proxy = file_proxy.read().split(' ')
file_proxy.close()

file_user_agents = open('User_agents.txt','r')
user_agents = file_user_agents.read().split('\n')
file_user_agents.close()

maxAccounts = 5


s = requests.Session()
#hd = {'Accept':'text/html, */*; q=0.01','X-Requested-With':'XMLHttpRequest',
#'User-Agent':'user-agent Mozilla/5.0 (Linux; Android 8.1.0; Redmi Note 6 Pro Build/OPM1.171019.011; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/70.0.3538.64 Mobile Safari/537.36 '}

mainData = [
            ]


def doPost(s,link,dt,hd,pr,paramsLink=''):
        if paramsLink=='':
                #print(link,dt,hd,pr)
                r = s.post(link,data=dt,headers=hd,proxies=pr)
        else:
                r = s.post(link+"?"+paramsLink,data=dt,headers=hd,proxies=pr)
        return r.text

def doGet(s,link,hd,pr,paramsLink=''):
        if paramsLink=='':
                #print(link,dt,hd,pr)
                r = s.get(link,headers=hd,proxies=pr)
        else:
                r = s.get(link+"?"+paramsLink,headers=hd,proxies=pr)
        return r.text

def initBot(mainData,agent,proxy):
        global game_version
        print('Init bot')
        hd = {'Accept':'text/html, */*; q=0.01','X-Requested-With':'XMLHttpRequest'}
        hd['User-Agent'] = agent
        p = {'http':proxy,'https':proxy}
        s = requests.Session()
        
        sendAfterBalance = 5000000

        autoBuy = False
        itemBuy = '6'
        delay = 60/len(mainData)
        if autoBuy:
                delay-=1
        accounts = len(mainData)        
        stepAcc = accounts-1
        prices = [[True,[]] for i in range(accounts)]
        maxErrors = 2
        Errors = 0
        ErrorBuy = 0
        maxErrorBuy = 2
        while True:
                for i in range(accounts):
                        try:
                                pData = mainData[i]
                                info = doPing(s,pData,hd,p)                                
                                #print(info)
                                if('ok' in info):
                                        Errors = 0
                                        try:
                                               info = info.split(',')
                                               balance = int(float(info[1].split(':')[1]))                                               
                                               if autoBuy:
                                                       if ErrorBuy<maxErrorBuy:
                                                               try:
                                                                      if(prices[i][0]):
                                                                              time.sleep(0.5)
                                                                              prices[i] = [False,getUpdatesPrices(mainData[i])]
                                                                      print('need next balance to buy - '+str(prices[i][1][int(itemBuy)-1]))
                                                                      if balance>=prices[i][1][int(itemBuy)-1]:
                                                                              prices[i][0] = True
                                                                              status = False
                                                                              status = Buy(mainData[i],itemBuy,s,hd,p)
                                                                              if(status==False):
                                                                                      ErrorBuy+=1
                                                                              else:
                                                                                      ErrorBuy = 0                                                                                      
                                                                              
                                                               except: False
                                                                
                                               allCoins+=balance
                                               if balance>=sendAfterBalance and i>0:
                                                       doTranc(s,mainData[i],mainData[0]['s_vk_id'],balance,hd,p)
                                        except:
                                                False
                                elif('time' in info):
                                        Errors = 0                                
                                else:
                                        #print('good')
                                        Errors += 1                                
                                        if Errors == 2: break                                        
                                        game_version = getVersion()
                                print(i,'/',stepAcc,' - ',info) 
                        except:
                                print('Err ping - '+str(i))                                
                #break


block = [mainData[0]]
#x = threading.Thread(target=initBot, args=(block,user_agents[1],proxy[1],))
#x.start()

#banned





print('load my_API')
print()

def doPing(s,mainPart,hd,pr):
        global game_version
        pData = mainPart
        pData['clicks'] = '0'
        t = doPost(s,'https://x-coder.ru/ping',pData,hd,pr,'v='+game_version)
        #print(game_version)
        return t        

def ParsePhrase(t,phrase,sym):
        return t[t.find(phrase)+len(phrase):t.find(sym,t.find(phrase)+len(phrase))]

def getVersion():
        r = requests.get('https://x-coder.ru/?api_id=')
        #print(r.text)
        return ParsePhrase(r.text,'?v=','"')

def getUpdatesPrices(mainPart,s,hd,p):
        params = 's_vk_id='+mainPart['s_vk_id']+"&s_auth="+mainPart['s_auth']
        #r = requests.get('https://x-coder.ru/updates?)        
        t = doGet(s,'https://x-coder.ru/updates',hd,p,params)
        prices = []
        while t.find('data-price="')>=0:
                pos = t.find('data-price="')
                prices.append(float(ParsePhrase(t,'data-price="','"')))                
                t = t[pos+3:len(t)]
        return prices

game_version = getVersion()
for i in range(len(mainData)):
        mainData[i]['clicks'] = 0
        #mainData[i]['v'] = game_version


def doTranc(s,mainPart,toId,money,hd,pr):        
        mainPart['tran_to'] = toId
        mainPart['tran_sum'] = money
        startMoney = money
        maxSum = 1000000
        while money>0:
                if money>maxSum:
                        mainPart['tran_sum'] = maxSum
                        money-=maxSum
                else:
                        mainPart['tran_sum'] = money
                        money = -1
                #s = requests.Session()
                        #def doPost(s,link,dt,hd,pr,paramsLink=''):
                
                print(doPost(s,'https://x-coder.ru/transaction',mainPart,hd,pr))
                time.sleep(random.randint(3,4))
        #print(r.text)
        print('Sended '+str(startMoney)+' to '+str(toId))

def Buy(mainPart,itemID,s,hd,p):        
        mainPart['buy'] = str(itemID)        
        s = requests.Session()
        try:
                t = doPost(s,'https://x-coder.ru/buy',mainPart,hd,p)
                print(t)
        except:
                print(mainPart['s_vk_id'],' error buy')
        good = True
        if 'err' in t:
                good = False
        return good

maxErrorBuy = 2
ErrorBuy = 0

def startBuy(mainPart,times=18):
        slp = 4
        allTime = 0
        global mainData
        for item in range(6,0,-1):
                item = str(item)
                for t in range(times):
                        Buy(mainPart,item)
                        time.sleep(slp)
                        allTime += slp
                        if allTime>=60:
                                allTime = 0
                                #doPing(mainPart)

def newAcc():
        global mainData
        doTranc(mainData[0],mainData[-1]['s_vk_id'],100000)
        time.sleep(1)
        startBuy(mainData[-1])

def allBuy(itemID='6',times=1,frm=3,to=6):
        for t in range(times):
                for man in range(frm,to+1):
                        Buy(mainData[man],itemID)
                        time.sleep(1)



#Buy(mainData[6],'1')

def allToMainWallet():
        global mainData
        for i in range(1,len(mainData)):
                doTranc(mainData[i],'59837601',0)

#doTranc(mainData[0],'540923594','100')
