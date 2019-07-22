f = open('Итог1.txt','r')
t = f.read()
f.close()

lines = t.split('\n')
out = ''
for line in lines:
    delete = False
    if line.find('.')!=-1:
        delete = True
    if 'Куратор' in line:
        delete = True
    if 'Список' in line:
        delete = True
    onlySpace = True
    if not delete:
        for char in line:
            if char != ' ':
                onlySpace = False
                break
    if onlySpace:
        delete = True
    if not delete:
        out=out+line+'\n'

f = open('out.txt','w')
f.write(out)
f.close()
        
