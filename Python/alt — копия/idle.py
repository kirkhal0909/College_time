from my_API import *

begClck = 0
endClck  = 0
delay = 60/len(mainData)
#if delay<10:
#        delay = 12
sendAfterBalance = 300000
#sendAfterBalance = 10000
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
                pData['clicks'] = str(random.randint(begClck,endClck))                
                try:
                        r = s.post('https://x-coder.ru/ping',pData)
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
                                             doTranc(mainData[i],'59837601',balance)                                        
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
