import fractions

def phi(n):
    amount = 0        
    for k in range(1, n + 1):
        if fractions.gcd(n, k) == 1:
            amount += 1
    return amount

n = 109722434436228016948664956541036733931896210184541013062335084203002444927793820632475984126605815237470597983269243265421629940582194037086230700835296457731682594116824354139706813134253211347500106764793509903759284891308905929532205960095526958014077459866525593941614457868106633452645990816029675517283

def crackPQ(n):
    for p in range(1,n+1):
        for q in range(1,n+1):
            if p*q==n:
                print("p = "+str(p)+"   q = "+str(q))
            elif p*q>n:
                break

def crackPQ2(n):
    Plains = getLastP()
    if len(Plains)==0:
        addP(2)
        addP(3)
        Plains = getLastP()
    elif len(Plains)==1:
        addP(3)
        Plains = getLastP()
    last = int(Plains[-1])
    add = 0
    if last%2 == 0:
        add = 1
        if isPlain(last+add):
            addP(last+add)
    if (n+1)//2>last:
        last = last+add
        for check in range(last+2,(n+1)//2+1,2):
            if isPlain(check):
                addP(check)
        Plains = getLastP()
    for p in Plains:
        p = int(p)
        q = n%p
        if q == 0:
            q = n//p
            if isPlain(q):
                print("p = "+str(p)+"    q = "+str(q))
    print("\n    Ended!")

def egcd(a, b):
    x,y, u,v = 0,1, 1,0
    while a != 0:
        q, r = b//a, b%a
        m, n = x-u*q, y-v*q
        b,a, x,y, u,v = a,r, u,v, m,n
        gcd = b
    return gcd, x, y

def isPlain(n):
    Plain = True
    for i in range(2,n-1):
        if n%i==0:
            Plain = False
            break
    if n < 2: Plain = False
    return Plain

def addP(n):
    f = open("Plains.txt","a")
    f.write(str(n)+' ')
    f.close()

def getLastP():
    f = open("Plains.txt","r")    
    LastP = f.readline().split(' ')[:-1]
    f.close()
    return LastP

def decrypt():

    p = 1090660992520643446103273789680343
    q = 1162435056374824133712043309728653
    e = 65537
    ct = 299604539773691895576847697095098784338054746292313044353582078965

    # compute n
    n = p * q

    # Compute phi(n)
    phi = (p - 1) * (q - 1)

    # Compute modular inverse of e
    gcd, a, b = egcd(e, phi)
    d = a

    print( "n:  " + str(d) );

    # Decrypt ciphertext
    pt = pow(ct, d, n)
    print( "pt: " + str(pt) )

crackPQ2(1000000000000000000000)
#addPlain(2)
#addPlain(3)
