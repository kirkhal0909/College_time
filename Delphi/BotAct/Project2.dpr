program Project2;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  Options in 'Options.pas' {FormOptions},
  Mouse in 'Mouse.pas' {Form2};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TFormOptions, FormOptions);
  Application.CreateForm(TForm2, Form2);
  Application.Run;
end.
