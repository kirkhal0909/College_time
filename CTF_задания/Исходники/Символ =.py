f = open('out.txt','w')
t = 'flag{congratulations with solve this task}'
mult = 0
for s in t:
    s = s.lower()
    if(s>='a') and (s<='z'):
        f.write('='*(ord(s)-ord('a')+1+2*mult))
    else:
        f.write(s)
    f.write('\n')
    mult = mult+1
f.close()
