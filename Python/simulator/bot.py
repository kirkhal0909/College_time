from start_clicker import *

class autoclicker:
    speed = 0.1
    times = 10000
    repeat = True
    __started__ = False

    def __init__(self,speed=0.1,times=10000,repeat=True):
        self.speed = speed
        self.times = times
        self.repeat = repeat
        print('Init autoclicker')
        print('speed =',speed)
        global app  
        if repeat:
            print('repeat until stop')
        else:
            print('repeat',times,'times')
        print('\n')
        self.start()

    def start(self):
        if not self.__started__:
            self.__started__ = True
            thread = threading.Thread(target=self.__doClicks__)       
            thread.start()

    def __doClicks__(self):
        global app
        app.start()
        while self.repeat or self.times>0:
            if not self.repeat:
                self.times-=1
            app.click()
            time.sleep(self.speed)
        self.__started__ = False
        app.close()
                

clicker = autoclicker(0.01,100,False)
