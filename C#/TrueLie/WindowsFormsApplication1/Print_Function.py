for i in range(19,37):
    print("if(this.LocalCard"+str(i)+".InvokeRequired)")
    print("{ this.LocalCard"+str(i)+".BeginInvoke((MethodInvoker)delegate() { LocalCard"+str(i)+".Visible = true; LocalCard"+str(i)+".Left = ClientTopPos; }); }")
    print("else { LocalCard"+str(i)+".Visible = true; LocalCard"+str(i)+".Left = ClientTopPos;}")



    
