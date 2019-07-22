import time
import random
import threading
import pickle
from system import *

class Laptop:
    system = False
    __runned__ = False
    __manufacturer__ = 'Funny studio'
    __model__ = 'model 1337'
    
    __do_dump_every__ = 10 #seconds
    __dump_system_file_name__ = 'system'
    
    def __init__(self,manufacturer='Funny studio',model='model 1337'):
        self.__manufacturer__ = manufacturer
        self.__model__ = model
        self.start()    
    
    def __thread_dump_system__(self):        
        thread = threading.Thread(target=self.__dump_system__)
        thread.start()

    def __dump_system__(self):
        while self.__runned__:
            with open(self.__dump_system_file_name__, 'wb') as handle:
                pickle.dump(self.system, handle, protocol=pickle.HIGHEST_PROTOCOL)
            time.sleep(self.__do_dump_every__)

    def __load_dump_system__(self):
        try:
            with open(self.__dump_system_file_name__, 'rb') as handle:
                self.system = pickle.load(handle)                
        except:
            self.system = System()

    def __first_label__(self):
        print(self.__manufacturer__,self.__model__)

    def start(self):
        if not self.__runned__:            
            thread = threading.Thread(target=self.__start_laptop__)
            thread.start()

    def stop(self):
        if self.__runned__:
            if self.system:
                self.system.stop()            
            self.__runned__ = False

    def __start_laptop__(self):
        if not self.__runned__:            
            self.__runned__ = True
            self.__first_label__()
            time.sleep(0.5)
            self.__load_dump_system__()
            time.sleep(0.5)
            self.__thread_dump_system__()
