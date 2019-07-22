type struct=record
     sym: byte;
     ClrT: byte;
     BackCl: byte;
     tag: string[10];
end;

var f : file of struct;
    dot : struct;
begin
 assign(f,'C:\Option.txt');
{ rewrite(f);
 dot.sym := 219;
 dot.ClrT := 7;
 dot.BackCl := 0;
 dot.tag := '';
 write(f,dot);}
 reset(f);
 read(f,dot);
 writeln(dot.sym);
 writeln(dot.ClrT);
 writeln(dot.BackCl);
 writeln(dot.tag);
 readln;
 close(f);
end.