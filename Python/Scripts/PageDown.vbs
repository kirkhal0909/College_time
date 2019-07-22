'PAGE DOWN -{PGDN}
'PAGE UP -{PGUP}
Set s = WScript.CreateObject("WScript.Shell")
do 
wscript.sleep 80 
s.sendkeys"{numlock}"
wscript.sleep 80
 s.SendKeys"{PGdN}"
 wscript.Sleep 200
loop 