using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Reversi
{
    class Reversi
    {
        //Создаём свои типы данных: тип игры(игрок против ...)
        //и вид поля(пустое, белая фишка,чёрная фишка, можно ли ходить по правилам игры)
        public enum TypeGame { PlayerVsPlayer, PlayerVsComputer };
        private TypeGame typeGame = TypeGame.PlayerVsComputer;
        public enum typeField { Empty, CanGo, CanGoComputer, Black, White };

        //Создаём новые массивы для проверки состояния поля и изменения изображения
        private typeField[,] fields;                
        private System.Windows.Forms.PictureBox[,] pictureFields;
        //Переменная, размер поля
        private byte size;
        //Класс - Игрок
        private class Player
        {
            //Создаём тип классу - Игрок, цвет и тип игрока(человек, компьютер)
            public enum ColorPlayer { Black, White };
            public enum TypePlayer { Human, Computer };
            private TypePlayer typePlayer;
            private ColorPlayer colorPlayer;
            //Функция инициализации объекта - Игрок.
            public Player(TypePlayer typePlayer = TypePlayer.Human, bool doRandColor = false, ColorPlayer colorPlayer = ColorPlayer.Black)
            {
                if (doRandColor)
                {
                    Array values = Enum.GetValues(typeof(ColorPlayer));
                    Random random = new Random();
                    colorPlayer = (ColorPlayer)values.GetValue(random.Next(values.Length));                    
                }
                this.colorPlayer = colorPlayer;
                this.typePlayer = typePlayer;
            }
            //Функция получения цвета игрока
            public ColorPlayer getColor()
            {
                return colorPlayer;
            }
            //Функция получения типа игрока
            public TypePlayer getType()
            {
                return typePlayer;
            }
            //Конец класса - Игрок
        } 

        //Задаём два объекта(двух игроков)
        Player player1, player2;
        //Задаём переменную, чей следующий ход
        Player.ColorPlayer nextPlayer = Player.ColorPlayer.Black;
        //Запоминаем первый размер формы
        //Обращение к форме идёт из класса, так как в Program.cs,
        //  объект класса Form1 вынесен из функции и сделан статическим-static(доступным в других классах).
        int defaultWidth = Program.mainForm.Width;
        int defaultHeight = Program.mainForm.Height;

        //Инициализация объекта - Reversi
        public Reversi(byte gameSize = 8,TypeGame typeGame = TypeGame.PlayerVsPlayer)
        {   //Заносим информацию, какой размер и кто против кого играет(игрок, компьютер)
            this.size = gameSize;
            this.typeGame = typeGame;
            //Делаем минимальный размер поля 4
            if (gameSize < 4)
                gameSize = 4;
            //Инициализируем массив с полями
            fields = new typeField[gameSize, gameSize];
            /*needUpdateFields = new bool[gameSize, gameSize];
            for (byte row = 0; row < gameSize; row++)
                for (byte col = 0; col < gameSize; col++)
                {
                    fields[row, col] = typeField.Empty;
                    needUpdateFields[row, col] = true;
                }*/
            //Находим центральные поля
            byte centerField = (byte)(gameSize / 2 - 1);            
            //Раставляем начальные фишки
            fields[centerField, centerField] = typeField.White;
            fields[centerField+1, centerField+1] = typeField.White;
            fields[centerField + 1, centerField] = typeField.Black;
            fields[centerField, centerField + 1] = typeField.Black;
            //Инициализируем объекты
            if (typeGame == TypeGame.PlayerVsComputer)
            {
                player1 = new Player(Player.TypePlayer.Human, false, Player.ColorPlayer.Black);
                player2 = new Player(Player.TypePlayer.Computer,false,Player.ColorPlayer.White);
            } else if (typeGame == TypeGame.PlayerVsPlayer)
            {
                player1 = new Player(Player.TypePlayer.Human, false, Player.ColorPlayer.Black);
                player2 = new Player(Player.TypePlayer.Human, false, Player.ColorPlayer.White);
            }
            //Рисуем поле
            initPictures();
            //Прячем панель с кнопками
            Program.mainForm.hidePanel(true);
            //Находим первые шаги пользователю(куда он может походить)
            FindNextSteps();            
        }

        private byte stepBad = 0;
        private const byte stepBadEndGame = 2;
        //Функция поиска ходов
        private void FindNextSteps()
        {            
            //Заносим основую информацию
            typeField fieldNeed = typeField.White;
            typeField fieldAfter = typeField.Black;            
            if(nextPlayer == Player.ColorPlayer.White)
            {
                fieldNeed = typeField.Black;
                fieldAfter = typeField.White;
            }            
            Player.TypePlayer player = Player.TypePlayer.Computer;
            if ((player1.getType() == Player.TypePlayer.Human && player1.getColor().ToString() == nextPlayer.ToString())
                || (player2.getType() == Player.TypePlayer.Human && player2.getColor().ToString() == nextPlayer.ToString()))
                    player = Player.TypePlayer.Human;
            //Очищаем поля, от типа поля CanGo и CanGoComputer
            for(int y=0;y<size;y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if(fields[y,x]==typeField.CanGo || fields[y, x] == typeField.CanGoComputer)
                    {
                        fields[y, x] = typeField.Empty;
                        pictureFields[y, x].Image = ResourcesFields.field;
                    }
                }
            }

            bool playerCanGo = false;
            char[] act1 = { '=','=', '=', '+', '+', '+', '-', '-', '-' };
            char[] act2 = { '=', '+', '-', '=', '+', '-', '=', '+', '-' };
            //Console.WriteLine("\n\nNew\n\n");
            //Ищем по всему полю, куда следующий пользователь может ходить
            for (int y = -1; y < size+1; y++)
            {
                for (int x = -1; x < size+1; x++)
                {                  
                    //Возле выбранной точки, проходим вокруг  
                    for(int act=0;act<act1.Length;act++)
                    {                                                
                        int tmpX = doAct(x,act1[act]);
                        int tmpY = doAct(y,act2[act]);                        
                        if (tmpX >= 0 && tmpX < size && tmpY >= 0 && tmpY < size)
                        {   //Ищем пустую ячейку
                            if (fields[tmpY, tmpX] == typeField.Empty)
                            {                                
                                tmpX = doAct(tmpX, act1[act]);
                                tmpY = doAct(tmpY, act2[act]);                                
                                bool foundedStart = false;
                                bool foundedStop = false;

                                while (tmpX >= 0 && tmpX < size && tmpY >= 0 && tmpY < size)
                                {                                                                        
                                    if (!foundedStart)
                                    {
                                        if (fields[tmpY, tmpX] == fieldNeed)    //Если следующая ячейка- фишка соперника
                                        {
                                            foundedStart = true;    //То обновляем статус                                           
                                        }
                                        else { tmpX = size + 1; }
                                    } else if (!foundedStop)    //Если была найдена фишка соперника
                                    {
                                        if (fields[tmpY, tmpX] == fieldAfter)   //После чего была найдена своя фишка
                                        {
                                            foundedStop = true;
                                            //То обновляем статус по найденному полю для следующего хода
                                            tmpX = doAct(x, act1[act]);
                                            tmpY = doAct(y, act2[act]);
                                            playerCanGo = true;
                                            if (player == Player.TypePlayer.Human)
                                            {
                                                fields[tmpY, tmpX] = typeField.CanGo;
                                                pictureFields[tmpY, tmpX].Image = ResourcesFields.GoField;
                                            }
                                            else
                                            {
                                                fields[tmpY, tmpX] = typeField.CanGoComputer;
                                            }
                                            tmpX = size + 1;
                                        }
                                        //Если после пустого поля была своя фишка или пустое поле, то здесь ходить нельзя
                                        else if (fields[tmpY, tmpX] != fieldNeed) { tmpX = size + 1; }
                                    }
                                    //Переходим к следующей ячейке
                                    tmpX = doAct(tmpX, act1[act]);
                                    tmpY = doAct(tmpY, act2[act]);
                                }
                            }
                        }
                    }
                }
            }   
            if(playerCanGo)
            {
                stepBad = 0;
            }
            else //Если не было найденно ни одного хода и игрок не может ходить
            {
                //Если это произашло два раза подряд, то завершаем игру
                stepBad++;
                if(stepBad==stepBadEndGame)
                {
                    endGame();
                }
                else
                {   //Если же один раз, то передаём ход
                    if (nextPlayer == Player.ColorPlayer.White)
                        nextPlayer = Player.ColorPlayer.Black;
                    else if (nextPlayer == Player.ColorPlayer.Black)
                        nextPlayer = Player.ColorPlayer.White;
                    FindNextSteps();
                    return;
                }
            }            
        }
        //Функция завершения игры
        private void endGame()
        {
            //Подсчитываем количество фишек
            int whites = 0,blacks = 0;
            for(byte y=0;y<size;y++)
            {
                for (byte x = 0; x < size; x++)
                {
                    if (fields[y, x] == typeField.White)
                        whites++;
                    else if (fields[y, x] == typeField.Black)
                        blacks++;
                }
            }
            //Создаём сообщение
            String msg = "Игра окончена!\nЧёрных фишек - " + blacks.ToString() + "\nБелых фишек - " + whites.ToString()+"\n";
            if (blacks == whites) msg = msg + " Ничья!";
            else if (blacks > whites) msg = msg + "Победил игрок с чёрными фишками!";
            else if (blacks < whites) msg = msg + "Победил игрок с белыми фишками!";
            //Выводим сообщение
            System.Windows.Forms.MessageBox.Show(msg);
            //Уничтожаем картинки
            destroyPictures();
            //Возвращаем начальный размер формы и возвращаем панель
            Program.mainForm.MinimumSize = new Size(defaultWidth, defaultHeight);
            Program.mainForm.MaximumSize = new Size(defaultWidth, defaultHeight);
            Program.mainForm.hidePanel(false);
            //Делаем форму по центру
            Program.mainForm.Location = new Point((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Program.mainForm.Width) / 2,
                          (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - Program.mainForm.Height) / 2);
        }
        //Функция выполнения действия, задавая число и знак действия в типе char
        private int doAct(int num,char act)
        {
            switch(act)
            {
                case '=':
                    return num;
                    break;
                case '+':
                    return num + 1;
                    break;
                case '-':
                    return num - 1;
                    break;
            }
            return 0;        
        }

        //Размер ячейки
        private int fieldSize = 64;
        //Размер фишки
        private int figureSize = 37;
        //Свободное место между ячейками
        private int fieldSpaces = 1;
        //Константы, которые позволяют задать нормальный размер
        private const int fixedWidth = 16;
        private const int fixedHeight = 39;

        private char spliter = ':';
        //Функция создания объектов с картинками
        private void initPictures()
        {            
            //Инициализируем массив PictureBox
            pictureFields = new System.Windows.Forms.PictureBox[size, size];    
            //Проходим по массиву        
            for (byte y=0;y<size;y++)
            {
                for(byte x=0;x<size;x++)
                {
                    //Инициализируем элемент массива(объект PictureBox)
                    pictureFields[y, x] = new System.Windows.Forms.PictureBox();
                    //Задаём имя в виде координат, что бы можно было определитькуда нажал пользователь
                    pictureFields[y, x].Name = y.ToString()+spliter+x.ToString();
                    //Задаём расположение
                    pictureFields[y, x].Left = fieldSpaces+fieldSize*x+fieldSpaces*x;
                    pictureFields[y, x].Top = fieldSpaces + fieldSize * y + fieldSpaces * y;
                    //Указываем размеры
                    pictureFields[y, x].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pictureFields[y, x].Width = fieldSize;
                    pictureFields[y, x].Height = fieldSize;
                    //Ставим картинку из Resources при помощи созданного файла ResourcesFields.resx
                    if(fields[y,x]==typeField.White)
                    {
                        pictureFields[y, x].Image = ResourcesFields.fieldWhite;                        
                    } else if (fields[y, x] == typeField.Black)
                    {
                        pictureFields[y, x].Image = ResourcesFields.fieldBlack;
                    }
                    else
                    {
                        pictureFields[y, x].Image = ResourcesFields.field;
                    }                    
                    //Задаём события объекту, благодаря которым, при наведении и нажатии пользователь может ходить
                    pictureFields[y, x].Click += pictureOnClick;
                    pictureFields[y, x].MouseEnter += pictureMouseEnter;
                    pictureFields[y, x].MouseLeave += pictureMouseLeave;
                    pictureFields[y, x].MouseDown += pictureMouseDown;
                    //Делаем родителем форму или же заносим картинку на форму 
                    Program.mainForm.Controls.Add(pictureFields[y, x]);
                }
                /*pictureLines[y,0]= new System.Windows.Forms.PictureBox();
                pictureLines[y, 0].Left = fieldSpaces + fieldSize * x + fieldSpaces * x;
                pictureLines[y, 0].Top = fieldSpaces + fieldSize * y + fieldSpaces * y;*/
            }            
            //Меняем цвет формы, что позволяет изменить цвет полосок
            Program.mainForm.BackColor = System.Drawing.Color.FromArgb(5,45,5);
            //Меняем размер формы
            Program.mainForm.MinimumSize = new System.Drawing.Size(pictureFields[size-1, size-1].Left+ fieldSize+fieldSpaces+fixedWidth, pictureFields[size - 1, size - 1].Top + fieldSize + fieldSpaces+fixedHeight);
            Program.mainForm.MaximumSize = new System.Drawing.Size(pictureFields[size - 1, size - 1].Left + fieldSize + fieldSpaces + fixedWidth, pictureFields[size - 1, size - 1].Top + fieldSize + fieldSpaces + fixedHeight);
            //Направляем форму на центр
            Program.mainForm.Location = new Point((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - Program.mainForm.Width) / 2,
                          (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - Program.mainForm.Height) / 2);
        }
        //Функция уничтожения картинок
        private void destroyPictures()
        {   //Для каждой картинки используем метод .Dispose()
            for (byte y = 0; y < size; y++)
            {
                for (byte x = 0; x < size; x++)
                {
                    if(pictureFields[y, x]!=null) pictureFields[y, x].Dispose();
                }
            }
            //Возвращаем стандартный цвет форме
            Program.mainForm.BackColor = System.Drawing.SystemColors.Control;
        }
       
        //Событие входа мышки в ячейку
        private void pictureMouseEnter(object sender, System.EventArgs e)
        {
            //Получаем координаты ячейки, на которую навели мышку
            Point coords = getCoordsOfPicture(sender);    
            //Если по данной ячейке можно ходить        
            if (fields[coords.Y,coords.X] == typeField.CanGo)
            {                
                //То меняем картинку ячейки
                if (nextPlayer == Player.ColorPlayer.Black)                    
                    (sender as System.Windows.Forms.PictureBox).Image = ResourcesFields.GoFieldBlack;
                else if (nextPlayer == Player.ColorPlayer.White)
                    (sender as System.Windows.Forms.PictureBox).Image = ResourcesFields.GoFieldWhite;
            }
        }

        //Событие выхода мышки из ячейки
        private void pictureMouseLeave(object sender, System.EventArgs e)
        {
            //Получаем координаты ячейки, с которой брали мышку
            Point coords = getCoordsOfPicture(sender);
            //Если по данной ячейке можно ходить 
            if (fields[coords.Y, coords.X] == typeField.CanGo)
            {   //То меняем картинку ячейки
                (sender as System.Windows.Forms.PictureBox).Image = ResourcesFields.GoField;
            }
        }

        //Функция хода
        private int changeFields(Point coords,bool justCount = false)
        {
            int changedFields = 0;
            typeField fieldNeed = typeField.White;
            typeField fieldAfter = typeField.Black;
            if (nextPlayer == Player.ColorPlayer.White)
            {
                fieldNeed = typeField.Black;
                fieldAfter = typeField.White;
            }
            Player.TypePlayer player = Player.TypePlayer.Computer;
            if ((player1.getType() == Player.TypePlayer.Human && player1.getColor().ToString() == nextPlayer.ToString())
                || (player2.getType() == Player.TypePlayer.Human && player2.getColor().ToString() == nextPlayer.ToString()))
                player = Player.TypePlayer.Human;

            char[] act1 = { '=', '=', '+', '+', '+', '-', '-', '-' };
            char[] act2 = { '+', '-', '=', '+', '-', '=', '+', '-' };
            byte y = (byte)coords.Y;
            byte x = (byte)coords.X;  
            //Проверяем все 8 рядов: вверх; вверх и вправо; вправо; вниз и вправо и т. д. как на компассе
            for (byte act = 0; act < act1.Length; act++)
                    {
                        int tmpX = doAct(x, act1[act]);
                        int tmpY = doAct(y, act2[act]);
                        if (tmpX >= 0 && tmpX < size && tmpY >= 0 && tmpY < size)
                        {
                            if (fields[tmpY, tmpX] == fieldNeed) //Если найдена противоположная фишка
                            {
                                tmpX = doAct(tmpX, act1[act]);
                                tmpY = doAct(tmpY, act2[act]);                        
                                if (tmpX >= 0 && tmpX < size && tmpY >= 0 && tmpY < size)
                                {
                                        bool trueRule = false;
                                        //Проходим по ряду
                                        while ((tmpX >= 0 && tmpX < size && tmpY >= 0 && tmpY < size) && (!trueRule))
                                        {
                                            if (fields[tmpY, tmpX] == fieldNeed) //Если противоположная фишка, то переходим к следующей фишке
                                            {                                                
                                                tmpX = doAct(tmpX, act1[act]);
                                                tmpY = doAct(tmpY, act2[act]);
                                            }
                                            else if (fields[tmpY, tmpX] == fieldAfter)  //Если найдена своя фишка, то найден ряд, в котором необходимо заменить фишки
                                            {
                                                trueRule = true;
                                                //break;
                                            }
                                            else //Если найдена пустая ячейка, то останавливаем проверку данного ряда
                                            {
                                                tmpX = size + 1;
                                            }
                                        }
                                    //Если ряд прошёл успешно критерии правил
                                    if (trueRule)
                                    {
                                        int firstX = doAct(x, act1[act]);
                                        int firstY = doAct(y, act2[act]);
                                        tmpX = doAct(tmpX, act1[act]);
                                        tmpY = doAct(tmpY, act2[act]);
                                        while ((firstX!=tmpX)||(firstY!=tmpY))
                                        {                   
                                            //Подсчитываем, сколько нужно менять ячеек                                                     
                                            changedFields++;
                                            //Если не только считаем
                                            if (!justCount)
                                            {   //Меняем фишки
                                                fields[firstY, firstX] = fieldAfter;
                                                if (fieldAfter == typeField.Black)
                                                {
                                                    pictureFields[firstY, firstX].Image = ResourcesFields.fieldBlack;
                                                }
                                                else if (fieldAfter == typeField.White)
                                                {
                                                    pictureFields[firstY, firstX].Image = ResourcesFields.fieldWhite;
                                                }
                                            }
                                            firstX = doAct(firstX, act1[act]);
                                            firstY = doAct(firstY, act2[act]);
                                        }

                          
                                        /*for (int yChange = doAct(y, act2[act]); yChange <= tmpY; yChange++)
                                        {
                                            for (int xChange = doAct(x, act1[act]); xChange <= tmpX; xChange++)
                                            {
                                                changedFields++;
                                                if (!justCount)
                                                {
                                                    fields[yChange, xChange] = fieldAfter;
                                                    if (fieldAfter == typeField.Black)
                                                    {
                                                        pictureFields[yChange, xChange].Image = ResourcesFields.fieldBlack;
                                                    }
                                                    else if (fieldAfter == typeField.White)
                                                    {
                                                        pictureFields[yChange, xChange].Image = ResourcesFields.fieldWhite;
                                                    }
                                                }
                                            }
                                        }*/
                                    }
                                        /*Console.WriteLine("\nNew");
                                        Console.WriteLine("doAct: " + doAct(x, act1[act]).ToString() + " " + doAct(y, act2[act]).ToString());
                                        Console.WriteLine("  tmp: " + tmpX.ToString() + " " + tmpY.ToString());                            */
                                }                                                                 
                            }
                        }
                    }

            //Если не просто считаем, а делаем ход
            if (!justCount)
            {   //Задаём следующего пользователя
                if (nextPlayer == Player.ColorPlayer.Black)
                {
                    fields[coords.Y, coords.X] = typeField.Black;
                    pictureFields[coords.Y, coords.X].Image = ResourcesFields.fieldBlack;
                    nextPlayer = Player.ColorPlayer.White;
                }
                else if (nextPlayer == Player.ColorPlayer.White)
                {
                    fields[coords.Y, coords.X] = typeField.White;
                    pictureFields[coords.Y, coords.X].Image = ResourcesFields.fieldWhite;
                    nextPlayer = Player.ColorPlayer.Black;
                }                
            }    
            //Возвращаем количество изменённых/возможно изменённых ячеек 
            return changedFields;
        }

        //Ход компьютера
        private void computerStep()
        {
            Player.TypePlayer player = Player.TypePlayer.Computer;
            if ((player1.getType() == Player.TypePlayer.Human && player1.getColor().ToString() == nextPlayer.ToString())
                || (player2.getType() == Player.TypePlayer.Human && player2.getColor().ToString() == nextPlayer.ToString()))
                player = Player.TypePlayer.Human;
            //Если игрок который ходит - компьютер
            if (player == Player.TypePlayer.Computer)
            {   //Находим ходы компьютера
                FindNextSteps();
                int[] max = new int[] { -1, -1 };
                int[] Xmax = new int[] { 0, 0 };
                int[] Ymax = new int[] { 0, 0 };
                Point p = new Point();
                //Ищем ячейки, ряды которых, наиболее присвоят себе фишек
                for (byte y = 0; y < size; y++)
                {
                    for (byte x = 0; x < size; x++)
                    {
                        if (fields[y, x] == typeField.CanGoComputer)
                        {
                            p.X = x;
                            p.Y = y;
                            int tmpMax = changeFields(p, true);
                            if (tmpMax >= max[0])
                            {
                                max[1] = max[0];
                                Xmax[1] = Xmax[0];
                                Ymax[1] = Ymax[0];

                                max[0] = tmpMax;
                                Xmax[0] = x;
                                Ymax[0] = y;

                                if (max[1] == -1)
                                {
                                    max[1] = tmpMax;
                                    Xmax[1] = x;
                                    Ymax[1] = y;
                                }
                            }
                        }
                    }
                }
                Random rand = new Random();
                int r = rand.Next(0, 2);
                p.Y = Ymax[r];
                p.X = Xmax[r];
                System.Threading.Thread.Sleep(rand.Next(500,850));
                changeFields(p);
            }
        }
        //Функция, прорисовать картинки снова
        private void paintAgain()
        {
            for(byte y=0;y<size;y++)
            {
                for (byte x = 0; x < size; x++)
                {
                    if (fields[y,x] == typeField.Black)
                        pictureFields[y, x].Image = ResourcesFields.fieldBlack;
                    else if (fields[y, x] == typeField.White)
                        pictureFields[y, x].Image = ResourcesFields.fieldWhite;
                    else if (fields[y, x] == typeField.CanGo)
                        pictureFields[y, x].Image = ResourcesFields.GoField;
                    else
                        pictureFields[y, x].Image = ResourcesFields.field;
                }
            }
        }
        //Событие нажатия на картинку, после срабатывания MouseDown
        private void pictureOnClick(object sender, System.EventArgs e)
        {
            /*if (e.Button == System.Windows.Forms.MouseButtons.Left)
            { Console.WriteLine("Left click"); }*/
            //Если была нажата левая кнопка мыши
            if (leftDown)
            {
                computerStep();
                FindNextSteps();
                leftDown = false;
            }
        }

        private bool leftDown = false;
        //Событие нажатия на картинку
        private void pictureMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {   //Если нажата левая кнопка мыши
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {   //Находим координаты ячейки
                Point coords = getCoordsOfPicture(sender);
                if (fields[coords.Y, coords.X] == typeField.CanGo)
                {
                    leftDown = true;
                    //Делаем ход
                    changeFields(coords);                    
                    //Находим новые шаги, следующему игроку
                    FindNextSteps();                    
                }
            }
        }
        //Функция вычисления координат ячейки по имени картинки
        private System.Drawing.Point getCoordsOfPicture(object sender)
        {
            string[] coords = (sender as System.Windows.Forms.PictureBox).Name.Split(spliter);            
            return new System.Drawing.Point(int.Parse(coords[1]), int.Parse(coords[0]));
        }        
    }
}
