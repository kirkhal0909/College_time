f = open('text.enc','r')
text = f.read()
f.close()
alph = 'абвгдеёжзийклмнопрстуфхцчшщъыьэюя'

def decrypt(t):
    #print(t[1:10])


    alphs = []


    for i in range(0,len(alph)):
        alphs.append(alph[i:len(alph)+1]+alph[0:i])

    key = 'крипто'
    print('  key: '+key)
    for rt in range(0,len(alph)):
        ROT = rt
        i = -1
        decrypt = ''
        for sym in t:
            i = (i+1)%len(key)
            alphInd = alph.find(sym)
            SymInd = alphs[(alphInd+ROT)%len(alph)].find(key[i])
            decrSym = alph[SymInd]
            decrypt = decrypt+decrSym
        print(str(rt)+': '+decrypt[0:30])
        if(decrypt.find('флаг') != -1):
            print('     '+str(rt)+': флаг')
        #print(rt)
        f = open(str(rt)+'decr.txt','w')
        f.write(decrypt)
        f.close()

def analyze(t,symbols):
    t2 = t[symbols:len(t)]+t[0:symbols]
    #print(t2)
    n = 0
    for i in range(0,len(t)):
        if t[i] == t2[i]: n = n+1
    if n/len(t)>0.05:
        print(str(n)+'/'+str(len(t))+' = '+str(n/len(t)))
    #print(' const = 0,0553')

#for a in range(1,100):
#    print(str(a)+' ')
#    analyze(text,a)
# 17

#text = '1234567890'
grps = []
grpsRot = []
keyLen = 17
for grp in range(0,keyLen):
    grps.append('')
    grpsRot.append('')
    ind = grp
    while ind<len(text):
        grps[grp] = grps[grp]+text[ind]
        ind = ind+keyLen
maxCh = []
f = open('grps.txt','w')
grpNum = -1
for grp in grps:
    grpNum = grpNum+1
    f.write(grp+'\n')
    ch = {}
    maxCh.append(0)
    for sym in alph:
        ch[sym] = 0
    for sym in grp:
        ch[sym] = ch[sym] +1
        if ch[sym]>maxCh[grpNum]: maxCh[grpNum]=ch[sym]
    for sym in alph:
        if maxCh[grpNum]-ch[sym]<30:
            f.write(sym+': '+str(ch[sym])+'\n')
    for sym in ch:
        if maxCh[grpNum]==ch[sym]:
            maxCh[grpNum]=sym
            break

indO = alph.find('о')
#print(indO)
for grp in range(0,len(grps)):
    Rot = alph.find(maxCh[grp])-indO
    if grp==0:
        Rot= Rot+15
    if grp==6:
        Rot= Rot+10
    #print(Rot)
    for i in range(0,len(grps[grp])):
        s = alph[(alph.find(grps[grp][i])-Rot)%len(alph)]
        grpsRot[grp] = grpsRot[grp]+s
        #grps[grp][i] =

decrypt = ''
for sym in range(0,len(grpsRot[0])):
    for grp in range(0,len(grpsRot)):
        if sym<len(grpsRot[grp]):
            decrypt=decrypt+grpsRot[grp][sym]
            
f = open('decrypt.txt','w')
f.write(decrypt)
f.close()
    
#print(ch)
f.close()
print(alph[(alph.find('я')+1)%len(alph)])
print('End')
