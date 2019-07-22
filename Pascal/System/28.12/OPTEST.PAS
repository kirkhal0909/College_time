uses crt,dos,game;
const SysDir = 'SYSTEM\';
      SysPath = 'C:\';
      FileOptions = '`OPTIONS.txt';
type struct=record
     sym,ClrT,BackCl: byte;
     tag: string[1];
     title: string[10];
end;

var s1,s2 : char;
 path : string;
 x,y : integer;
 i,j,k: integer;
 desktop,cursor: struct;
 Dots: array [2..24,1..80] of struct;

procedure save;
var f : file of struct;
    r : SearchRec; dir : string;
    s : string[2];
    i,j : integer;
begin
 dir := copy(SysDir,1,length(SysDir)-1);
 FindFirst(SysPath + '*',directory,r);
 repeat
  FindNext(r);
 until (DosError <> 0) or (r.name = dir);
 if r.name <> Dir then mkdir(SysPath+dir);
 assign(f,SysPath + SysDir + FileOptions);
 rewrite(f); write(f,desktop); write(f,cursor);

  close(f);
end;

procedure ReadKeys;
procedure Time;
var date : array[1..7] of word;
    dateS: array[2..6] of string[2];
    i : byte;
begin
  repeat
   textcolor(7); textbackground(Desktop.BackCl);
   gotoxy(15,1); if dateS[6] = '00' then write('                                                    ');
   GetDate(date[1],date[2],date[3],date[4]);
   GetTime(date[4],date[5],date[6],date[7]);
   for i := 2 to 6 do begin
    str(date[i],dateS[i]);
    if date[i] < 10 then dateS[i] := '0'+dateS[i]
   end;
   gotoxy(59,25); write(dateS[4],':',dateS[5],':',dateS[6],'  ',dateS[3],'.',dateS[2],'.',date[1]);
   textcolor(Desktop.BackCl); textbackground(Desktop.ClrT); gotoxy(x,y);
   delay(15);
  until keypressed;
end;
begin
  Time;
  s1 := #0; s2 := s1;
  s1 := readkey; if s1 = #0 then s2 := readkey;
end;

procedure Welcome;
var name : string[18]; s : string[9];
    x,y : byte;
    xr,yr : byte;
    xn,yn : byte;
begin
 textbackground(0); clrscr;
 textcolor(1); textbackground(7);
 x := 26; y := 11; xn := x+1; yn := y+2; xr := random(78)+2; yr := random(24)+2;
 gotoxy(x,y); write(' Welcome to system! ');
 gotoxy(x,y+1); write(' What is your name? ');
 gotoxy(x,y+3); write('                    ');
 name := '';
 repeat
 textbackground(0); textcolor(6);
 gotoxy(xn,yn); write('                  ');
 i := 9 - (length(name)+1) div 2 + length(name) mod 2; s := ''; for j := 1 to i do s := s + ' ';
 gotoxy(xn,yn); write(s,name);
  repeat
   textbackground(0); textcolor(2);
   while (yr = 25) or ((xr >= 26) and (xr <= x+19) and (yr >= y) and (yr <= y+3))
   do begin xr := random(78)+2; yr := random(24)+2; end;
   gotoxy(xr,yr); write(random(2)); gotoxy(xn+length(s)+length(name),yn);
   yr := yr + 1;
   delay(30);
  until keypressed;
  s1 := readkey;
  if (s1 in [']'..'}','!'..'[']) and (length(name)<9) then name := name + s1
  else if s1 = #8 then delete(name,length(name),1);
 until s1 = #13;
 desktop.title := '\' + name;
end;

procedure LoadDirectories(Path : string);
var r : SearchRec; s : string; a,x,y: integer;
begin
FindFirst(Path + '*',directory,r); FindNext(r);
 x := 8; y := 3; i := 1; j := 1; DosError := 0;

 Dots[y*i][x*j-3].title := 'GAME'; Dots[y*i][x*j-3].tag := 'R';
 Dots[y*i][x*j-3].sym := ord('r'); Dots[y*i][x*j-3].BackCl := 4;
 Dots[y*i][x*j-3].ClrT := 7;
 for k := 1 to length(Dots[y*i][x*j-3].title) do begin
  a := k-4-length(Dots[y*i][x*j-3].title) div 2;
  Dots[y*i+1][x*j+a] := Dots[y*i][x*j-3];
  Dots[y*i+1][x*j+a].sym := ord(Dots[y*i][x*j-3].title[k]);
  Dots[y*i+1][x*j+a].ClrT := desktop.BackCl; Dots[y*i+1][x*j+a].BackCl := Desktop.ClrT;
 end;

 while (DosError = 0) do begin
  i := i + 1; if i > 7 then begin i := 1; j := j + 1; end;
  if j = 11 then break;
  s := r.name;
  FindNext(r);
  if (r.name <> s) and (pos('`',r.name) = 0) then begin
     Dots[y*i][x*j-3].title := r.name;
     Dots[y*i][x*j-3].tag := 'D';
     Dots[y*i][x*j-3].sym := ord('d');
     Dots[y*i][x*j-3].BackCl := 6;
     Dots[y*i][x*j-3].ClrT := 7;
     for k := 1 to length(dots[y*i][x*j-3].title) do begin
      a := k-4-length(dots[y*i][x*j-3].title) div 2;
      dots[y*i+1][x*j+a].sym := ord(dots[y*i][x*j-3].title[k]);
      dots[y*i+1][x*j+a].ClrT := desktop.BackCl; dots[y*i+1][x*j+a].BackCl := Desktop.ClrT;
      dots[y*i+1][x*j+a].tag := dots[y*i][x*j-3].tag;
      dots[y*i+1][x*j+a].title := dots[y*i][x*j-3].title;
     end;
  end;
 end;
 if not ((i = 1) and (j = 1)) then begin i := i - 1; if i = 0 then begin i := 7; j := j - 1 end; end;
end;

procedure LoadTextFiles(Path : string);
var r : SearchRec; s : string; a,x,y,c: integer;
begin
FindFirst(Path + '*.txt',anyfile,r);
 c := 0; x := 8; y := 3; DosError := 0; r.name := '.txt';
 while (DosError = 0) do begin
  i := i + 1; if i > 7 then begin i := 1; j := j + 1; end;
  if j = 11 then break;
  s := r.name;
  if c = 1 then FindNext(r);
  if c = 0 then begin FindFirst(Path + '*.txt',anyfile,r); c := 1; end;
  if (r.name <> s) and (pos('`',r.name) = 0) then begin
     Dots[y*i][x*j-3].title := copy(r.name,1,length(r.name)-4);
     Dots[y*i][x*j-3].tag := 'T';
     Dots[y*i][x*j-3].sym := ord('t');
     Dots[y*i][x*j-3].BackCl := 1;
     Dots[y*i][x*j-3].ClrT := 7;
     for k := 1 to length(dots[y*i][x*j-3].title) do begin
      a := k-4-length(dots[y*i][x*j-3].title) div 2;
      dots[y*i+1][x*j+a].sym := ord(dots[y*i][x*j-3].title[k]);
      dots[y*i+1][x*j+a].ClrT := desktop.BackCl; dots[y*i+1][x*j+a].BackCl := Desktop.ClrT;
      dots[y*i+1][x*j+a].tag := dots[y*i][x*j-3].tag;
      dots[y*i+1][x*j+a].title := dots[y*i][x*j-3].title;
     end;
    end;
{   findnext(r);}
   end;
   if not ((i = 1) and (j = 1)) then begin i := i - 1; if i = 0 then begin i := 7; j := j - 1 end; end;

end;

procedure Load;
var f : file of struct;
    x,y: integer;
    k,a: integer;
    r : SearchRec;
begin
 randomize;
 assign(f,SysPath + SysDir + FileOptions);{$I-}
 reset(f);
 read(f,desktop); read(f,cursor);
 if IOresult <> 0 then begin
  desktop.sym := ord('Û'); desktop.ClrT := 7; desktop.BackCl := 0;
  desktop.title := '\';{.title in Welcome} desktop.tag := '0'; welcome;
   cursor.BackCl := desktop.BackCl + 1; cursor.ClrT := desktop.ClrT - 1;
  save; reset(f); read(f,desktop); read(f,cursor);
 end; {$I+}
 for i := 2 to 24 do
  for j := 1 to 80 do
   Dots[i][j] := desktop;

 path := SysPath + SysDir;
 i := 0; j := 1;
 LoadDirectories(path);
 LoadTextFiles(path);

 close(f);
end;

procedure Draw;
var i,j : byte;
begin
 textbackground(desktop.BackCl); textcolor(2);
 clrscr; writeln(' ',copy(Dots[2][1].title,2,length(Dots[2][1].title)-1));
 gotoxy(1,25); textcolor(6); write(Path);
 for i := 2 to 24 do
  for j := 1 to 80 do begin
   gotoxy(j,i); textcolor(Dots[i][j].ClrT);textbackground(Dots[i][j].BackCl);write(chr(Dots[i][j].sym));
  end;
 GotoXY(x,y);textbackground(Cursor.BackCl); textcolor(Cursor.ClrT); write(chr(Dots[y][x].sym));
end;

procedure run;
begin
 if Dots[y][x].title = 'GAME' then begin play; draw; end;
end;

procedure ClearFiles;
begin
 textbackground(desktop.BackCl); textcolor(desktop.ClrT);
 for i := 1 to 10 do
  for j := 1 to 7 do begin
   dots[j*3][i*8-3] := desktop; gotoxy(i*8-3,j*3); write(chr(desktop.sym));
   dots[j*3+1][i*8-7] := desktop; gotoxy(i*8-7,j*3+1); write(chr(desktop.sym));
   for k := 1 to 7 do begin
    dots[j*3+1][i*8-k+1] := desktop;
    gotoxy(i*8-k+1,j*3+1); write(chr(desktop.sym));
   end;
  end;
end;

procedure TXT;
var f : file of char; c : char;
    fs : file of string; s : string;
    s1,s2 : char;
    l : longint;
    xt,yt: byte;
begin
 textcolor(7); textbackground(0);
 clrscr; write; l := 0; xt := 1; yt := 1;
 assign(f,Path + {'`'}Dots[y][x].title + '.TXT');
 reset(f);
 while not EOF(f) do begin
  read(f,c); write(c);
 end;
 seek(f,0);

 repeat
  s1 := #0; s2 := s1;
  s1 := readkey; if s1 = #0 then s2 := readkey;
  if (s2 = 'K') then xt := xt - 1 else if xt < 1 then xt := 1
  else if (s2 = 'M') then xt := xt + 1 else if xt > 80 then xt := 80
  else if (s2 = 'H') then yt := yt - 1 else if yt < 1 then yt := 1
  else if (s2 = 'P') then yt := yt + 1 else if yt > 24 then yt := 24
  else write(s1);
  gotoxy(xt,yt);
 until s1 = #27;
 close(f);
end;

procedure Move;
var info: string; f : file; a : integer; sr : SearchRec;
procedure DeleteFile(Path: string);
begin
 assign(f,Path);
{$I-} erase(f); {$I+}
end;
procedure RemoveDir(path: string);
var
  sr: SearchRec;
begin
  FindFirst(path + '\*.*', AnyFile, sr);
    repeat
     if (((sr.Name='.') or (sr.Name='..'))=false) then
      if sr.Attr=Directory then RemoveDir(path + '\' + sr.name)
      else DeleteFile(path + '\' + sr.name);
      FindNext(sr);
    until (DosError <> 0);
{$I-}  RmDir(path); {$I+}
end;
begin
  ReadKeys;
  gotoxy(x,y); textbackground(Dots[y,x].BackCl); textcolor(Dots[y][x].ClrT); write(chr(Dots[y][x].sym));
  if (s2 = 'K') then x := x - 1; if x < 1 then x := 1;
  if (s2 = 'M') then x := x + 1; if x > 80 then x := 80;
  if (s2 = 'H') then y := y - 1; if y < 2 then y := 2;
  if (s2 = 'P') then y := y + 1; if y > 24 then y := 24;
  GotoXY(x,y);textbackground(Cursor.BackCl); textcolor(Cursor.ClrT); write(chr(Dots[y][x].sym));
  info := Dots[y][x].title[1];

  {Open}
  if (s1 = #13) and (info <> '\') then begin
   if Dots[y][x].tag = 'T' then begin
    TXT;
    draw;
   end;

   if Dots[y][x].tag = 'R' then run;

   if Dots[y][x].tag = 'D' then begin
    Path := Path + Dots[y][x].title + '\';
    ClearFiles;
    LoadDirectories(Path); LoadTextFiles(Path);
    draw;
   end;
  end;

  {Rename}
  if (s1 = #18) and (info <> '\') then begin
   i := (x+6) div 8; j := y div 3;
{   writeln('(x+3) div 8 = ',x+3,' div 8 = ',i); readln;}
   x := i*8-3; y := j*3;
   if dots[y][x].tag = 'D' then assign(f,path + dots[y][x].title);
   if dots[y][x].tag = 'T' then assign(f,path + dots[y][x].title + '.TXT');
   info := dots[y][x].title; textcolor(desktop.backCl); textbackground(desktop.ClrT);
   repeat
    a := length(info) div 2;
    gotoxy(x-3,y+1); write('       '); gotoxy(x-a,y+1); write(info);
    readkeys;
    if (not (s1 in ['`'])) and (s1 in [' ',']'..'}','!'..'[']) and (length(info)<7) then info := info + s1
    else if s1 = #8 then delete(info,length(info),1);
   until s1 = #13;
   for k := 1 to length(info) do info[k] := upcase(info[k]);
   if info <> dots[y][x].title then begin
{$I-}    if dots[y][x].tag = 'D' then rename(f,path + info);
    if dots[y][x].tag = 'T' then rename(f,path + info + '.TXT');
{$I+}
   if (IoResult = 0) and (DosError = 0) then begin
   dots[y][x].title := info;
   for k := 1 to 7 do begin
     dots[y+1][x+k-4] := desktop;
   end;
   for k := 1 to length(info) do begin
    dots[y+1][x+k-a-1] := dots[y][x]; dots[y+1][x+k-a-1].sym := ord(dots[y][x].title[k]);
    dots[y+1][x+k-a-1].BackCl :=desktop.ClrT; dots[y+1][x+k-a-1].ClrT := desktop.BackCl;
    dots[y+1][x+k-a-1].title := dots[y][x].title;
    gotoxy(x+k-a-1,y+1); write(dots[y][x].title[k]);
   end;
   GotoXY(x,y);textbackground(Cursor.BackCl); textcolor(Cursor.ClrT); write(chr(Dots[y][x].sym));
  end
   else begin
    info := dots[y][x].title;
    a := length(info) div 2;
    gotoxy(x-a,y+1); write(info);
    textcolor(4); textbackground(0); gotoxy(20,1); write('File with this name exists');
   end;
  end;
  end;

  {Up Directory}
  if (s1 = #8) then begin
   a := length(path)-1;
   while (path[a] <> '\') do dec(a);
   path := copy(path,1,a-1) + '\';
   if length(SysPath) > length(path) then path := SysPath;
   gotoxy(1,25); write('                                                ');
   gotoxy(1,25);
    if Length(Path) > 55 then write('...',copy(Path,length(Path)-51,52))
    else write(Path);
   ClearFiles;
   LoadDirectories(Path); LoadTextFiles(Path);
   draw;
  end;

  {Remove .TXT or Directory}
  if (s1 = chr(4)) and (info <> '\') then begin
   info := '';
   info := Dots[y][x].tag;
{$I-}   if info = 'T' then DeleteFile(SysPath+SysDir+Dots[y][x].title+'.TXT');
   if info = 'D' then RemoveDir(SysPath+SysDir+Dots[y][x].title);
{$I+}
    if (ioresult <> 0) then gotoxy(1,2);
    if info <> '0' then begin
    textcolor(desktop.ClrT); textbackground(desktop.BackCl);
    for j := 0 to 2 do
    for i := x-3 to x+3 do begin
     Dots[y+j-1][i] := desktop; gotoxy(i,y+j-1); write(chr(desktop.sym));
    end;
    Dots[y][x] := desktop;
    gotoxy(x,y); textcolor(cursor.ClrT); textbackground(cursor.BackCl); write(chr(dots[y][x].sym));
    end;
  end;

  {Create Folder(directory) or .TXT}
  if (s1 = chr(6)) or (s1 = chr(20)) then begin j := 1; i := 1;
   while dots[j*3][i*8-3].tag <> '0' do begin
    j := j + 1; if j >7 then begin j := 1; i := i+1 end;
    if i = 11 then
     begin textcolor(4); textbackground(0); gotoxy(20,1); write('Sorry, I can not create'); break; end;
   end;
  if i < 11 then begin
  gotoxy(x,y); textbackground(Dots[y,x].BackCl); textcolor(Dots[y][x].ClrT); write(chr(Dots[y][x].sym));
   x := i*8-3; y := j*3;
   if s1 = #6 then begin
    dots[y][x].sym := ord('d'); dots[y][x].tag := 'D';
    dots[y][x].ClrT := 7; dots[y][x].BackCl := 6;
   end else begin
    dots[y][x].sym := ord('t'); dots[y][x].tag := 'T';
    dots[y][x].ClrT := 7; dots[y][x].BackCl := 1;
   end;
   gotoxy(x,y); write(chr(dots[y][x].sym));
   info := ''; textcolor(desktop.backCl); textbackground(desktop.ClrT);
   repeat
    a := length(info) div 2;
    gotoxy(x-3,y+1); write('       '); gotoxy(x-a,y+1); write(info);
    readkeys;
    if (not (s1 in ['`'])) and (s1 in [' ',']'..'}','!'..'[']) and (length(info)<7) then info := info + upcase(s1)
    else if s1 = #8 then delete(info,length(info),1);
   until (s1 = #13) or (s1 = #27);

   if info = '' then info := '`';
   i := 0; j := 1;
   while (j < 11) and ((info <> dots[i*3][j*8-3].title) or (dots[i*3][j*8-3].tag <> dots[y][x].tag)) do
   begin
    inc(i); if i > 7 then begin i := 1; j := j + 1 end;
   end;
   if (info <> dots[i*3][j*8-3].title) or (dots[i*3][j*8-3].tag <> dots[y][x].tag) then
   begin
    if dots[y][x].tag = 'T' then
     begin assign(f,Path+info+'.txt'); rewrite(f); close(f); end
    else mkdir(path+info);
    dots[y][x].title := info;
    for k := 1 to length(info) do begin
     dots[y+1][x+k-a-1] := dots[y][x]; dots[y+1][x+k-a-1].sym := ord(upcase(dots[y][x].title[k]));
     dots[y+1][x+k-a-1].BackCl :=desktop.ClrT; dots[y+1][x+k-a-1].ClrT := desktop.BackCl;
     gotoxy(x+k-a-1,y+1); write(upcase(dots[y][x].title[k]));
    end;
   end else
         for i := y to y+1 do
          for j := x-3 to x+3 do begin
           dots[i][j] := desktop; Textbackground(dots[i][j].BackCl); TextColor(dots[i][j].ClrT);
           gotoxy(j,i); write(chr(Dots[i][j].sym));
          end;
     if (info = '`') or (s1 = #27) then
     begin
       if dots[y][x].tag = 'D' then rmdir(path+info);
       if dots[y][x].tag = 'T' then erase(f);

      for i := y to y+1 do
       for j := x-3 to x+3 do begin
        dots[i][j] := desktop; Textbackground(dots[i][j].BackCl); TextColor(dots[i][j].ClrT);
        gotoxy(j,i); write(chr(Dots[i][j].sym));
       end;
     end;
     GotoXY(x,y);textbackground(Cursor.BackCl); textcolor(Cursor.ClrT); write(chr(Dots[y][x].sym));
  end;
  end;
end;

begin
 load;
 x := 50; y := 12;

 Draw;
 repeat
  Move;
 until s2 = '>';
 save;
end.
