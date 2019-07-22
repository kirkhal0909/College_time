f = open('st.txt','r')
st = f.read().split('\n')
f.close()

'''
f = open('out.txt','r')
students_text = f.read().split('\n')
f.close()
'''
students = []

scn_nm = {}
frs_nm = {}
mid_nm = {}
for s in st:
    if '(' in s:
        print(s)
    s = s.split(' ')
    if len(s)>=3:
        students.append([s[0],s[1],s[2]])
        #if not s[2]:
            #print(s[0],s[1])
            #exit()
        #print(' '.join(students[-1]))
        try:
            if s[0]!='1':
                scn_nm[s[0]]+=1
        except:
            scn_nm[s[0]]=1
        
        try:
            frs_nm[s[1]]+=1
        except:
            frs_nm[s[1]]=1

        try:
            mid_nm[s[2]]+=1
        except:
            mid_nm[s[2]]=1

frs_nm= sorted(frs_nm.items(), key=lambda kv: kv[1],reverse=True)
scn_nm= sorted(scn_nm.items(), key=lambda kv: kv[1],reverse=True)
mid_nm= sorted(mid_nm.items(), key=lambda kv: kv[1],reverse=True)

f = open('top.txt','w')
f.write('Разных фамилий '+str(len(scn_nm))+'\n')
f.write('Топ повторяющихся фамилий:\n')
last = len(students)+1
top = 0
print('Фамилии')
step = 1
for nm in scn_nm:
    if last!=nm[1]:
        last = nm[1]
        top+=1
    print(str(top)+') '+nm[0]+' '+str(nm[1]))
    f.write(str(top)+') '+nm[0]+' '+str(nm[1])+'\n')
    step+=1
    #print(nm+' '+str(scn_nm(nm)))
print(scn_nm)

last = len(students)+1
step=1
top = 0
f.write('Разных имён '+str(len(frs_nm))+'\n')
f.write('\n\n\nТоп повторяющихся имён:\n')
print()
print('Имена')
for nm in frs_nm:
    if last!=nm[1]:
        last = nm[1]
        top+=1
    print(str(top)+') '+nm[0]+' '+str(nm[1]))
    f.write(str(top)+') '+nm[0]+' '+str(nm[1])+'\n')
    step+=1
    #print(nm+' '+str(frs_nm(nm)))
print(frs_nm)

f.write('Разных отчеств '+str(len(mid_nm))+'\n')
f.write('\n\n\nТоп повторяющихся отчеств:\n')
last = len(students)+1
top = 0
step=1
print()
print('Отчества')
for nm in mid_nm:
    if last!=nm[1]:
        last = nm[1]
        top+=1
    print(str(top)+') '+nm[0]+' '+str(nm[1]))
    f.write(str(top)+') '+nm[0]+' '+str(nm[1])+'\n')
    step+=1
    #print(nm+' '+str(mid_nm(nm)))
print(mid_nm)

        
f.close()
    

