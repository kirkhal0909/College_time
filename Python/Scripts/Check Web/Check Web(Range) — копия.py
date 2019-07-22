import urllib.request
import requests

D1 = "178"
D2 = "34"
D3 = "187"

IP = D1+'.'+D2+'.'+D3+'.'

file = open(IP+"txt","w")

for i in range(0,256):
	try:
		IP = D1+'.'+D2+'.'+D3+'.'+str(i)
		#urllib.request.urlopen("http://"+IP).getcode()
		requests.head("http://"+IP,timeout=0.05)
		print(IP)
		file.write(IP+"\n")
		#print("true")
	except:
		print("		Status Web - off        "+IP)
file.close()
input()
