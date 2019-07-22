uses crt;
var s1,s2: char;
oktava,nota,a,no: integer;
function N(var oktava,nota,no: integer): integer;
begin
{F=Round(440*Exp(Ln(2)*(No-(10-Nn)/12)));}
 N := Round(440*Exp(Ln(2)*((oktava+no)-(10-nota)/12)));
end;
begin
 no := -3;
 clrscr;
 writeln(' A   D F G   J K   ; " 5');
 writeln('Q Z X C V B N M < > / 1 3');
 writeln;
 writeln(' oktava   -');
 while (s1 <> #27) do begin
 repeat until keypressed;
 s1 := readkey; if s1 = #0 then s2 := readkey;
  if s2 = #77 then no := no + 1;
  if s2 = #75 then no := no - 1;
{Q} if (s1 = #81) or (s1 = #113) then begin oktava := 1; nota := 3; end else
{ A} if (s1 = #65) or (s1 = #97) then begin oktava := 1; nota := 4; end else
{Z} if (s1 = #90) or (s1 = #122) then begin oktava := 1; nota := 5; end else
{X} if (s1 = #88) or (s1 = #120) then begin oktava := 1; nota := 6; end else
{ D} if (s1 = #68) or (s1 = #100) then begin oktava := 1; nota := 7; end else
{C} if (s1 = #69) or (s1 = #99) then begin oktava := 1; nota := 8; end else
{ F} if (s1 = #72) or (s1 = #102) then begin oktava := 1; nota := 9; end else
{V} if (s1 = #86) or (s1 = #118) then begin oktava := 1; nota := 10; end else
{ G} if (s1 = #73) or (s1 = #103) then begin oktava := 1; nota := 11; end else
{B} if (s1 = #66) or (s1 = #98) then begin oktava := 1; nota := 12; end else
{N} if (s1 = #78) or (s1 = #110) then begin oktava := 2; nota := 1; end else
{ J} if (s1 = #74) or (s1 = #106) then begin oktava := 2; nota := 2; end else
{M} if (s1 = #77) or (s1 = #109) then begin oktava := 2; nota := 3; end else
{ K} if (s1 = #75) or (s1 = #107) then begin oktava := 2; nota := 4; end else
{<} if (s1 = #60) or (s1 = #44) then begin oktava := 2; nota := 5; end else
{>} if (s1 = #62) or (s1 = #46) then begin oktava := 2; nota := 6; end else
{ ;} if (s1 = #59) then begin oktava := 2; nota := 7; end else
{/} if (s1 = #47) then begin oktava := 2; nota := 8; end else
{ '} if (s1 = #39) then begin oktava := 2; nota := 9; end else
{1} if (s1 = #49) then begin oktava := 2; nota := 10; end else
{ 5} if (s1 = #53) then begin oktava := 2; nota := 11; end else
{3} if (s1 = #51) then begin oktava := 2; nota := 12; end else a := 0;
 s2 := 'o';
 if no < -5 then no := 4;
 if no > 4 then no := -5;
  gotoxy(1,3); writeln; writeln(' oktava  ',oktava+no+5:2);
 if a = 1 then sound(N(oktava,nota,no));
 delay(50);
 nosound;
 a := 1;
 end;
end.