def enc(t,key):
    key = int(key)
    #hided = ((key+29)*18-(key*12))%256
    hided = ((key+29)*14-(key*12))%256
    e = ""
    arr = []
    for s in t:
        arr.append((ord(s)+hided)%256)        
        e = e + chr((ord(s)+hided)%256)
    print(arr)
    return e

for i in range(0,256):
    print(i)
    print(enc("flag{Reverse_changed_the_key_in_bytes}",90))
