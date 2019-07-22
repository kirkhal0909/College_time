//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include <iostream.h>
#include <fstream.h>
#include <sstream>

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
                //Убираем первое выделение ячейки в таблице
                TGridRect NoSelection;
               NoSelection.Left = -1;
                NoSelection.Top = -1;
                NoSelection.Right = -1;
                NoSelection.Bottom = -1;
               StringGrid1->Selection = NoSelection;

        //Делаем время подсказки 100 секунд, чтобы можно было смотреть полные надписи в таблице TStringGrid
        Application->HintHidePause = 1000*100;

        //Название файла
        const char*FilePath = "videoapp.csv"; //csv расширение Comma-Separated Values — значения, разделённые запятыми
        //Открываем файл для чтения
       ifstream va;
       va.open(FilePath, ifstream::in);
       //Если файл найден и его получилось открыть то
       if(va)
       {
               char line[1024];
               char tmpColumn[1024] = "";
               string tmpColumnStr;
               BOOL NextColumn = true;
               INT column = 0;
               INT row = 0;
               //Задаём 2 строки, чтобы верхняя строка не потеряла свой фон
               StringGrid1->RowCount = 2;

               //Читаем строчки файла и вносим информацию в столбцы TStringGrid
               while (va.getline(line,sizeof(line)))
               {
                  //Если строка не пустая, то добавляем информацию в ячейки
                  if(line[0])
                  {
                  //Добавляем новую строку в TStringGrid
                  StringGrid1->RowCount = StringGrid1->RowCount+1;
                  *tmpColumn = 0;
                  tmpColumnStr = "";
                  NextColumn = true;
                  column = 0;
                  //Разделяем строку и заносим информацию в ячейки
                  for(int i = 0;line[i];i++)
                  {
                        //Если найден символ " то символ ; не будет разделять строку
                        //иначе если найден символ ; то заносим часть строки в ячейку
                        if(line[i]=='"'){NextColumn = !NextColumn;}
                        else if((line[i]==';')&&(NextColumn))
                        {
                                strcpy(tmpColumn,tmpColumnStr.c_str());
                                StringGrid1->Cells[column][row] = tmpColumn;
                                *tmpColumn = 0;
                                tmpColumnStr = "";
                                column++;
                        } else tmpColumnStr+=line[i]; //sprintf(tmpColumn, "%c",line[i]);// strcat(tmpColumn,line[i]);
                          //ShowMessage(line[i]);
                  }
                  if(tmpColumnStr != "")
                  {
                          strcpy(tmpColumn,tmpColumnStr.c_str());
                          StringGrid1->Cells[column][row] = tmpColumn;
                  }
                  row++;
                  }
               }
               //Убираем начальные две строки
               StringGrid1->RowCount = StringGrid1->RowCount -2;
               //AnsiString info = Temp->c_str();
       }
       else {ShowMessage("Файл не найден");} //Если файл не найден, то выводим сообщение
}
//---------------------------------------------------------------------------




//Считаем число видеоаппаратуры одной компании
void __fastcall TForm1::Button1Click(TObject *Sender)
{
        char buffer[255];
        int count = 0;
        //Проходим по всем рядам
        for(int row = 1;row<StringGrid1->RowCount;row++)
        {
             //if(CharLower(StringGrid1->Cells[StringGrid1->ColCount-1][row].c_str())==CharLower(Edit1->Text.c_str()))
             //Проверяем, совпадает ли фирма в ряду, с фирмой в запросе
             if(StringGrid1->Cells[StringGrid1->ColCount-1][row]==Edit1->Text)
             {count++;}
        }
        //Очещаем TMemo
        Memo1->Clear();
        //Конвертируем число в строку
        ostringstream convert = count;
        itoa(count,buffer,10);
        //Выводим сообщение
        Memo1->Lines->Append("Видеоаппаратуры от фирмы "+Edit1->Text+" найдено - "+buffer+" шт.");
}
//---------------------------------------------------------------------------

  //Поменять и показать подсказку
void __fastcall TForm1::StringGrid1MouseMove(TObject *Sender,
      TShiftState Shift, int X, int Y)
{

        int r,c;
        //Получить номер ряда и столбца на котором стоит курсор мыши
        StringGrid1->MouseToCell(X,Y,c,r);
        if((c>=0)&&(r>=1) &&(StringGrid1->Hint != StringGrid1->Cells[c][r]))
        {
                //Текст подсказки присваивается тексту ячейки
                StringGrid1->Hint = StringGrid1->Cells[c][r];
                //Активируем подсказку
                Application->ActivateHint(Mouse->CursorPos);
        }
        else { StringGrid1->Hint = "";} //Если курсор наведён не на мышь, то убираем текст подсказки

}
//---------------------------------------------------------------------------

   //Вывести информацию по нажатию на ячейку
void __fastcall TForm1::StringGrid1MouseDown(TObject *Sender,
      TMouseButton Button, TShiftState Shift, int X, int Y)
{
        int r,c;
        //Получить номер ряда и столбца на котором стоит курсор мыши
        StringGrid1->MouseToCell(X,Y,c,r);
        if((c>=0)&&(r>=0))
        {
                AnsiString tmp = "";
                //Склеить информацию ряда
                for(int column = 0;column<StringGrid1->ColCount;column++)
                {
                        if(column!=0) tmp = tmp+"\n";
                        tmp = tmp + StringGrid1->Cells[column][r];
                }
                //Показать информацию
                ShowMessage(tmp);
        }        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::StringGrid1Exit(TObject *Sender)
{
                //Убираем выделение ячейки в таблице, после фокусировки
                //    на другом объекте
                TGridRect NoSelection;
               NoSelection.Left = -1;
                NoSelection.Top = -1;
                NoSelection.Right = -1;
                NoSelection.Bottom = -1;
               StringGrid1->Selection = NoSelection;        
}
//---------------------------------------------------------------------------

