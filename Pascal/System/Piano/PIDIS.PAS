uses crt;
var i,j,p: integer;
    s1,s2: char;
begin
 clrscr;
 for i := 1 to 10 do begin writeln;
  for j := 1 to 69 do
  begin
   if i = 1 then write('Ü');
   if (i > 1) and (i < 10) then
    if (j < 3) or (j > 67) then write('Û')
    else write('²');
   if i = 10 then write('ß');
  end;
 end;
 repeat
 repeat
 textcolor(7);
 for i := 3 to 6 do
  for j := 1 to 13 do begin
   if ((1+j)mod 7 <> 3) and ((1+j)mod 7 <> 0) then begin
    gotoxy(j*5+2,i); write('°°');
   end;
  end;
 until keypressed;
  s1 := readkey;
  if s1 = 'a' then for i := 3 to 6 do begin
   gotoxy(7,i); textcolor(1); write('°°');
  end;
  p := 0;
  repeat
   delay(20); p := p + 1;
  until (keypressed) or (p = 50);
 until s1 = #27;
end.