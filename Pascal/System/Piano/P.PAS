uses crt;
var s : string;
procedure DrawKey (n,c,x,y: byte);
const
var p : integer;
begin
 p := 1;
end;
procedure DrawPiano(x,y: integer);
var i : integer;
begin
 for i := 1 to 22 do DrawKey(i,7,x,y);
 gotoxy(x,y); write('€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€€');
 for i := 2 to 9 do begin
  gotoxy(x,y-1+i); write('€€'); gotoxy(x+13*5+2,y-1+i); write('€€');
 end;
 gotoxy(x,y+9); write('ﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂﬂ');
end;

begin
 clrscr;
 DrawPiano(1,1);
 write(s);
 readln;
end.
