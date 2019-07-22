print('Мини шифровка')
print('Чтобы зашифровать пароль, его нужно ввести ниже:')
passw = str(input())
enc = ''
for s in passw:
    enc = enc + str(ord(s))+' '

enc = enc[0:len(enc)-1]
print(enc)

print('И чтобы зашифровать логин, его нужно ввести ниже:')
passw = str(input())
enc = ''
for s in passw:
    enc = enc + str(ord(s))+' '

enc = enc[0:len(enc)-1]
print(enc)

input()
