import random

def doPrimers(n = 999):
    f = open('Пример2.txt','w')
    s = 0
    text = ''    
    r = random.randint(0,8)
    tmp = 0
    for i in range(n):
        if(tmp == 0) and (r==0): r = 1
        if r > 0:
            tmp = tmp+1
            text = text+' '
        else:
            #print(tmp)
            text = text+'\t'
            if s == 0:
                s = tmp
            else:
                s = s*tmp
            tmp = 0
        r = random.randint(0,8)
    if tmp != 0: s = s*tmp
    print(s)
    f.write(text)
    f.close()

def doSum():
    f = open('Пример2.txt','r')
    t = f.read().split('\t')
    ans = 0    
    for block in t:
        #print(len(block))
        if ans == 0:
            ans = len(block)
        else: ans = ans*len(block)
        
    print(ans)
    f.close()

#doPrimers()
doSum()
