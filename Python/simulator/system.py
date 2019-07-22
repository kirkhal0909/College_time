import time
import threading
from clicker import *


class System:

    __runned__ = False
    __loading__ = False

    __system__ = 'Funny system'
    __time_loading__ = 1 #seconds
    __list_to_show__ = []

    __password__ = ''
    __lockded__ = False

    clicker = False
    autoclicker = False

    class __Autoclicker__():
        __system_access_func_get__ = False
        __application_func_click__ = False
        __use_time_sleep__ = True
        __runned__ = False
        time_faster = 1
        
        def __init__(self,system_access_func_get,application_func_click):            
            self.__system_access_func_get__ = system_access_func_get
            self.__application_func_click__ = application_func_click

        def start(self):
            if self.__system_access_func_get__:
                if not self.__runned__:
                    self.__runned__ = True
                    self.__thread_do_click__()

        def stop(self):
            if self.__system_access_func_get__:
                self.__runned__ = False

        def switch_using_time_sleep(self):
            if self.__system_access_func_get__:
                self.__use_time_sleep__ = not self.__use_time_sleep__
                if self.__use_time_sleep__:
                    print('enable')
                else:
                    print('disable')

        def __do_click__(self):
            if self.__system_access_func_get__:
                while self.__runned__:
                    self.__application_func_click__()
                    if self.__use_time_sleep__:
                        time.sleep(1/self.time_faster)

        def __thread_do_click__(self):
            if self.__system_access_func_get__:
                thread = threading.Thread(target=self.__do_click__)
                thread.start()

    class __Clicker__():
        __application__ = False
        __system_access_func_get__ = False

        def __init__(self,system_access_func_get):            
            self.__system_access_func_get__ = system_access_func_get
            self.__application__ = application()

        def click(self):
            if self.__system_access_func_get__():
                self.__application__.click()

        def close(self):
            if self.__system_access_func_get__():
                self.__application__.close()

        def start(self):
            if self.__system_access_func_get__():
                self.__application__.start()

        def buyDeveloper(self):
            if self.__system_access_func_get__():
                self.__application__.buyDeveloper()

        def getProfitList(self):
            if self.__system_access_func_get__():
                self.__application__.getProfitList()

        def showBalance(self):
            if self.__system_access_func_get__():
                self.__application__.showBalance()
                
    def __system_access__(self):
        return self.__runned__ and not self.__loading__ and not self.__lockded__
    
    def __init__(self,system = 'Funny system'):
        self.__system__ = system
        self.__create_list_to_show__()
        self.start()
        self.install_clicker()

    def __create_list_to_show__(self):
        list_methods = dir(self)
        for method in list_methods:
            if method[0]!='_' or method[1]!='_':
                self.__list_to_show__.append(method)
        #print(self.__list_to_show__)

    def __application_installed__(self):
        installed = False
        if self.clicker:
            installed = True
        return installed

    def __autoclicker_installed__(self):
        installed = False
        if self.autoclicker:
            installed = True
        return installed

    def status_runned(self):
        return self.__runned__

    def start(self):
        if not self.__runned__ and not self.__loading__:            
            thread = threading.Thread(target=self.__run_system__)
            thread.start()

    def set_password(self,password = ''):       
        if self.__password__:                        
            checkPass = str(input('enter old password: '))
            agains = 2
            while agains>0 and checkPass!=self.__password__:
                print('passwords not equal')
                agains-=1
                checkPass = str(input('enter old password: '))                

            if checkPass!=self.__password__:                
                return None
    
        if not(password):
            while not password:
                password = str(input('enter new password: '))
                
        again_password = str(input('enter password again: '))
        if again_password == password:
            print('password setuped')
            self.__password__ = password
        else:
            print('passwords not equal')

    def lock(self):
        self.__lockded__ = True
        print(self.__system__,'is locked')

    def unlock(self,password = ''):
        if (self.__password__) and (password == ''):
            password = str(input('to unlock enter password: '))
        if not(self.__password__) or (password==self.__password__):
            self.__lockded__ = False
            print(self.__system__,'is unlocked')
        else:
            print('wrong password')
    
    def __run_system__(self):
        if not self.__runned__ and not self.__loading__:
            self.__loading__ = True
            self.__runned__ = True
            time.sleep(0.5)
            charLoading = self.__time_loading__ / len(self.__system__)
            for sym in self.__system__:
                print(sym,end='')
                time.sleep(charLoading)
            print()
            self.__loading__ = False
            print(self.__system__,'is running')
            print()
            print('Welcome')

    def install_clicker(self):
        if self.__system_access__():
            if not self.__application_installed__():
                print('Please wait')
                time.sleep(1)
                print('run application')
                self.clicker = self.__Clicker__(self.__system_access__)
                #self.clicker = application()            
            else:
                print('clicker already installed')

    def uninstall_clicker(self):
        if self.__system_access__():
            if self.__application_installed__():
                print('Please wait')
                self.clicker.close()
                time.sleep(1)                
                self.clicker = False
                print('clicker uninstalled')
            else:
                print('clicker not found')

    def install_autoclicker(self):
        if self.__system_access__():
            if not self.__autoclicker_installed__():
                print('Please wait')
                time.sleep(1)
                if self.__application_installed__():
                    self.autoclicker = self.__Autoclicker__(self.__system_access__,self.clicker.click)
                    print('install completed')
                else:
                    print('install is broken. Clicker not found!')                    
            else:
                print('autoclicker already installed')

    def uninstall_autoclicker(self):
        if self.__system_access__():
            if self.__autoclicker_installed__():
                print('Please wait')
                self.autoclicker.stop()
                time.sleep(1)
                self.autoclicker = False                                
                print('autoclicker uninstalled')
            else:
                print('autoclicker not found')
                
