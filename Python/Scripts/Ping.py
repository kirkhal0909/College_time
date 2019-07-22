import os
IP = '192.168.0.1'
try: os.makedirs('IPs')
except FileExistsError: True

while 1 == 1:
    IP = str(input())
    Check = IP.count('.')
    if Check == 3 or Check == 2:
        IP = IP.split('.')
        for i in range(0,3):
            if int(IP[i]) < 0 or int(IP[i]) > 255:
                Check = 0
                break
        IP = IP[0] + '.' + IP[1] + '.' + IP[2]
        f = open('IPs\\'+ IP + '.txt','w')
        #try:os.makedirs('IPs\\' + IP)
        #except FileExistsError: Check = 0
        if Check == 0:
            print('Enter IPv4 address')
        else:
            for i in range(0,256):
                if os.system("ping -c 1 -w 1 " + IP + '.' + str(i)) == 0:
                    f.write(IP+'.'+str(i)+'\n')
            f.close()
    else: print('Enter IPv4 address')
