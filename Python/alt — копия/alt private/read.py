file_proxy = open('https.txt','r')
proxy = file_proxy.read().split(' ')
file_proxy.close()

file_user_agents = open('User_agents.txt','r')
user_agents = file_user_agents.read().split('\n')
file_user_agents.close()
