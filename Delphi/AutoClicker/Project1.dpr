program Project1;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'јвто ликер';
  Application.CreateForm(TForm1, Form1);
  form1.Left := Screen.Width div 2-Form1.Width; form1.Top := Screen.Height div 2-Form1.Height;
  Application.Run;
end.
