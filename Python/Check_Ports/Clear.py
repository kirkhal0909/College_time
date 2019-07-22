import os
List = os.listdir(path=".")

for file in List:
    if os.path.getsize(file) == 0:
        try:
            os.remove(file)
            print(file+' removed')
        except: print("Can't remove file - "+file)
