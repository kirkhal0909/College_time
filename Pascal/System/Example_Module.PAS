unit Example_Module;
interface
uses crt;
 procedure Welcome;
implementation
 procedure Welcome;
 begin
  writeln('hello');
  readln;
 end;

begin
	textbackground(5);
	Welcome;
end.