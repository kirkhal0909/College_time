uses crt,dos;
type struct=record
     sym: byte;
     ClrT: byte;
     BackCl: byte;
     tag: string[10];
end;

var s1,s2 : char;
 x,y : integer;
 i,j: integer;
 f : file of struct;
 desktop: struct;

begin
 assign(f,'C:\Options.txt');
 read(f,desktop);
 s1 := '1'; x := 50; y := 12; clrscr;
 GotoXY(1,2);
 textbackground(desktop.BackCl);
 textcolor(desktop.ClrT);
 for i := 1 to 23*80 do write(chr(desktop.sym));

 repeat
  s1 := readkey; if s1 = #0 then s2 := readkey;
  gotoxy(x,y); textbackground(desktop.BackCl); write(chr(desktop.sym));
  if (s2 = 'K') then x := x - 1;
  if (s2 = 'M') then x := x + 1;
  if (s2 = 'H') then y := y - 1;
  if (s2 = 'P') then y := y + 1;

  GotoXY(x,y);textbackground(desktop.BackCl+1); write(chr(desktop.sym));
 until s1 = #27
end.