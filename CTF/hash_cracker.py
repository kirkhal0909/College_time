import hashlib
import itertools
def crackHash(hashFunction,alph,h,n,salt):
    h = h.lower()
    for l in range(n[0],n[1]+1):
        status = cracking(hashFunction,alph,h,l,salt)
        if status[0]:
            return status        
        #hashFunction(h.encode()).hexdigest()
    return status

def cracking(hashFunction,alph,h,n,salt):
    sBeg = salt[0]
    sEnd = salt[1]
    cracked = False
    crackedWord = ''
    print("Crack string with length "+str(n))
    print("Generate list")
    wordList = itertools.product(alph, repeat = n)
    print("start cracking")
    for word in wordList:        
        #print("".join(list(word)))        
        text = sBeg+"".join(list(word))+sEnd
        #print(hashFunction(text.encode()).hexdigest()+"   "+h)
        if (hashFunction(text.encode()).hexdigest() == h):
        #if (hashlib.new('md4',text.encode('utf-16le')).hexdigest() == h):
            cracked = True
            crackedWord = text
            break
    #for length
    return [cracked,crackedWord]

hashFunction = hashlib.md5  #crack md5
alph = '1234567890qwertyuiopasdfghjklzxcvbnm-_QWERTYUIOPASDFGHJKLZXCVBNM'     #use just binary code
h = '621E10C6BD11D3D3B7057F0C2B64BB6E'  #crack this hash
n = [0,32]     #start from 32 characters and end on 32 characters
salt = ["","test,false"]    #begin salt is "" and salt which appends to end "test,false"
#h = 'acc322ebf1a3fbf53f08fb6372c629b1'
print(crackHash(hashFunction,alph,h,n,salt))
