import random

def doCode(c,n):    
    
    StartPoint = 0
    code = ord(c)    
    actions = ["+","-","*","//"]    
    print("character"+str(n)+' '+c);
    minStrings = 1000
    #maxStrings = minStrings+50
    cache = []
    while(len(cache)<minStrings):
        tmp = StartPoint
        cache = []        
        while(tmp!=code):
            action = actions[random.randint(0,len(actions)-1)]            
            rand = random.randint(1,5)
            s = "character"+str(n)+""+"="
            #print(action)
            if tmp<code:
                if(action=='+'):
                    s = s+"character"+str(n)+action+str(rand)
                    cache.append(s)
                    tmp = tmp+rand
                    #print(s+"   "+str(tmp))
                elif(action=='*'):
                    s = s+"character"+str(n)+action+str(rand)
                    cache.append(s)
                    tmp = tmp*rand
                    #print(s+"   "+str(tmp))
            elif tmp>code:
                if(action=='-'):
                    s = s+"character"+str(n)+action+str(rand)
                    cache.append(s)
                    tmp = tmp-rand
                    #print(s+"   "+str(tmp))        
                elif(action=='//'):
                    s = s+"character"+str(n)+action+str(rand)
                    cache.append(s)
                    tmp = tmp//rand
                    #print(s+"   "+str(tmp))
        #print(len(cache))
    #print(cache)
    f = open('code.txt','a')
    s = "character"+str(n)+""+"="
    f.write(s+str(StartPoint)+"\n")
    f.write("\n".join(cache)+"\n\n")
    f.close()

f = open('code.txt','w')
f.write("")
f.close()

flag = "flag{A_lot_of_similar_code}"
print("len: "+str(len(flag)))
for i in range(0,len(flag)):
    doCode(flag[i],i)
