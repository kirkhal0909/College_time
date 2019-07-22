import time

sym = ' '
sp = ' '
m = 0
mult = 9
multStr = 5

while True:
	#s='''*****************\n*****************\n**     ***     **\n**   *******   **\n**  **     **  **\n** **  ***  ** **\n** **  ***  ** **\n**  **     **  **\n**   *******   **\n**     ***     **\n*****************\n*****************'''
	#s='''*****************\n*****************\n**             **\n**             **\n**             **\n**     ***     **\n**     ***     **\n**             **\n**             **\n**             **\n*****************\n*****************'''
	s='''*****************\n*****************\n**             **\n**             **\n**             **\n**             **\n**             **\n**             **\n**             **\n**             **\n*****************\n*****************'''
	
	time.sleep(0.25)
	#up
	if m == 0:
		s = s[:43]+sym*3+s[46:]
		s = s[:61]+sym*3+s[64:]
		s = s[:64]+sp*2+s[66:]
		s = s[:83]+sp*2+s[85:]
	
	#left-up
	elif m == 1:
		s = s[:59]+sym*2+s[61:]
		s = s[:76]+sym*2+s[78:]
		s = s[:43]+sp*3+s[46:]
		s = s[:61]+sp*3+s[64:]
	
	#left
	elif m == 2:
		s = s[:93]+sym*2+s[95:]
		s = s[:111]+sym*2+s[113:]
		s = s[:59]+sp*2+s[61:]
		s = s[:76]+sp*2+s[78:]
	
	#down-left
	elif m == 3:
		s = s[:130]+sym*2+s[132:]
		s = s[:149]+sym*2+s[151:]
		s = s[:93]+sp*2+s[95:]
		s = s[:111]+sp*2+s[113:]
	
	#down
	elif m == 4:
		s = s[:151]+sym*3+s[154:]
		s = s[:169]+sym*3+s[172:]
		s = s[:130]+sp*2+s[132:]
		s = s[:149]+sp*2+s[151:]
	
	#right-down
	elif m == 5:
		s = s[:137]+sym*2+s[139:]
		s = s[:154]+sym*2+s[156:]
		s = s[:151]+sp*3+s[154:]
		s = s[:169]+sp*3+s[172:]
	
	#right
	elif m == 6:
		s = s[:102]+sym*2+s[104:]
		s = s[:120]+sym*2+s[122:]
		s = s[:137]+sp*2+s[139:]
		s = s[:154]+sp*2+s[156:]
	
	#right-up
	elif m == 7:
		s = s[:64]+sym*2+s[66:]
		s = s[:83]+sym*2+s[85:]
		s = s[:102]+sp*2+s[104:]
		s = s[:120]+sp*2+s[122:]
		m = -1
		
	m += 1
	sym = '*'
	
	#s =('*'*160+'\n')*62
	sc = ''
	for i in range(0,len(s)):
		if s.find('\n',i,len(s)) != i: sc += s[i]*mult
		else: sc += '\n'
	s = sc
	sc = ''
	boof = ''
	
	for i in range(0,len(s)):
		if s.find('\n',i,len(s)) != i: boof += s[i]
		else:
			sc += (boof+'\n')*multStr
			boof = ''
		if i == len(s)-1:
			sc += (boof+'\n')*multStr
			boof = ''
	print(sc)

