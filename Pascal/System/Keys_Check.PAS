uses crt;
var s1,s2 : char;
begin
 s1 := '1';
 repeat
  s1 := readkey; if s1 = #0 then s2 := readkey;
  writeln('s1 = ',s1,'   s2 = ',s2);
 until s1 = #27
end.