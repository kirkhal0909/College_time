type struct=record
     sym: byte;
     ClrT: byte;
     BackCl: byte;
     tag: string[5];
     title: string[25];
end;
var dot: array[1..80,1..24] of struct;
begin
     dot[5,21].sym := 155;
     writeln(dot[5,21].sym);
     readln;
end.