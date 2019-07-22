import requests,threading,ipwhois,os

def ParsePhrase(t,phrase,sym):
        return t[t.find(phrase)+len(phrase):t.find(sym,t.find(phrase)+len(phrase))]

s = requests.Session()
IP = '23.128.1.0'
Folder = 'LookUP'
if os.path.exists(Folder) == False:
        os.mkdir(Folder)
#IP = '185.146.212.234'
notEnd = True

while notEnd:
        try:
                fileName = IP+'.txt'
                obj = ipwhois.IPWhois(IP)
                whois = obj.lookup_whois()
                try:
                        provider = whois['asn_description']+' <=> '+whois['nets'][0]['name']
                except:
                        try:
                                provider = whois['asn_description']
                        except:
                                try:
                                        provider = whois['nets'][0]['name']
                                except:
                                        provider = ''
                try: address = whois['nets'][0]['address']
                except: address = '-'
                try: rng = whois['nets'][0]['range']
                except: rng = IP
                try: country = whois['asn_country_code']
                except: country = '-'

                if not country == None:
                        if len(country)>1:
                                if os.path.exists(Folder+'\\'+country) == False:
                                        os.mkdir(Folder+'\\'+country)
                                fileName = country+'\\'+fileName
                if len(rng)>len(IP): f = open(Folder+'\\'+country+'\\'+rng+'.txt','w')
                else: f = open(Folder+'\\'+fileName,'w')        
                try:f.write(rng)
                except: False
                try:
                        f.write('\nprovider: '+provider)
                except: False
                try:f.write('\naddress:  '+address)
                except: False
                try:f.write('\nrange:    '+rng)
                except: False
                try:f.write('\ncountry:  '+country)
                except: False
                try:IP = rng.split('-')[1][1::].split('.')
                except: False
                if int(IP[3])<255:
                        IP[3] = str(int(IP[3])+1)
                else:
                        IP[3] = '0'
                        if int(IP[2])<255:
                                IP[2] = str(int(IP[2])+1)
                        else:
                                IP[2] = '0'
                                if int(IP[1])<255:
                                        IP[1] = str(int(IP[1])+1)
                                else:
                                        IP[1] = '0'
                                        if int(IP[0])<255:
                                                IP[0] = str(int(IP[0])+1)
                                        else: notEnd = False
                IP = str(IP[0])+'.'+str(IP[1])+'.'+str(IP[2])+'.'+str(IP[3])
                print(' ')
                print(country)
        except Exception as e:
                f = open(Folder+'\\'+'!Err_'+IP+'.txt','w')
                f.write(str(e))
                if int(IP.split('.')[0])<256:
                        IP = str(int(IP.split('.')[0])+1)+'.0.0.0'
                else:
                        notEnd = False
        f.close()
        print(IP)
'''
r = s.get('http://www.whois-service.ru/lookup/')
t = r.text
real = ParsePhrase(t,'"real" value="','"')
postdata = {'real':real,'domain':IP}
print(real)
'''



'''
r = s.get('https://awebanalysis.com/ru/ip-lookup/190.168.0.0/')
f = open('code.txt','w')
t = r.text
try:
        f.write(t)
except: False
f.close()
print(r.text)
'''
