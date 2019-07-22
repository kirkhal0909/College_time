import urllib.request
import requests

import os

D1 = "178"
#D2 = "34"
#D3 = "187"

#IP = D1+'.'+D2+'.'+D3+'.'

#file = open(IP+"txt","w")

for D2 in range(0,256):
	for D3 in range(0,256):
		IP = str(D1)+'.'+str(D2)+'.'+str(D3)+'.'
		file = open(IP+"txt","w")
		IPs = 0
		for D4 in range(0,256):
			try:
				IP = str(D1)+'.'+str(D2)+'.'+str(D3)+'.'+str(D4)
				requests.head("http://"+IP,timeout=0.05)
				print(IP)
				file.write(IP+"\n")
				IPs += 1
			except:
				print("		Status Web - off        "+IP)
		file.close()
		if IPs == 0: os.remove(str(D1)+'.'+str(D2)+'.'+str(D3)+'.txt')
input()
