import threading
import time

class application:
    __coins__ = 0        

    __autoclick_time__ = 1 #seconds
    __coins_by_user_click__ = 1

    __koef_mult_price__ = 1.337
    
    __application_runned__ = False
    __developers__ = {'dev1':{'coins_per_second':1,'count_developers':0,'price_for_developer':100},
                  'dev2':{'coins_per_second':2,'count_developers':0,'price_for_developer':300},
                  'dev3':{'coins_per_second':3,'count_developers':0,'price_for_developer':600},
                  'dev4':{'coins_per_second':4,'count_developers':0,'price_for_developer':1000},
                  'dev5':{'coins_per_second':5,'count_developers':0,'price_for_developer':1500},
                  }

    __fileCoins__ = 'last_coins'
    def __init__(self):
        self.__application_runned__ = True
        print('Welcome to the programmer clicker!')
        self.__loadLastCoins__()
        self.__loadDevelopers__()
        self.showBalance()
        self.__runAutoclickers__()
        self.__threadSaveCoins__()        

    def __autoclicker_thread__(self,developer):
        thread = threading.Thread(target=self.__autoclicker__, args=(developer,))       
        thread.start() 

    def __runAutoclickers__(self):
        for developer in self.__developers__:    #init autoclickers            
            self.__autoclicker_thread__(developer)
            time.sleep(0.1)

    def __autoclicker__(self,developer):
        while self.__application_runned__:
            if self.__developers__[developer]['count_developers']>0:
                self.__coins__+=(self.__developers__[developer]['coins_per_second']*self.__developers__[developer]['count_developers'])
                #self.showBalance()
            time.sleep(self.__autoclick_time__)

    def buyDeveloper(self,developer='getList'):
        if self.__application_runned__:            
            if(developer in self.__developers__.keys()):                
                needToBuy = self.__developers__[developer]['price_for_developer']
                for mult in range(self.__developers__[developer]['count_developers']):
                    needToBuy*=self.__koef_mult_price__
                needToBuy = round(needToBuy)
                    
                if self.__coins__>=needToBuy:
                    self.__coins__-=needToBuy
                    self.__developers__[developer]['count_developers']+=1                                        
                    self.__saveDeveloper__(developer)
                    print('Succesful purchased')
                else:
                    print('Need more balance')
            else:
                print('developer name\tprice\tprofit/s')
                for developer in self.__developers__:
                    needToBuy = self.__developers__[developer]['price_for_developer']
                    for mult in range(self.__developers__[developer]['count_developers']):
                        needToBuy*=self.__koef_mult_price__
                    needToBuy = round(needToBuy)
                    print(developer+'\t\t',str(needToBuy)+'\t',self.__developers__[developer]['coins_per_second'])

    def __saveDeveloper__(self,developer):
        file_count_developer = open(developer,'w')
        file_count_developer.write(str(self.__developers__[developer]['count_developers']))
        file_count_developer.close()

    def __loadDevelopers__(self):        
        for developer in self.__developers__:
            try:
                file_count_developer = open(developer,'r')
                self.__developers__[developer]['count_developers'] = int(file_count_developer.read())
                file_count_developer.close()
            except:
                False

    def click(self):
        if self.__application_runned__:
            self.__coins__+=self.__coins_by_user_click__
            self.showBalance()

    def __loadLastCoins__(self):        
        try:            
            file_with_last_coins = open(self.__fileCoins__,'r')
            self.__coins__ = int(file_with_last_coins.read())            
        except:
            self.__coins__ = 0

    def __threadSaveCoins__(self):
        thread = threading.Thread(target=self.__saveLastCoins__)       
        thread.start()
    
    def __saveLastCoins__(self):
        while self.__application_runned__:
            file_with_last_coins = open(self.__fileCoins__,'w')
            file_with_last_coins.write(str(self.__coins__))
            file_with_last_coins.close()
    
    def showBalance(self):
        if self.__application_runned__:
            print('Your balance:',self.__coins__)
            return self.__coins__

    def getProfitList(self):
        if self.__application_runned__:
            print('developer name\tprofit/s')
            allProfit = 0
            for developer in self.__developers__:
                profit = self.__developers__[developer]['coins_per_second']*self.__developers__[developer]['count_developers']
                print(developer+'\t\t',profit)
                allProfit+=profit
            print('\n All profit by second',allProfit)

    def start(self):
        if not self.__application_runned__:
            self.__application_runned__ = True
            self.showBalance()
            self.__runAutoclickers__()
            self.__threadSaveCoins__()

    def close(self):
        print('Application closing')
        self.__application_runned__ = False        
    
        

