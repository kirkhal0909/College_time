uses crt;
var i : integer;

procedure paint;
var f : file of char;
    c : char;
begin
	clrscr;
	assign(f,'C:\Welcome.txt');
	reset(f);
	textcolor(random(10)+1);
	While not EOF(f) do begin
		read(f,c);
		write(c);
	end;
	close(f);
end;
begin
  paint;
  randomize;
  for i := 1 to 18 do begin
      sound(i*50);
      delay(50);
  end;
  paint;
  delay(250);
  for i := 1 to 6 do begin
      sound (18*50-(i mod 2)*50);
      delay(120);
  end;
  delay(400);
  nosound;
  sound(27500);
  delay(1000);
end.