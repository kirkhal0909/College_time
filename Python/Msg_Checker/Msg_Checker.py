import requests,time,datetime,random,os

global sleep
#Время проверки в секундах
sleep = 10



global P,L

#Логин и пароль      
P = '70 70 70 70 31 32 33 34'
L = '55 57 55 56 48 48 48 48 48 48 48'


  
p = ''
dec = ''
for s in P.split(' '):
    p = p+chr(int(s))
P = p
        
        

l = ''
for s in L.split(' '):
        l = l+chr(int(s))
L = l

def AuthVK():
        global r,s
        global ID,SendMsg
        ID = '0'
        session = requests.Session()

        session.headers.update({'User-Agent':'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36',
                  'content-type':'application/x-www-form-urlencoded',
                  'accept-encoding':'gzip, deflate, br'})
        r = session.get('https://login.vk.com/?act=login')
        t = r.text
        #print(t)
        ip_h = ParsePhrase(t,'ip_h" value="','"')
        lg_h = ParsePhrase(t,'lg_h" value="','"')
        #ip_h = t[t.find('ip_h" value="')+len('ip_h" value="'):t.find('"',t.find('ip_h" value="')+len('ip_h" value="'))]
        #lg_h = t[t.find('lg_h" value="')+len('lg_h" value="'):t.find('"',t.find('lg_h" value="')+len('lg_h" value="'))]
        if len(ip_h) < 10:
                ip_h = ParsePhrase(t,'ip_h=','&')
                lg_h = ParsePhrase(t,'lg_h=','&')
        	#ip_h = t[t.find('ip_h=')+len('ip_h='):t.find('&',t.find('ip_h=')+len('ip_h='))]
        	#lg_h = t[t.find('lg_h=')+len('lg_h='):t.find('&',t.find('lg_h=')+len('lg_h='))]
        postdata = {'act': 'login',
                    'role': 'al_frame',
			'expire':'','recaptcha':'',
			'captcha_sid':'','captcha_key':'',
			'_origin':'https://vk.com',
			'ip_h': ip_h, 'lg_h': lg_h,
			'email': L, 'pass': P}
        time.sleep(random.random()*2)
        r = session.post('https://login.vk.com/?act=login', data=postdata)
        if r.text.find('onLoginDone') == -1: Login = False
        else : Login = True
        if Login: print('Login - True')
        else:
                print('Login Error')
                fError = open('ErrLog.txt','a')
                fError.write(str(datetime.datetime.now()))
                fError.close()                
        s = session
        ID = ParsePhrase(r.text,'/id',"'")
        slp1 = 3
        slp2 = 9

        FolderName = 'Msgs'
        
        Folder = FolderName+'\\'
        if os.path.exists(Folder) == False:
                os.mkdir(Folder)

        lastMsgs = {}
        if Login:
                while True:
                        try:
                                r = s.get('https://vk.com/im')
                                t = r.text
                                blocks = []               
                                beg = 'nim-dialog--photo'
                                end = '_im_dialog_unread_ct'
                                '''
                                ttt = open('get.txt','w')
                                ttt.write(t)
                                ttt.close()
                                '''
                                while beg in t:                        
                                        #print(str(t.find(beg))+' '+str(t.find(end)))
                                        tmp = t[t.find(beg):t.find(end)]
                                        blocks.append(tmp)
                                        t = t[t.find(end)+1:len(t)]
                                for block in blocks:
                                        beg = '_im_unread_blind_label">'
                                        end = '</label>'
                                        message = ParsePhrase(block,beg,end)
                                        if message != '':
                                                message = int(message.split(' ')[0])
                                                #print(message)                                
                                                Name = ParsePhrase(block,'alt="','"')
                                                manID = ParsePhrase(block,'/id','"')                                                
                                                postdata = {'act':'a_start','al':'1',
                                                            'block':'false',
                                                            'gid':'0',
                                                            'history':'true',
                                                            'im_v':'2',
                                                            'msgid':'false',
                                                            'peer':manID,
                                                            'prevpeer':'0'}
                                                '''
                                                postdata = {'act':'a_history','al':'1',
                                                            'gid':'0',        
                                                            'im_v':'2',
                                                            'offset':'30',
                                                            'peer':manID,
                                                            'toend':'0',
                                                            'whole':'0'}
                                                '''                                
                                                r = s.post('https://vk.com/al_im.php',data=postdata)
                                                lstmsg = ParsePhrase(r.text,'"lastmsg":',',')
                                                if lastMsgs.get(manID) == None:
                                                        lastMsgs[manID] = '0'
                                                if lastMsgs[manID] != lstmsg:
                                                        print(Name+'('+manID+') '+ParsePhrase(block,beg,end))
                                                        deltaMsg = int(lstmsg) - int(lastMsgs[manID])
                                                        lastMsgs[manID] = lstmsg                                        
                                                        '''      
                                                        print(lastMsgs)
                                                        input()
                                                        f = open('tmp3.txt','w')                                
                                                        f.write(r.text)
                                                        f.close()
                                                        '''
                                                        beg = '"msgs":{"'
                                                        end = '<!json>'
                                                        block = ParsePhrase(r.text,beg,end)
                                                        blocks = block.split(':[')
                                                        msgs = []
                                                        attchs = []
                                                        for i in range(0,len(blocks)):
                                                                       blocks[i] = blocks[i][blocks[i].find('"')+1:len(blocks[i])]
                                                                       msgs.append(blocks[i][0:blocks[i].find('",')])
                                                                       attchs.append(ParsePhrase(blocks[i],'",',','))
                                                                       #print(blocks[i])
                                                        if deltaMsg<message:
                                                                message = deltaMsg
                                                        if message>len(msgs):
                                                                message = len(msgs)
                                                        messageFrom = len(msgs)-message
                                                        if messageFrom<0: messageFrom = 0
                                                        f = open(Folder+Name+'('+manID+').txt','a')
                                                        f.write('\n'+str(datetime.datetime.now())+'\n')
                                                        for i in range(messageFrom,len(msgs)):
                                                                       f.write(msgs[i]+'\n')
                                                        
                                                        
                                                        f.close()
                                                        #print(msgs)
                                                        
                                                        #print(attchs)
                        except:
                                print('Error')
                        time.sleep(sleep)

def ParsePhrase(t,phrase,sym):
        return t[t.find(phrase)+len(phrase):t.find(sym,t.find(phrase)+len(phrase))]


										
										
                              

AuthVK()


exit()
