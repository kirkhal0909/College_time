import socket,os

def WAN():
        try:
                s1 = socket.socket()
                s1.connect(('vk.com',80))
                return True
        except:
                return False

def Check(IPs,frm,to,Ports,Delay):
        #IPs = "185.146."
        #Ports = [21,80]
        if IPs[::-1][0] != '.': IPs = IPs + '.'
        MainFolder = "Worked"
        
        try: os.mkdir(MainFolder)
        except: print("I can't create folder")

        for i in range(frm,to+1):
                Connection = False
                while(not Connection):
                        Connection = WAN()
                f = open(MainFolder+"/"+IPs+str(i)+'.txt','w')
                ttf = str(int((255-i)*255*Delay/60*len(Ports)*100)/100) + ' min'
                for j in range(0,256):
                        IP = IPs+str(i)+'.'+str(j)
                        for port in Ports:
                                s = socket.socket()
                                s.settimeout(Delay)
                                print('Check: '+IP+':'+str(port)+"   with delay "+str(Delay)+"   Time to finish: "+ttf)
                                try: 
                                        s.connect((IP,port))
                                        f.write(IP+':'+str(port)+'\n')
                                except:
                                        print("Don't connected")
                f.close()

Ports = [21,80]
Delay = 0.1

Check("185.146.",74,255,Ports,Delay)#Internet
Check("95.153.",0,255,Ports,Delay)#mts
Check("178.34.",0,255,Ports,Delay)#cfu
Check("95.173.",0,255,Ports,Delay)#kremin
#import mts.py
