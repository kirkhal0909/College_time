import requests

def parse(t,phrase,sym):
    return t[t.find(phrase)+len(phrase):t.find(sym,t.find(phrase)+len(phrase))]

def getList(t,strt,end='"'):
    l = []
    pos = t.find(strt)
    while pos!=-1:
        l.append(parse(t,strt,end))
        t = t[pos+1:len(t)]
        pos = t.find(strt)
    return l
        

r = requests.get('http://college.cfuv.ru/studencheskaya-zhizn-2/spiski-grupp-1-go-kursa')
l = getList(r.text,'href="')
for i in range(len(l)-1,-1,-1):
    if not '.pdf' in l[i]:
        del l[i]
print(l)

for link in l:
    r = requests.get(link)
    file = open(link.split('/')[-1],'wb')
    file.write(r.content)
    file.close()
