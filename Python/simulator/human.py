import random
import time
import datetime
from laptop import *
#from start_clicker import *

class human:
    __first_name__ = 'Green'
    __second_name__ = 'Greenov'
    __middle_name__ = 'Greenovich'

    __gender__ = 'male'
    
    __hungry__ = 0
    __need_sleep__ = 0

    __alive__ = True
    __date_die__ = '-1'
    
    __percent_want__ = 15
    __next_cycle__ = 10

    __sleeping__ = False

    __money__ = 0
    __food_price__ = 4
    __experience__ = 0

    __last_hungry__ = 0
    __last_need_sleep__ = 0

    laptop = False
    __laptop_price__ = 1#30
    
    def __init__(self,first_name='Green',second_name='Greenov',middle_name='Greenovich',gender='male'):
        self.__first_name__ = first_name
        self.__second_name__ = second_name
        self.__middle_name__ = middle_name
        
        self.__thread_hungry_up__()
        self.__thread_need_sleep_up__()
        self.__thread_auto_show_info__()

    def __thread_hungry_up__(self):
        thread = threading.Thread(target=self.__hungry_up__)       
        thread.start()
    
    def __hungry_up__(self):
        while self.__alive__:
            self.__check_end_hungry__()
            time.sleep(self.__next_cycle__)

    def __check_end_hungry__(self):
        wantMore = random.randint(1,100)<=self.__percent_want__
        if wantMore and self.__hungry__<100:
            self.__hungry__+=1
        elif self.__hungry__>=100:
            self.__die__()

    def __thread_need_sleep_up__(self):
        thread = threading.Thread(target=self.__need_sleep_up__)       
        thread.start()
    
    def __need_sleep_up__(self):
        while self.__alive__:
            self.__check_go_sleep__()
            time.sleep(self.__next_cycle__)

    def __check_go_sleep__(self):
        wantMore = random.randint(1,100)<=self.__percent_want__
        if wantMore and self.__need_sleep__<100:
            self.__need_sleep__+=1
        elif self.__need_sleep__>=random.randint(85,100):            
            self.go_sleep()

    def __die__(self):
        if self.__alive__ == True:
            self.__alive__ = False
            if laptop:
                self.laptop.stop()
                self.laptop = False
            self.__date_die__ = str(datetime.datetime.now())
            print(self.full_name(),'died at',self.__date_die__)

    def __thread_auto_show_info__(self):
        thread = threading.Thread(target=self.__auto_show_info__)
        thread.start()

    def __auto_show_info__(self):
        #last_hungry = 0#self.__hungry__
        #last_need_sleep = 0#self.__need_sleep__
        while self.__alive__:
            if (self.__last_hungry__!=self.__hungry__) or (self.__last_need_sleep__!=self.__need_sleep__):
                self.get_info()                
            time.sleep(self.__next_cycle__)

    def __sleep_start__(self):
        sleepTo = random.randint(0,20)
        if self.__need_sleep__> sleepTo:
            self.__sleeping__ = True
            print(self.full_name(),'go sleep')
            while self.__sleeping__ and self.__alive__:
                self.__need_sleep__-=random.randint(1,3)
                if self.__need_sleep__<= sleepTo:
                    self.__sleeping__ = False
                    if self.__need_sleep__<0:
                        self.__need_sleep__=0
                    print(self.full_name(),'wake up')
                            
                self.__check_end_hungry__()
                #code speed up sleeping
                time.sleep(0.1)

    def go_sleep(self):
        if self.__alive__ and not self.__sleeping__:
            thread = threading.Thread(target=self.__sleep_start__)
            thread.start()

    def eat(self):
        if self.__alive__ and not self.__sleeping__:
            if self.__money__<self.__food_price__:
                print('need',str(self.__food_price__)+'$')
            else:            
                self.__money__-=self.__food_price__
                self.__hungry__-=random.randint(7,12)
                if self.__hungry__<0:
                    self.__hungry__=0
                print('hungry now -',str(self.__hungry__)+'%')
            

    def earn_money(self):
        if self.__alive__ and not self.__sleeping__:
            money_for_experience = self.__experience__//10
            earned = random.randint(money_for_experience,10+money_for_experience)            
            self.__money__+=earned
            self.__experience__+=random.randint(0,2)
            wantSleepMore = random.randint(7,15)
            wantEatMore = random.randint(7,15)
            self.__need_sleep__+=wantSleepMore
            self.__hungry__+=wantEatMore
            self.__check_end_hungry__()
            if self.__alive__:                
                if earned>0:
                    print('profit',str(earned)+'$')
                else:
                    print('today is not productive day')
                self.get_info()
                self.__check_go_sleep__()

    def buy_laptop(self):
        if self.__alive__ and not self.__sleeping__:
            if not self.laptop:
                if self.__money__<self.__laptop_price__:
                    print('need',str(self.__laptop_price__)+'$')
                else:
                    self.__money__-=self.__laptop_price__
                    self.laptop = Laptop()
                    print('Now You have the laptop')
            else:
                print('You have one laptop')
            

    def full_name(self):
        return self.__second_name__+' '+self.__first_name__+' '+self.__middle_name__

    def get_info(self):
        print('\n\n---------------------------')
        print(self.full_name(),'-',self.__gender__)
        if self.__alive__:
            self.__last_hungry__ = self.__hungry__
            self.__last_need_sleep__ = self.__need_sleep__
        
            print('hungry -',str(self.__hungry__)+'%')
            print('want sleep -',str(self.__need_sleep__)+'%')
            sleeping = 'not sleep'
            if self.__sleeping__:
                sleeping = 'sleep'
            print('sleeping now -',sleeping)
            print('')
            print('money -',self.__money__)            
            print('experience',self.__experience__)
        else:
            print('died at',self.__date_die__)
        print('\n')        
        
        
        
        
user = human()
