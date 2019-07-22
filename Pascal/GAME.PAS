uses crt;
var x,y,a,clr,clr8,lvl,l,door,cheat: integer;
s1,s2:char;
begin
 clrscr;
gotoxy(1,4); writeln('           o__ __o           o           o          o    o__ __o__/_ ');
gotoxy(1,7); writeln('       o/                 o/   \o       \o/ v\  /v \o/   |           ');
gotoxy(1,10); writeln('         \         /   o/         \o    \o/        \o/  <o>          ');
gotoxy(1,6); writeln('         />       <\        / \         / \\o    o// \  < >          ');
gotoxy(1,8); writeln('      <|       _\__o__   <|__ __|>       |   <\/>   |    o__/_       ');
gotoxy(1,5); writeln('          /v     v\         <|>         <|\        /|>  <|    v      ');
gotoxy(1,9); writeln('       \\          |     /       \      / \        / \   |           ');
gotoxy(1,12); writeln('          <\__ __/>  />             <\  / \        / \  / \  _\o__/_ ');
gotoxy(1,11); writeln('          o       o   /v           v\    |          |    |           ');
gotoxy(1,20); writeln('       | |   | | |  __/\__ \__ \  | (_| | | | | |_| |  |   <  __/ |_| |');
gotoxy(1,16); writeln('        _____                                           _              ');
gotoxy(1,23); writeln('                                               |___/             |___/ ');
gotoxy(1,18); writeln('       | |__) | __ ___  ___ ___     __ _ _ __  _   _   | | _____ _   _ ');
gotoxy(1,21); writeln('       |_|   |_|  \___||___/___/   \__,_|_| |_|\__, |  |_|\_\___|\__, |');
gotoxy(1,17); writeln('       |  __ \                                         | |             ');
gotoxy(1,19); writeln('       |  ___/ `__/ _ \/ __/ __|   / _` | `_ \| | | |  | |/ / _ \ | | |');
gotoxy(1,22); writeln('                                                __/ |             __/ |');

gotoxy(54,21);
 repeat until keypressed; clr := 0;
 clrscr;
 a := 1;
gotoxy(1,1);  write('|==============================================================================|');
gotoxy(1,2);  write('|                                                                              |');
gotoxy(1,3);  write('| <<<<<<<<<       _______      ___      .___  ___.  _______          >>>>>>>>> |');
gotoxy(1,4);  write('| <<<<<<<<<      /  _____|    /   \     |   \/   | |   ____|         >>>>>>>>> |');
gotoxy(1,5);  write('| <<<<<<<<<     |  |  __     /  ^  \    |  \  /  | |  |__            >>>>>>>>> |');
gotoxy(1,6);  write('| <<<<<<<<<     |  | |_ |   /  /_\  \   |  |\/|  | |   __|           >>>>>>>>> |');
gotoxy(1,7);  write('| <<<<<<<<<     |  |__| |  /  _____  \  |  |  |  | |  |____          >>>>>>>>> |');
gotoxy(1,8);  write('| <<<<<<<<<      \______| /__/     \__\ |__|  |__| |_______|         >>>>>>>>> |');
gotoxy(1,9);  write('| <<<<<<<<<                                                          >>>>>>>>> |');
gotoxy(1,10); write('|                                                                              |');
gotoxy(1,11); write('|                             _                                                |');
gotoxy(1,12); write('|                       ____ | | __ _ _   _                                    |');
gotoxy(1,13); write('|                ***   |  _ \| |/ _` | | | |                                   |');
gotoxy(1,14); write('|                ***   | |_) | | (_| | |_| |                                   |');
gotoxy(1,15); write('|                ***   | .__/|_|\__,_|\__, |                                   |');
gotoxy(1,16); write('|                      |_|            |___/                                    |');
gotoxy(1,17); write('|                                   _ _                                        |');
gotoxy(1,18); write('|                        __ _ _   _(_) |_                                      |');
gotoxy(1,19); write('|                       / _` | | | | | __|                                     |');
gotoxy(1,20); write('|                      | (_| | |_| | | |_                                      |');
gotoxy(1,21); write('|                       \__, |\__,_|_|\__|                                     |');
gotoxy(1,22); write('|                         |_|                                                  |');
gotoxy(1,23); write('|                                                                              |');
gotoxy(1,24); write('|==============================================================================|'); gotoxy(60,8);
{^ Main menu: Play , quit}
  while a <> 5 do begin
  s1 := readkey; if clr = 0 then begin clr := 1; s1 := 'o'; end;
  if s1 = #0 then s2 :=readkey;
  if (s2 = #72) or (s2 = #80) or (s1 = #119) or (s1 = #87) or (s1 = #115) or (s1 = #83)
  then if a = 1 then a := 2 else a := 1; s2 := ']';
  if a = 1 then begin gotoxy(18,13); write('***'); gotoxy(18,14); write('***'); gotoxy(18,15); write('***');
  gotoxy(18,19); write('   '); gotoxy(18,20); write('   '); gotoxy(18,21); write('   '); gotoxy(60,8); end;
  if a = 2 then begin gotoxy(18,13); write('   '); gotoxy(18,14); write('   '); gotoxy(18,15); write('   ');
 gotoxy(18,19); write('***'); gotoxy(18,20); write('***'); gotoxy(18,21); write('***'); gotoxy(60,8); end;
  if s1 = #13 then begin clrscr;
  if a = 1 then a := 5; if a = 2 then begin repeat write('101010101001110101001010110010101010101010101');
  until keypressed; exit; end; end; end; 

 clrscr;
 lvl := 1; x := 2; y := 20; a := 5; l := lvl; door := 0; gotoxy(1,1); cheat := 0;
 write('|==============================================================================|');
 write('|******************************************************************************|');
 write('|******************************************************************************|');
 write('|******************************************************************************|');
for clr := 5 to 20 do write('|                                                                              |');
 write('|******************************************************************************|');
 write('|                                Game by KirKhal                               |');
 write('|******************************************************************************|');
 write('|==============================================================================|');
 gotoxy(37,22); write(' by '); gotoxy(35,22); write('me'); gotoxy(33,22); write('Ga');
 gotoxy(41,22); write('Kirill'); gotoxy(44,22); write('Khalevin');
 gotoxy(48,22); write('                               ');
 gotoxy(2,22);  write('                               ');
 while lvl > -100 do begin

  for clr := y downto y - 2 do if clr = y-2 then begin gotoxy(x+1,clr); write(' '); end
  else begin gotoxy(x,clr);  write('   '); end;                {Clear skin}

  if cheat <> 1 then begin clr := cheat;
  if (s1 = #50) and (cheat <> -1) then begin cheat := -1; s1 := 'o'; end;
  if (s1 = #50) and (cheat = -1) then cheat := -2;
  if (s1 = #56) and (cheat = -2) then cheat := 1; 
  if cheat = clr then cheat := 0;
  end else if (s1 = #48) then cheat := 0;

  if lvl = -1 then begin clrscr; x := 14; y := 22; a := 5;
gotoxy(x,y-18); write(' _____ _____ _____               _____ _____ ____  ');
gotoxy(x,y-16); write('  | | |     |   __|   ___|___   |   __| | | |  |  |');
gotoxy(x,y-15); write('  |_| |__|__|_____|  ((((())))  |_____|_|___|____/ ');
gotoxy(x,y-17); write('|_   _|  |  |   __|      |~~    |   __|   | |    \ ');
gotoxy(x,y-12); write('            +    I_I_I_I_I_I_I_I_I    +            ');
gotoxy(x,y-14); write('        .           (((((()))))         .          ');
gotoxy(x,y-5);  write('|-------|------|-------------------|------|-------|');
gotoxy(x,y-13); write('                  |-------------|                  ');
gotoxy(x,y-7);  write('|-------|------|-------------------|------|-------|');
gotoxy(x,y-11); write('           (()   |---------------|   (()           ');
gotoxy(x,y-1);  write('@@@@@@@@@@@@@@@|-----|_|_|_|_|-----|@@@@@@@@@@@@@@@');
gotoxy(x,y-10); write('          |---|  ||-| |-| |-| |-||  |---|          ');
gotoxy(x,y-3);  write('|  |_|  |  |_| | |_| |_.-o-._| |_| | |_|  |  |_|  |');
gotoxy(x,y-9);  write('_________|-----|_|---------------|_|-----|_________');
gotoxy(x,y);    write('              @@@@/=============\@@@@              ');
gotoxy(x,y-4);  write('|  |_|  |  |_| |::::: ------- :::::| |_|  |  |_|  |');
gotoxy(x,y-8);  write('I_I_I_I_I_I_I_I|I_I_I_I_I_I_I_I_I_I|I_I_I_I_I_I_I_|');
gotoxy(x,y-6);  write('||-| |-||  |-| ||-| |-| |-| |-| |-|| |-|  ||-| |-||');
gotoxy(x,y-2);  write('|-------|------| |_| | |/|\| | |_| |------|-------|');
gotoxy(2,24);  write('                              Game by KirKhal                               ');
gotoxy(39,24);
  repeat begin
  s1 := readkey;
  if s1 = #27 then exit; end; until lvl = -101;
  end;

  if lvl = 0 then begin
  for clr := 1 to 24 do begin gotoxy(1,clr);
  write('                                                                                '); end;
gotoxy(2,22);  write('                                Game by KirKhal                               ');

gotoxy(x,y-3);   write('           ________ _______ _______ _______ _______ _____  ');
gotoxy(x,y-2);   write('          |  |  |  |   _   |     __|_     _|    ___|     \ ');
gotoxy(x,y-1);   write('          |  |  |  |       |__     | |   | |    ___|  --  |');
gotoxy(x,y);     write('          |________|___|___|_______| |___| |_______|_____/ ');
gotoxy(41,22); 
{^ Wanted}
  repeat begin
  s1 := readkey; if s1 = #27 then exit; end; until lvl = -101;
  end;

  if (lvl = 8) and (lvl = l) then begin clr := 5;
   while lvl = 8 do begin
    for clr8 := y downto y - 2 do begin
     if (s2 = #80) or (s1 = #115) or (s1 = #83) then gotoxy(x,clr8-1);   {_}
     if (s2 = #72) or (s1 = #119) or (s1 = #87) then gotoxy(x,clr8+1); {^}
     if ((s2 = #75) or (s1 = #97) or (s1 = #65)) and (x < 39) then gotoxy(x+1,clr8);  {<}
     if ((s2 = #77) or (s1 = #100) or (s1 = #68)) and (x > 31) then gotoxy(x-1,clr8); {>}
     write('   '); end;
  if a = 5 then begin gotoxy(x+1,y-2); write('o');
                       gotoxy(x,y-1); write('/|\');
                         gotoxy(x,y); write('_|_'); end;
  if a = 2 then begin gotoxy(x+1,y-2); write('o');
                       gotoxy(x,y-1); write('[|\');
                         gotoxy(x,y); write(' |_'); end;
  if a = 1 then begin gotoxy(x+1,y-2); write('o');
                       gotoxy(x,y-1); write('/|]');
                         gotoxy(x,y); write('_|'); end;
  if cheat = 1 then begin gotoxy(x,y);   write(' o ');
                    gotoxy(x+1,y-2); write('|');
                    gotoxy(x,y-1); write('\|/'); end;
 gotoxy(2,1); write('=============================================================================');gotoxy(40,22);
   s2 := 'o'; s1 := readkey; if s1 = #0 then s2 := readkey; if (s1 = #27) and (clr < 25) then exit;
  if (s2 = #77) or (s1 = #100) or (s1 = #68) then begin if a = 2 then x := x + 1;
   if x = 78 then lvl := lvl + 1; if a = 5 then a := 2;
   if a = 1 then a := 5; if (x > 39) and (y < 7) then x := 39;
   if (x > 39) and ((door = 0) or (door = 1)) then begin door := 2;
   for clr := 2 to 4 do begin gotoxy(27,clr); write('||======||=======|'); end; end; end;   {  >  }
  if (s2 = #75) or (s1 = #97) or (s1 = #65) then begin if a = 1 then x := x - 1; if a = 5 then a := 1;
   if a = 2 then a := 5; if x < 2 then x := 2; if (x < 31) and (y < 7) then x := 31;
    if (x < 31) and ((door = 0) or (door = 1)) then begin door := 2;
   for clr := 2 to 4 do begin gotoxy(27,clr); write('||======||=======|'); end; end; end;  {  <  }
  if (s2 = #72) or (s1 = #119) or (s1 = #87) then begin y := y - 1; if y = 4 then lvl := lvl - 1;      { ^ }
   if (door > 1) and (y < 7) then y := 7   end;
  if (s2 = #80) or (s1 = #115) or (s1 = #83) then begin y := y + 1; if y > 20 then y := 20;    { _ }
    if (y > 7) and ((door = 0) or (door = 1)) then begin door := 2;
    for clr := 2 to 4 do begin gotoxy(27,clr); write('||======||=======|'); end; end; end;
   if door > 1 then repeat begin clr := clr + 1; for l := 5 to 20 do begin gotoxy(clr,l); write('  ');
   gotoxy(41,22); write('KirKhal'); gotoxy(40,22);
    gotoxy(80-clr,l); write('  '); end; gotoxy(clr,9); write('='); gotoxy(clr,16); write('=');
    gotoxy(81-clr,9); write('='); gotoxy(81-clr,16); write('=');
    for l := 5 to 20 do begin gotoxy(clr+1,l); write('|>'); gotoxy(79-clr,l); write('<|'); end;
    gotoxy(41,22); write('KirKhal'); gotoxy(40,22);
    if clr < 40 then delay(20);
    if (clr+1 >= x) or (79-clr <= x) or (clr > 37) then lvl := 0;
   end;
   until keypressed;
   end;
  end;

  if (lvl = 7) and (lvl = l) then begin
  if (s2 = #77) or (s1 = #100) or (s1 = #68) then begin if a = 2 then x := x + 1;
   if a = 5 then a := 2;
   if a = 1 then a := 5; if x > 39 then x := 39; if x = 18 then lvl := -1 end;   {  >  }
  if (s2 = #75) or (s1 = #97) or (s1 = #65) then begin if a = 1 then x := x - 1; if a = 5 then a := 1;
   if a = 2 then a := 5; if x = 30 then x := 31; if x = 2 then lvl := 3; end;  {  <  }
  if (s2 = #72) or (s1 = #119) or (s1 = #87) then begin y := y - 1; if y = 4 then lvl := 5;      { ^ }
   if x < 24 then if y < 16 then y := 16; if y = 4 then lvl := 5; end;
  if (s2 = #80) or (s1 = #115) or (s1 = #83) then begin y := y + 1; if y > 20 then y := 20;    { _ }
   if x < 24 then if y > 16 then y := 16; if y = 20 then lvl := lvl + 1; end;
  end;

  if (lvl = 6) and (lvl = l) then begin
  if (s2 = #77) or (s1 = #100) or (s1 = #68) then begin if a = 2 then x := x + 1;
   if a = 5 then a := 2; if a = 1 then a := 5; if x > 36 then x := 36 end;    {  >  }
  if (s2 = #75) or (s1 = #97) or (s1 = #65) then begin if a = 1 then x := x - 1; if a = 5 then a := 1;
   if a = 2 then a := 5; if x = 2 then lvl := lvl - 1; end; {  <  }
  if ((s1 = #101) or (s1 = #69) or (s1 = #13)) and (x = 36) and (a = 2) and (door = 0) then door := door + 1;
  if door mod 2 = 1 then begin gotoxy(39,7); write(' '); end; end;

  if (lvl = 5) and (lvl = l) then begin
  if (s2 = #77) or (s1 = #100) or (s1 = #68) then begin if a = 2 then x := x + 1;
   if x = 77 then lvl := lvl + 1; if a = 5 then a := 2;
   if a = 1 then a := 5; if (y > 8) and (x > 39) then x := 39;
    end;    {  >  }
  if (s2 = #75) or (s1 = #97) or (s1 = #65) then begin if a = 1 then x := x - 1; if a = 5 then a := 1;
   if a = 2 then a := 5;if (x < 31) and (y > 14) then x := 31; if (x < 31) and (y < 14) then x := 31;
    if x = 2 then lvl := lvl - 1; end;  {  <  }
  if (s2 = #72) or (s1 = #119) or (s1 = #87) then begin y := y - 1;
   if (x < 31) and  (y < 14) then y := 14; if y < 8 then y := 8;       { ^ }
  end;
  if (s2 = #80) or (s1 = #115) or (s1 = #83) then begin y := y + 1;
   if (x < 31) and  (y > 14) then y := 14; if (x > 39) and (y > 8) then y := 8;
   if y = 20 then lvl := 7;    { _ }
  end;
  end;

  if (lvl = 4) and (lvl = l) then begin
  if (s2 = #77) or (s1 = #100) or (s1 = #68) then begin if a = 2 then x := x + 1;
   if x = 78 then lvl := lvl + 1; if a = 5 then a := 2;
   if a = 1 then a := 5; if x > 77 then x := 77; if (a = 5) and (x >77) then x := 77;
   if (y > 14) and (x > 39) then x := 39; end;   {  >  }
  if (s2 = #75) or (s1 = #97) or (s1 = #65) then begin if a = 1 then x := x - 1; if a = 5 then a := 1;
   if a = 2 then a := 5; if x < 31 then x := 31; end;  {  <  }
  if (s2 = #72) or (s1 = #119) or (s1 = #87) then begin y := y - 1; if y < 14 then y := 14;      { ^ }
  end;
  if (s2 = #80) or (s1 = #115) or (s1 = #83) then begin y := y + 1;
   if (x > 39) and (y > 14) then y := 14; if y = 20 then lvl := lvl - 1;   { _ }
  end;
  end;

  if (lvl = 3) and (lvl = l) then begin
  if (s2 = #77) or (s1 = #100) or (s1 = #68) then begin if a = 2 then x := x + 1;
   if x = 78 then lvl := 7; if a = 5 then a := 2;
   if a = 1 then a := 5; if x > 77 then x := 77; end;
   if (x > 39) and (y < 16) then x := 39;   {  >  }
   if door mod 2 = 1 then begin
   gotoxy(50,16); write(' '); gotoxy(50,15); write(' '); gotoxy(50,14); write(' ');
   if x = 51 then door := 0 end else begin if x = 48 then x := 47; if x = 51 then x := 52;
   gotoxy(50,16); write('|'); gotoxy(50,15); write('|'); gotoxy(50,14); write('|'); end;
  if (s2 = #75) or (s1 = #97) or (s1 = #65) then begin if a = 1 then x := x - 1; if a = 5 then a := 1;
   if a = 2 then a := 5; if x < 2 then x := 2; if x = 2 then lvl := lvl - 1; end;
   if (x < 31) and (y < 16) then x := 31;
  if (s2 = #72) or (s1 = #119) or (s1 = #87) then begin y := y - 1;
   if (x < 31) or (x > 39) then y := y + 1; if y = 4 then lvl := lvl + 1;      { ^ }
  end;
  if (s2 = #80) or (s1 = #115) or (s1 = #83) then begin y := y + 1; if y > 20 then y := 20;
   if y > 16 then y := 16;    { _ }
  end;
  end;

  if (lvl = 2) and (lvl = l) then begin
  if (s2 = #77) or (s1 = #100) or (s1 = #68) then begin if a = 2 then x := x + 1;
   if x = 78 then lvl := lvl + 1; if a = 5 then a := 2;
   if a = 1 then a := 5; if x > 77 then x := 77;  end;   {  >  }
  if (s2 = #75) or (s1 = #97) or (s1 = #65) then begin if a = 1 then x := x - 1; if a = 5 then a := 1;
   if a = 2 then a := 5; if x < 2 then x := 2; if x = 2 then lvl := lvl - 1; end;  {  <  }
  if (s2 = #72) or (s1 = #119) or (s1 = #87) then begin y := y - 1; if y < 7 then y := 7;      { ^ }
  end;
  if (s2 = #80) or (s1 = #115) or (s1 = #83) then begin y := y + 1; if y > 20 then y := 20;    { _ }
  end;
  if ((x > 62) and (y = 17)) or ((x > 41) and (y = 18)) or ((x > 27) and (y = 19))
   or ((x > 11) and (y = 20)) then y := y - 1;
  if ((x < 14) and (y = 10)) or ((x < 31) and (y = 9)) or ((x < 45) and (y = 8))
   or ((x < 66) and (y = 7))then y := y + 1;
  end;

  if (lvl = 1) and (lvl = l) then begin
  if (s2 = #77) or (s1 = #100) or (s1 = #68) then begin if a = 2 then x := x + 1;
   if x = 78 then lvl := lvl + 1; if a = 5 then a := 2;
   if a = 1 then a := 5; if x > 77 then x := 77;  end;   {  >  }
  if (s2 = #75) or (s1 = #97) or (s1 = #65) then begin if a = 1 then x := x - 1; if a = 5 then a := 1;
   if a = 2 then a := 5; if x < 2 then x := 2; end;  {  <  }
  if (s2 = #72) or (s1 = #119) or (s1 = #87) then begin y := y - 1; if y < 7 then y := 7; { ^ }
  end;
  if (s2 = #80) or (s1 = #115) or (s1 = #83) then begin y := y + 1; if y > 20 then y := 20;    { _ }
  end;
  end;
if lvl <> 0 then begin
  if a = 5 then begin gotoxy(x+1,y-2); write('o');
                       gotoxy(x,y-1); write('/|\');
                         gotoxy(x,y); write('_|_'); end;
  if a = 2 then begin gotoxy(x+1,y-2); write('o');
                       gotoxy(x,y-1); write('[|\');                  { Skins }
                         gotoxy(x,y); write(' |_'); end;
  if a = 1 then begin gotoxy(x+1,y-2); write('o');
                       gotoxy(x,y-1); write('/|]');
                         gotoxy(x,y); write('_| '); end;
  if cheat = 1 then begin gotoxy(x,y);   write(' o ');
                    gotoxy(x+1,y-2); write('|');
                    gotoxy(x,y-1); write('\|/'); end;
                end;gotoxy(40,22);

 if l = lvl then begin
  s2 := 'o';
  s1 := readkey; if s1 = #0 then s2 := readkey;
  if s1 = #27 then exit;
 end else begin   for clr := 5 to 20 do begin gotoxy(2,clr);
  write('                                                                              '); end;
 gotoxy(2,2); write('******************************************************************************');
 gotoxy(2,3); write('******************************************************************************');
 gotoxy(2,4); write('******************************************************************************');
   if lvl = 1 then x := 75;
   if lvl = 2 then begin
gotoxy(2,5);  write('***************************************************************/              ');
gotoxy(2,6);  write('******************************************/                                   ');
gotoxy(2,7);  write('****************************/                                                 ');
gotoxy(2,8); write('***********/                                                                  ');
gotoxy(2,17); write('                                                               /**************');
gotoxy(2,18); write('                                          /***********************************');
gotoxy(2,19); write('                            /*************************************************');
gotoxy(2,20); write('            /*****************************************************************'); end;
  if lvl = 3 then begin for clr := 2 to 11 do begin gotoxy(2,clr);
              write('*****************************           **************************************');end;
gotoxy(2,12); write(' ****************************           ********-*****************************');
gotoxy(2,13); write('  ***************************           ********|*****************************');
gotoxy(2,14); write('                                                |                             ');
gotoxy(2,15); write('                                                |                             ');
gotoxy(2,16); write('                                                |                             ');
gotoxy(2,17); write('************************************************|*****************************');
gotoxy(2,18); write('************************************************-*****************************');
gotoxy(2,19); write('******************************************************************************');
gotoxy(2,20); write('******************************************************************************'); end;
  if lvl = 4 then begin for clr := 2 to 11 do begin gotoxy(2,clr);
              write('******************************************************************************');end;
gotoxy(2,12); write('*****************************                                                 ');
gotoxy(2,13); write('*****************************                                                 ');
gotoxy(2,14); write('*****************************                                                 ');
for clr := 15 to 20 do begin gotoxy(2,clr);
              write('*****************************           **************************************');end;end;
  if lvl = 5 then begin
gotoxy(2,5);  write('******************************************************************************');
gotoxy(2,6);  write('*****************************                                                 ');
gotoxy(2,7);  write('*****************************                                                 ');
gotoxy(2,8);  write('*****************************                                                 ');
for clr := 9 to 20 do begin gotoxy(2,clr); if ((clr > 8) and (clr < 12)) or (clr > 14) then
              write('*****************************           **************************************');end;
gotoxy(2,12); write('                                        **************************************');
gotoxy(2,13); write('                                        **************************************');
gotoxy(2,14); write('                                        **************************************');end;
  if lvl = 6 then begin x := 2; y := 8; for clr := 5 to 20 do begin if (clr < 6) or(clr > 8) then gotoxy(2,clr);
              write('******************************************************************************');end;
for clr := 6 to 8 do begin gotoxy(1,clr); write('|'); end;
for clr := 5 to 7 do begin gotoxy(80,clr); write('|'); end;
gotoxy(2,6);  write('                                                           *******************');
gotoxy(2,7);  write('                                     # /|                  *******************');
gotoxy(2,8);  write('                                       ||                  *******************'); end;
  if lvl = 7 then begin for clr := 2 to 20 do begin if (clr < 14) or (clr > 16) then gotoxy(2,clr);
              write('*****************************           **************************************');end;
for clr := 14 to 16 do begin gotoxy(1,clr); write('|'); end; 
for clr := 13 to 15 do begin gotoxy(80,clr); write('|'); end;
gotoxy(2,14); write('                  ???|*******           **************************************');
gotoxy(2,15); write('                  ???|*******           **************************************');
gotoxy(2,16); write('                  ???|*******           **************************************');end;
gotoxy(33,22); write('Game by KirKhal');
  if lvl = 8 then begin y := 4; door := 0;
for clr := 2 to 4 do begin
gotoxy(2,clr); write('*************************||=|           |=||**********************************');end;
for clr := 5 to 20 do begin gotoxy(2,clr); if (clr <> 9) or (clr <> 16) then
 write('    |>                                                                  <|    '); end;
gotoxy(2,9);  write('||==|>                                                                  <|==||');
gotoxy(2,16); write('||==|>                                                                  <|==||');end;
 if lvl = 0 then begin x := 6; y := 13;  end;
 if (lvl = 2) and (l = 1) then begin x := 2; if y < 11 then y := 11; end;
 if (lvl = 2) and (l = 3) then begin x := 77; y := 16; end;
 if (lvl = 3) and (l = 2) then begin y := 16; x := 2; end;
 if (lvl = 3) and (l = 4) then begin y := 4; end;
 if (lvl = 3) and (l = 7) then x := 77;
 if (lvl = 4) and (l = 3) then y := 20;
 if (lvl = 4) and (l = 5) then x := 77;
 if (lvl = 5) and (l = 4) then begin x := 2; y := 14; end;
 if (lvl = 5) and (l = 6) then x := 77;
 if (lvl = 5) and (l = 7) then y := 20;
 if (lvl = 7) and (l = 3) then x := 2;
 if (lvl = 7) and (l = 5) then y := 4;
 if (lvl = 7) and (l = 8) then y := 20;
 l := lvl;
  end;
 end;
end.