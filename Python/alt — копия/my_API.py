import requests,time,datetime,random,os
s = requests.Session()
mainData = [{'s_auth':'','s_vk_id':''},            
]



print('load my_API')
print()


def doTranc(mainPart,toId,money):        
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
                s = requests.Session()
                r = s.post('https://x-coder.ru/transaction',data=mainPart)
                time.sleep(random.randint(3,4))
        print(r.text)
        print('Sended '+str(startMoney)+' to '+str(toId))

def Buy(mainPart,itemID):
        mainPart['buy'] = str(itemID)        
        s = requests.Session()
        try:
                r = s.post('https://x-coder.ru/buy',data=mainPart)
                print(r.text)
        except:
                print(mainPart['s_vk_id'],' error buy')

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
                                doPing()

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

def doPing(mainPart):
        pData = mainPart
        pData['clicks'] = '0'
        r = s.post('https://x-coder.ru/ping',pData)
        print(r.text)
        time.sleep(1)

#Buy(mainData[6],'1')

def allToMainWallet():
        global mainData
        for i in range(1,len(mainData)):
                doTranc(mainData[i],'59837601',0)

#doTranc(mainData[0],'540923594','100')
