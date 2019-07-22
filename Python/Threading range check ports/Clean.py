import os

def CleanEmptyFoldersAndJoin(Path):
    False
    if Path == '': Path = None
    Files = os.listdir(Path)
    if Path == None: Path = '.'
    IPs = open('All_IPs.txt','w')
    for file in Files:
        if os.path.isdir(Path+'\\'+file):
            nextPath = file
            if Path == '':
                nextPath = file
            else:
                nextPath = Path+'\\'+file
            #print('recurse')
            CleanEmptyFoldersAndJoin(nextPath)
        else:
            #if Path == '': Path = '.'
            #print(Path)
            if os.path.getsize(Path+'\\'+file) == 0:                
                os.remove(Path+'\\'+file)
            else:
                if file.split('.')[::-1][0] == 'txt':
                    f = open(Path+'\\'+file,'r')
                    tmp = f.read()
                    f.close()
                    IPs.write(tmp)
    IPs.close()
    if Path == '.': Path = ''
    if Path == '': Path = None
    Files = os.listdir(Path)
    if Path == None: Path = ''
    if len(Files) == 0:
        os.rmdir(Path)
        
CleanEmptyFoldersAndJoin('')
