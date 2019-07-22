import socket,os,random
def isOpen(host,port,timeout):
   sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
   sock.settimeout(timeout)

   Port = int(port)
   #Port = 8000
   result = 'check'
   result = sock.connect_ex((host,Port))
   #print(result)
   if result == 0:
      #print("Port is open")
      print('Opened'+' '*random.randint(3,17)+host+':'+str(port))
      return True
   else:
      #print("Port is not open")
      return False

def checkRange(rng,port,timeout):
   IPs = rng.split('-')
   IPbeg=IPs[0]
   IPend=IPs[1]
   
   IPbegDig = IPbeg.split('.')
   IPendDig = IPend.split('.')

   IP1end = int(IPendDig[0])
   IP2end = int(IPendDig[1])
   IP3end = int(IPendDig[2])
   IP4end = int(IPendDig[3])

   IP2beg = int(IPbegDig[1])
   IP3beg = int(IPbegDig[2])
   IP4beg = int(IPbegDig[3])

   Directory = rng+'_'+str(port)
   if not os.path.exists(Directory):
      os.mkdir(Directory)
   
   for IP1 in range(int(IPbegDig[0]),int(IPendDig[0])+1):
      tmp2end = 256
      if IP1 == IP1end:
         tmp2end = IP2end+1
      for IP2 in range(IP2beg,tmp2end):
         IP2beg = 1
         tmp3end = 256
         if IP2 == IP2end:
            tmp3end = IP3end+1
         for IP3 in range(IP3beg,tmp3end):
            FileName = Directory+'\\'+str(IP1)+'.'+str(IP2)+'.'+str(IP3)+'.txt'
            f = open(FileName,'w')
            IP3beg = 1
            tmp4end = 256
            if IP3 == IP3end:
               tmp4end = IP4end+1
            for IP4 in range(IP4beg,tmp4end):
               IP4beg = 1
               IP = str(IP1)+'.'+str(IP2)+'.'+str(IP3)+'.'+str(IP4)
               if isOpen(IP,port,timeout):
                  f.write(IP+'\n')
                  print('opened '+IP+':'+str(port))
               #else:
                  #print('Is not opened '+IP)
            f.close()
            if os.path.getsize(FileName) == 0:
               os.remove(FileName)

def checkOpenPorts(host,timeout):
   FileName = host+'(ports).txt'
   f = open(FileName,'w')
   f.close()
   for port in range(1,2**16+1):
      f = open(FileName,'a')
      if isOpen(host,port,timeout):
         f.write(host+':'+str(port))
      if port % 100 == 0:
         print(port)
      f.close()

#checkRange('1.2.3.4-5.213.321.123',8000,0.01)
#isOpen('185.118.64.82',80,0.9)
#checkRange('192.168.0.1-192.168.0.255',25,0.1)
checkOpenPorts('192.168.0.113',0.1)
