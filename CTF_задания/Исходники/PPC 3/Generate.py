import random

def doPrimers(n = 99999):
    f = open('Пример.txt','w')
    s = 0
    text = ''    
    r = random.randint(1,1000)
    tmp = 1000
    for i in range(n):
        
        if(i%2==0):
            if (tmp<=200):
                s = s-r
            else: s = s+r
        tmp = r
        text = text+str(r)
        if(i!=n-1):
            text = text+"|"
        r = random.randint(1,1000)
    print(s)
    f.write(text)
    f.close()

def doSum():
    f = open('Пример.txt','r')
    t = f.read().split('|')
    ans = 0
    sign = '+'
    for i in range(len(t)):        
        if(i%2==0):
            #print(int(t[i]))
            if sign=='-':
                ans=ans-int(t[i])
            else:
                ans=ans+int(t[i])
        else:
            if (int(t[i])<=200):
                sign = '-'
            else: sign = '+'
    print(ans)
    f.close()
