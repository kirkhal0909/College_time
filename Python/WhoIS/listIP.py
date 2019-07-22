import os
folder = os.listdir()
ranges = []
f = open('RangesIP.txt','w')
for file in folder:
    f.write(file.split('.')[0]+'\n')
    ranges.append(file.split('.')[0])
f.close()
print(ranges)
