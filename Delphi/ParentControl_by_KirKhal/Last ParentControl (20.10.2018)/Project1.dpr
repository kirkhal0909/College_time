program Project1;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  PassEnter in 'PassEnter.pas' {Form2},
  Locker in 'Locker.pas' {Form3};

{$R *.res}

begin
  Application.Initialize;
  if ParamStr(1) <> '-blockStart' then
  begin
    Application.CreateForm(TForm1, Form1);
    Application.CreateForm(TForm2, Form2);
  end else
    Application.CreateForm(TForm3, Form3);
  Application.Run;
end.
