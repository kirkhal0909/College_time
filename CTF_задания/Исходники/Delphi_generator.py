def getCode(f,mn):
    l = len(f)
    print("var s:string; i: integer;")
    print("begin")
    print("\tfor i := 1 to "+str(l)+" do s := s + chr(i*"+str(mn)+");")

    for i in range(1,l+1):
        code = ord(f[i-1])-i*mn
        if(code>=0):
            code = "+"+str(code)
        else: code = str(code)
        print("\ts["+str(i)+"]:=chr(ord(s["+str(i)+"])"+code+");")

    print("\tSelf.Caption := s;")
    print("\tShowMessage(s);")


f = '''flag{Suspend_program_process}'''
mn = 1


getCode(f,mn)
