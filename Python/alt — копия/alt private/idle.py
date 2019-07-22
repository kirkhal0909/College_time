from my_API import *

for block_num in range(0,len(mainData),maxAccounts):
        block = []
        to = block_num+maxAccounts
        if to>len(mainData):
                to = len(mainData)
        for i in range(block_num,to):
                block.append(mainData[i])
        print(block)
        #print(block_num//maxAccounts)
        x = threading.Thread(target=initBot, args=(block,user_agents[1],proxy[block_num//maxAccounts],))
        x.start()
        time.sleep(random.randint(4,10))
