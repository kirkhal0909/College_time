import os,socket,time,random,threading

class portChecker():

    maxThreads = 1
    __countThreads__ = 0
    __WaitThread__ = 10
    __Ranges__ = 0
        

    def portIsOpen(self,Host,Port,Seconds):
        s = socket.socket()
        Seconds = float(Seconds)
        Port = int(Port)
        s.settimeout(Seconds)
        Connect = s.connect_ex((Host,Port))
        if Connect == 0:
            isOpen = True
            print('Openned:   '+Host+':'+str(Port)+'\n')
        else:
            isOpen = False
        return isOpen

    def threadCheckLine(self,LineIP,begIP,endIP,port,Seconds,FolderName):        
        if os.path.exists(FolderName) == False:
            os.mkdir(FolderName)
        begIP = int(begIP)
        endIP = int(endIP)
        if LineIP[len(LineIP)-1] != '.':
            LineIP = LineIP+'.'
        fileName = FolderName+'\\'+str(port)+'_'+LineIP+'.txt'
        f = open(fileName,'a')
        #if begIP<0: begIP = 0
        #if endIP>255: endIP = 255
        print('Check new range '+LineIP+'*:'+str(port)+'\n')
        for last in range(begIP,endIP+1):
            IP = LineIP+str(last)
            #print(IP)
            #print(self.__countThreads__)
            if self.portIsOpen(IP,port,Seconds):            
                f.write(IP+':'+str(port)+'\n')
        f.close()
        self.__countThreads__ = self.__countThreads__ - 1
        print('   Check range is ended '+LineIP+'*:'+str(port)+'\n')
        if self.__Ranges__ == 0 and self.__countThreads__ == 0:
            print('   ===Work is ended!!!===')

    def CheckLine(self,LineIP,begIP,endIP,port,Seconds,FolderName):
        self.__countThreads__ = self.__countThreads__ + 1
        time.sleep(0.3*random.random())
        t = threading.Thread(target=self.threadCheckLine,args=[LineIP,begIP,endIP,port,Seconds,FolderName])
        t.setDaemon(True)
        t.start()

    def CheckRange(self,Range,Port,Seconds):
        self.__Ranges__ = self.__Ranges__ + 1
        #self.maxThreads = int(maxWorkedThreads)
        self.maxThreads = int(self.maxThreads)
        if self.maxThreads < 1: self.maxThreads = 1
        IPs = Range.split('-')
        IPbeg = IPs[0].split('.')
        IPend = IPs[1].split('.')
        LineIP = IPbeg[0]+'.'+IPbeg[1]+'.'+IPbeg[2]+'.'
        FolderName = Range
        IP3 = int(IPs[1].split('.')[2])
        while self.__countThreads__ >= self.maxThreads:
            time.sleep(self.__WaitThread__)
        if IPbeg[0]+IPbeg[1]+IPbeg[2] == IPend[0]+IPend[1]+IPend[2]:
            lastEnd = IPend[3]
            self.CheckLine(LineIP,IPbeg[3],lastEnd,Port,Seconds,FolderName)
        else:
            lastEnd = 255
            self.CheckLine(LineIP,IPbeg[3],lastEnd,Port,Seconds,FolderName)
            lastEnd = IPend[3]
            for IP1 in range(int(IPbeg[0]),int(IPend[0])+1):
                if IP1 == int(IPbeg[0]):
                    startIP2 = int(IPbeg[1])
                else: startIP2 = 0
                if IP1 == int(IPend[0]):
                    stopIP2 = int(IPend[1])
                else: stopIP2 = 255
                for IP2 in range(startIP2,stopIP2+1):
                    if IP1 == int(IPbeg[0]) and IP2 == int(IPbeg[1]):
                        startIP3 = int(IPbeg[2])
                    else: startIP3 = 0
                    if IP1 == int(IPend[0]) and IP2 == int(IPend[1]):
                        stopIP3 = int(IPend[2])-1
                    else: stopIP3 = 255
                    for IP3 in range(startIP3+1,stopIP3+1):
                        LineIP = str(IP1)+'.'+str(IP2)+'.'+str(IP3)+'.'
                        while self.__countThreads__ >= self.maxThreads:
                            time.sleep(self.__WaitThread__)
                        self.CheckLine(LineIP,0,255,Port,Seconds,FolderName)
            IP3 = IP3+1
            if IP3<256:
                LineIP = str(IP1)+'.'+str(IP2)+'.'+str(IP3)+'.'
                while self.__countThreads__ >= self.maxThreads:
                    time.sleep(self.__WaitThread__)
                self.CheckLine(LineIP,0,lastEnd,Port,Seconds,FolderName)
        #print('     '+Range+':'+str(Port)+' all threads are starts\n')
        self.__Ranges__ = self.__Ranges__ - 1

    def CheckIPRangesFromFile(self,fileName,Port,Seconds):
        f = open(fileName,'r')
        Ranges = f.read().split('\n')
        f.close()
        #print(Ranges)
        for Range in Ranges:
            try:self.CheckRange(Range,Port,Seconds)
            except Exception as err:
                print('\n !!!ERROR start range - '+Range)
                try:
                    fileErr = open('!Error'+Range+'.txt','w')
                    fileErr.write(str(err))
                    fileErr.close()
                except:
                    False
            

#print(portIsOpen('vk.com',80,1))
p = portChecker()
#p.CheckLine('87.240.129',71,255,80,0.2,'test4')
p.maxThreads = 100
p.CheckIPRangesFromFile('IPs.txt',3390,2)
p.CheckIPRangesFromFile('IPs.txt',3391,2)
p.CheckIPRangesFromFile('IPs.txt',3392,2)
#p.CheckRange('91.205.216.13-91.205.219.19',80,0.1)
#p.CheckRange('91.205.216.13-91.205.219.19',21,0.1)
