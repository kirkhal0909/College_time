uses crt,dos;
type struct=record
     sym,ClrT,BackCl: byte;
     tag: string[5];
     title: string[25];
end;

var s1,s2 : char;
 x,y : integer;
 i,j,k: integer;
 desktop,cursor: struct;
 Dots: array [2..24,1..80] of struct;

procedure Draw;
begin
 textbackground(desktop.BackCl); textcolor(4);
 clrscr; writeln(' ',copy(Dots[2][1].title,8,length(Dots[2][1].title)));
 for i := 2 to 24 do
  for j := 1 to 80 do begin
   textcolor(Dots[i][j].ClrT);textbackground(Dots[i][j].BackCl);write(chr(Dots[i][j].sym));
  end;
end;

procedure ReadKeys;
begin
  s1 := #0; s2 := s1;
  s1 := readkey; if s1 = #0 then s2 := readkey;
end;

procedure Move;
begin
  ReadKeys;
  gotoxy(x,y); textbackground(Dots[y,x].BackCl); textcolor(Dots[y][x].ClrT); write(chr(Dots[y][x].sym));
  if (s2 = 'K') then x := x - 1; if x < 1 then x := 1;
  if (s2 = 'M') then x := x + 1; if x > 80 then x := 80;
  if (s2 = 'H') then y := y - 1; if y < 2 then y := 2;
  if (s2 = 'P') then y := y + 1; if y > 24 then y := 24;
  GotoXY(x,y);textbackground(Dots[y][x].BackCl+1); textcolor(Dots[y][x].ClrT-1); write(chr(Dots[y][x].sym));
end;

procedure Time;
var date : array[1..7] of word;
    dateS: array[2..6] of string[2];
begin
  repeat
   textcolor(Desktop.ClrT); textbackground(Desktop.BackCl);
   GetDate(date[1],date[2],date[3],date[4]);
   GetTime(date[4],date[5],date[6],date[7]);
   for i := 2 to 6 do begin
    str(date[i],dateS[i]);
    if date[i] < 10 then dateS[i] := '0'+dateS[i]
   end;
   gotoxy(30,25); write(dateS[4],':',dateS[5],':',dateS[6],'   ',dateS[3],'.',dateS[2],'.',date[1],'      ');
   gotoxy(1,25); write('x = ',x,';  y = ',y,'    ');
   gotoxy(x,y);
   delay(15);
  until keypressed;
end;

procedure Welcome;
var name : string[18]; s : string[9];
    xr,yr : byte;
    xn,yn : byte;
begin
 textbackground(0); clrscr;
 textcolor(1); textbackground(7);
 x := 26; y := 11; xn := x+1; yn := y+2; xr := random(78)+2; yr := random(23)+2;
 gotoxy(x,y); write(' Welcome to system! ');
 gotoxy(x,y+1); write(' What is your name? ');
 gotoxy(x,y+3); write('                    ');
 name := '';
 repeat
 textbackground(0); textcolor(6);
 gotoxy(xn,yn); write('                  ');
 i := 9 - (length(name)+1) div 2; s := ''; for j := 1 to i do s := s + ' ';
 gotoxy(xn,yn); write(s,name);
  repeat
   textbackground(0); textcolor(2);
   while (yr = 25) or ((xr >= 26) and (xr <= x+19) and (yr >= y) and (yr <= y+3))
   do begin xr := random(78)+2; yr := random(23)+2; end;
   gotoxy(xr,yr); write(random(2)); gotoxy(xn+length(s)+length(name),yn);
   yr := yr + 1;
   delay(30);
  until keypressed;
  ReadKeys;
  if (s1 in [']'..'}','!'..'[']) and (length(name)<18) then name := name + s1
  else if s1 = #8 then delete(name,length(name),1);
 until s1 = #13;
 desktop.title := 'desktop' + name;
end;

procedure save;
var f : file of struct;
begin
 assign(f,'C:\Options.txt');
 rewrite(f); write(f,desktop);
 for i := 1 to 10 do
  for j := 1 to 7 do
   write(f,dots[j*3][i*8-4]);

{  for i := 1 to 7 do write(f,dots[3][i]);}
  close(f);
end;

procedure Load;
var f : file of struct;
begin
 randomize;
 assign(f,'C:\Options.txt');{$I-}
 reset(f);
 read(f,desktop);
 if IOresult <> 0 then begin
  desktop.sym := ord('Û'); desktop.ClrT := 7; desktop.BackCl := 0;
  desktop.title := 'desktop'; desktop.tag := '0'; welcome;
  save; reset(f); read(f,desktop);
 end; {$I+}
 for i := 2 to 24 do
  for j := 1 to 80 do
   Dots[i][j] := desktop;
 for i := 1 to 10 do
  for j := 1 to 7 do begin
   read(f,Dots[j*3][i*8-4]);
   for k := 1 to 5 do begin
    dots[j*3+1][i*8-7+k].sym := ord(dots[j*3][i*8-4].title[k]);
    dots[j*3+1][i*8-7+k].ClrT := 0; dots[j*3+1][i*8-7+k].BackCl := 7;
   end;
  end;
 close(f);
 mkdir('C:\System');
 mkdir('C:\System\'+ copy(Dots[2][1].title,8,length(Dots[2][1].title)));

end;

begin
 load; x := 4; y := 3;
 Dots[y][x].sym := 219; Dots[y][x].ClrT := 7; Dots[y][x].BackCl := 0; Dots[y][x].title := 'piano';
  for i := 1 to 10 do
  for j := 1 to 7 do begin
   dots[j*3][i*8-4].sym := 254;
   dots[j*3][i*8-4].ClrT := 0;
   dots[j*3][i*8-4].BackCl := 7;
   dots[j*3][i*8-4].title := 'Label';
  end;
 {Dots[y+1][x-2].sym := ord('P'); Dots[y+1][x-2].ClrT := 0; Dots[y+1][x-2].BackCl := 7;
 Dots[y+1][x-1].sym := ord('i'); Dots[y+1][x-1].ClrT := 0; Dots[y+1][x-1].BackCl := 7;
 Dots[y+1][x].sym := ord('a'); Dots[y+1][x].ClrT := 0; Dots[y+1][x].BackCl := 7;
 Dots[y+1][x+1].sym := ord('n'); Dots[y+1][x+1].ClrT := 0; Dots[y+1][x+1].BackCl := 7;
 Dots[y+1][x+2].sym := ord('o'); Dots[y+1][x+2].ClrT := 0; Dots[y+1][x+2].BackCl := 7;

 x := 12; y := 3;
 Dots[y][x].sym := 254; Dots[y][x].ClrT := 7; Dots[y][x].BackCl := 0;
 Dots[y+1][x-2].sym := ord('P'); Dots[y+1][x-2].ClrT := 0; Dots[y+1][x-2].BackCl := 7;
 Dots[y+1][x-1].sym := ord('i'); Dots[y+1][x-1].ClrT := 0; Dots[y+1][x-1].BackCl := 7;
 Dots[y+1][x].sym := ord('a'); Dots[y+1][x].ClrT := 0; Dots[y+1][x].BackCl := 7;
 Dots[y+1][x+1].sym := ord('n'); Dots[y+1][x+1].ClrT := 0; Dots[y+1][x+1].BackCl := 7;
 Dots[y+1][x+2].sym := ord('o'); Dots[y+1][x+2].ClrT := 0; Dots[y+1][x+2].BackCl := 7;

 x := 4; y := 6;
 Dots[y][x].sym := 254; Dots[y][x].ClrT := 7; Dots[y][x].BackCl := 0;
 Dots[y+1][x-2].sym := ord('P'); Dots[y+1][x-2].ClrT := 0; Dots[y+1][x-2].BackCl := 7;
 Dots[y+1][x-1].sym := ord('i'); Dots[y+1][x-1].ClrT := 0; Dots[y+1][x-1].BackCl := 7;
 Dots[y+1][x].sym := ord('a'); Dots[y+1][x].ClrT := 0; Dots[y+1][x].BackCl := 7;
 Dots[y+1][x+1].sym := ord('n'); Dots[y+1][x+1].ClrT := 0; Dots[y+1][x+1].BackCl := 7;
 Dots[y+1][x+2].sym := ord('o'); Dots[y+1][x+2].ClrT := 0; Dots[y+1][x+2].BackCl := 7;}
 Draw;
{ Cursor.BackCl}
 x := 50; y := 12;
 repeat
  Move;
  Time;
 until s1 = #27;
 save;
end.