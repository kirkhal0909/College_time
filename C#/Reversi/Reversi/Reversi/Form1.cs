using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reversi
{
    public partial class Form1 : Form
    {
                Game game;
                private class Game
                {
                    public enum TypeGame { PlayerVsPlayer, PlayerVsComputer };
                    private TypeGame typeGame = TypeGame.PlayerVsComputer;
                    public Game(int size = 8, TypeGame typeGame = TypeGame.PlayerVsComputer)
                    {
                        this.size = size;
                        this.typeGame = typeGame;
                        fields = new field[size, size];
                        fieldsTmp = new field[size, size];
                        for (int r = 0; r < size; r++)
                            for (int c = 0; c < size; c++)
                            {
                                fieldsTmp[r, c] = field.Empty;
                                fields[r, c] = field.Empty;
                            }
                

                        int firstField = size / 2 - 1;
                        fields[firstField, firstField] = field.White;
                        fields[firstField + 1, firstField + 1] = field.White;
                        fields[firstField + 1, firstField] = field.Black;
                        fields[firstField, firstField + 1] = field.Black;

                        Player.color clr = Player.color.White;
                        if (player1.getColor() == Player.color.White)
                            clr = Player.color.Black;
                        Player.typePlayer tpPlayer = Player.typePlayer.Computer;
                        if (typeGame == TypeGame.PlayerVsPlayer)
                            tpPlayer = Player.typePlayer.Human;
                        this.player2 = new Player(tpPlayer,clr);
                for (int r = 0; r < size; r++)
                    for (int c = 0; c < size; c++)
                        fieldsTmp[r, c] = fields[r, c];                
                        initNextStep();
                        //fields[1, 1] = field.CanGo;
                    }

            public void playerDoStep(Point fieldPoint)
            {
                for (int r = 0; r < size; r++)
                    for (int c = 0; c < size; c++)
                        fieldsTmp[r, c] = fields[r, c];

                field fieldToChange = field.White;
                field fieldToEnd = field.Black;
                if (nextStep == Player.color.White)
                {
                    fieldToChange = field.Black;
                    fieldToEnd = field.White;
                }                

                clearCanGo();

                int stepR = fieldPoint.Y;
                int stepC = fieldPoint.X;
                //MessageBox.Show("start");
                for (int stepRAround = stepR - 1; stepRAround <= stepR + 1; stepRAround++)
                    {
                        for (int stepCAround = stepC - 1; stepCAround <= stepC + 1; stepCAround++)
                        {
                            if (stepRAround >= 0 && stepCAround >= 0 && stepRAround < size && stepCAround < size
                                && !(stepRAround == stepR && stepCAround == stepC))
                            {
                                if (getField(stepRAround, stepCAround) == fieldToChange)
                                {
                                    int deltaR = stepRAround - stepR;
                                    int deltaC = stepCAround - stepC;
                                    int tmpR = stepRAround;
                                    int tmpC = stepCAround;
                                    while ((tmpR >= 0 && tmpR < size) && (tmpC >= 0 && tmpC < size))
                                    {
                                        if (getField(tmpR, tmpC) == field.Empty) break;
                                        if (getField(tmpR, tmpC) == fieldToEnd)
                                        {
                                            tmpR = stepRAround;
                                            tmpC = stepCAround;                                            
                                            while ((tmpR >= 0 && tmpR < size) && (tmpC >= 0 && tmpC < size))
                                            {
                                                if (getField(tmpR, tmpC) == fieldToChange)
                                                {
                                                    fields[tmpR, tmpC] = fieldToEnd;
                                                    tmpR += deltaR;
                                                    tmpC += deltaC;
                                                }
                                                else break;
                                            }
                                            break;
                                        }
                                        tmpR += deltaR;
                                        tmpC += deltaC;
                                    }
                                }
                            }
                        }
                    }

                

                Player.color lastPlayer = whoNext();
                field fill = field.Black;
                if (lastPlayer == Player.color.White)
                {
                    fill = field.White;
                    nextStep = Player.color.Black;
                }
                else nextStep = Player.color.White;
                fields[fieldPoint.Y, fieldPoint.X] = fill;                
                initNextStep();
            }

            public void computerDoStep()
            {
                Random random = new Random();                
                System.Threading.Thread.Sleep(random.Next(1, 2) * 1000);
                bool enterStep = false;
                int r = 0, c = 0;
                while(!enterStep)
                {
                    if(getField(r,c)==field.CanGoComputer)
                    {
                        Random rand2 = new Random();
                        int doNext = rand2.Next(1, 100);
                        if (doNext <= 100 / 5)
                        {
                            enterStep = true;
                            Point p = new Point(c, r);
                            playerDoStep(p);
                            //initNextStep();
                        }
                    }
                    c++;
                    if(c>=size)
                    {
                        c = 0;
                        r++;
                        if (r >= size)
                            r = 0;
                    }
                }                               
            }

            private int whites = 0,blacks = 0;

            public int getWhites()
            {
                return whites;
            }

            public int getBlacks()
            {
                return blacks;
            }

            private void FinishCount()
            {
                whites = 0;
                blacks = 0;                
                for (int r =0;r<size;r++)
                    for (int c = 0; c < size; c++)
                        if(fields[r,c]==field.Black)
                        {
                            blacks++;
                        } else if (fields[r, c] == field.White)
                        {
                            whites++;
                        }
            }

            private void initNextStep()
                    {
                bool init = true;
                bool zeroStepsFirstPlayer = false;
                while(init)
                {
                        //fieldsTmp = fields;
                        field fieldToFind = field.White;    
                        field fieldToEnd = field.Black;                
                        if (nextStep == Player.color.White)
                        {
                            fieldToFind = field.Black;
                            fieldToEnd = field.White;
                        }
                        bool playerIsHuman = false;
                        if ((player1.getColor() == nextStep && player1.getTypePlayer() == Player.typePlayer.Human) ||
                            (player2.getColor() == nextStep && player2.getTypePlayer() == Player.typePlayer.Human))
                        { playerIsHuman = true; }

                    //MessageBox.Show(player2.getColor().ToString()+" "+nextStep.ToString());                
                    //MessageBox.Show(player2.getTypePlayer().ToString()); 

                    //Console.WriteLine("\n\n\nНовый поиск ходов:\n\n\n");                           

                    for (int stepR = 0; stepR < size; stepR++)
                    {
                        for (int stepC = 0; stepC < size; stepC++)
                        {
                            //Console.WriteLine("Клетка "+stepR.ToString()+" "+stepC.ToString());
                            bool foundedNewStep = false;
                            if (getField(stepR, stepC) == field.Empty)
                            {
                                for (int stepRAround = stepR - 1; stepRAround <= stepR + 1; stepRAround++)
                                {
                                    for (int stepCAround = stepC - 1; stepCAround <= stepC + 1; stepCAround++)
                                    {
                                        if (stepRAround >= 0 && stepCAround >= 0 && stepRAround < size && stepCAround < size
                                            && !(stepRAround == stepR && stepCAround == stepC))
                                        {
                                            if (getField(stepRAround, stepCAround) == fieldToFind)
                                            {
                                                int deltaR = stepRAround - stepR;
                                                int deltaC = stepCAround - stepC;
                                                int tmpR = stepRAround;
                                                int tmpC = stepCAround;
                                                //Console.WriteLine("Найдена чужая фишка на: " + stepRAround.ToString() + " " + stepCAround.ToString());
                                                //Console.WriteLine("Должен быть Следующий шаг: " + (tmpR + deltaR).ToString() + " " + (tmpC + deltaC).ToString());
                                                while ((tmpR >= 0 && tmpR < size) && (tmpC >= 0 && tmpC < size))
                                                {
                                                    //Console.WriteLine("Проверка: " + (tmpR).ToString() + " " + (tmpC).ToString());
                                                    if (getField(tmpR, tmpC) == field.Empty)
                                                    {
                                                        //Console.WriteLine("Пустая клетка: " + tmpR.ToString() + " " + tmpC.ToString());
                                                        tmpR = -10; tmpC = -10;
                                                        break;
                                                    }
                                                    if (getField(tmpR, tmpC) == fieldToEnd)
                                                    {
                                                        //Console.WriteLine("Найдена своя фишка: " + tmpR.ToString() + " " + tmpC.ToString());
                                                        init = false;
                                                        tmpR = -10; tmpC = -10;
                                                        fields[stepR, stepC] = field.CanGoComputer;
                                                        if (playerIsHuman)
                                                            fields[stepR, stepC] = field.CanGo;
                                                        foundedNewStep = true;
                                                        break;
                                                    }
                                                    tmpR = tmpR + deltaR;
                                                    tmpC = tmpC + deltaC;
                                                    //Console.WriteLine("Следующий шаг: " + (tmpR + deltaR).ToString() + " " + (tmpC + deltaC).ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (init && !zeroStepsFirstPlayer)
                    {
                        zeroStepsFirstPlayer = true;
                        if (nextStep == Player.color.White)
                        {
                            nextStep = Player.color.Black;
                        }
                        else nextStep = Player.color.White;
                    }
                    else { init = false; FinishCount(); }
                }


                /*for (int stepR = 0; stepR < size; stepR++)
                {
                    Console.WriteLine();
                    for (int stepC = 0; stepC < size; stepC++)
                    {
                        Console.Write(fields[stepR,stepC].ToString()+" ");
                    }                    
                }
                Console.WriteLine();*/

            }

                    private int size;
                    //public int[] fieldColors = { 255, 78, 143, 46};
                    private bool readyToPaint = true;
            
                    private field[,] fields;
                    private field[,] fieldsTmp;

                    public bool changedPos(Point fieldPos)
                    {
                    bool changed = true;
                //MessageBox.Show((fieldPos.Y+1).ToString()+" : "+ (1+fieldPos.X).ToString()+ " "+fields[fieldPos.Y, fieldPos.X].ToString() + " " + fieldsTmp[fieldPos.Y, fieldPos.X].ToString());
                    if(fields[fieldPos.Y, fieldPos.X]== fieldsTmp[fieldPos.Y, fieldPos.X])
                    {
                        changed = false;
                    }
                    return changed;
                    }

                    public enum field { Empty,CanGo,CanGoComputer,Black,White};
                    private Player.color nextStep = Player.color.Black;       

                    public class Player
                    {
                        public enum color { Black,White };
                        public enum typePlayer { Human,Computer};
                        private color myColor;
                        private typePlayer myType;
                        private Point canStep = new Point(-1, -1);

                        public Player(typePlayer playerType = typePlayer.Computer,color playerColor = color.Black)
                        {
                            this.myColor = playerColor;
                            this.myType = playerType;                    
                        }

                        public Point getCanStep()
                        {
                            return canStep;
                        }

                        public color getColor()
                        {
                            return myColor;
                        }

                        public typePlayer getTypePlayer()
                        {
                            return myType;
                        }
                    }

                    public Player.color whoNext()
                    {
                        return nextStep;
                    }                    

                    Player player1 = new Player(Player.typePlayer.Human, Player.color.Black);
                    Player player2 = new Player(Player.typePlayer.Computer, Player.color.White);

                    public void updateWhereCanGo()
                    {

                    }

                    private void clearCanGo()
                    {
                        for (int r = 0; r < size; r++)
                            for (int c = 0; c < size; c++)
                                if (fields[r, c] == field.CanGo || fields[r, c] == field.CanGoComputer)
                                    fields[r, c] = field.Empty;
                    }

            

                    public field getField(int r,int c)
                    {
                        return fields[r, c];
                    }

                    public bool getStatusReady()
                    {
                        return readyToPaint;
                    }

                    public int getSize()
                    {
                        return size;
                    }

                    public void startGame()
                    {
                        //readyToStart = false;
                    }
                }




        public Form1()
        {
            InitializeComponent();
            //Reversi reversi = new Reversi(this);            
        }

        private int fixedWidth = 16;
        private int fixedHeight = 39;

        private void Form1_Load(object sender, EventArgs e)
        {           
            //this.Left = 0;
        }

        int[] coordsPos;

        private void startGame(Game.TypeGame typeGame)
        {            
            panelStartGame.Visible = false;
            int size = 8;            

            if (radioButton10x10.Checked)
            { size = 10; }
            else if (radioButton12x12.Checked)
            { size = 12; }

            coordsPos = new int[size * 2];

            for (int stepC = 0; stepC < size * 2; stepC += 2)
            {
                int x = 1 + sizeBrush * ((stepC + 1) / 2) + sizeRect * (stepC / 2);
                coordsPos[stepC] = x;
                coordsPos[stepC + 1] = x + sizeRect - 1;
                //MessageBox.Show(coordsPos[stepC].ToString() + " " + coordsPos[stepC + 1].ToString());
            }

            game = new Game(size,typeGame);
            //int size = game.getSize();
            int sizeForm = 3 + sizeBrush * size + sizeRect * size;

            this.MaximumSize = new Size(sizeForm + fixedWidth, sizeForm + fixedHeight);
            this.MinimumSize = new Size(sizeForm + fixedWidth, sizeForm + fixedHeight);
            this.Invalidate();
            this.CenterToScreen();
        }


        private int sizeRect = 55;
        private int minusSizeEll = 2;
        private int[] penColor = { 255,130,138,127};
        private int sizeBrush = 2;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {            
            if (game != null)
            if (game.getStatusReady())
            {
                int size = game.getSize();
                Pen penLine = new Pen(new SolidBrush(Color.FromArgb(penColor[0], penColor[1], penColor[2], penColor[3])), sizeBrush);
                for (int step = 0; step <= size; step++)
                {
                    int coord = 1 + sizeBrush * step + sizeRect * step;
                    e.Graphics.DrawLine(penLine, 1, coord, this.Width, coord);
                    e.Graphics.DrawLine(penLine, coord, 1, coord, this.Height);
                }
                //int sizeForm = 3 + sizeBrush * size + sizeRect * size;
                //MessageBox.Show(sizeForm.ToString());


                for (int stepR = 0; stepR < size; stepR++)
                {
                    int y = 1 + sizeBrush * (stepR + 1) + sizeRect * stepR;
                    for (int stepC = 0; stepC < size; stepC++)
                    {
                        int x = 1 + sizeBrush * (stepC + 1) + sizeRect * stepC;
                            LinearGradientBrush linGrBrush = new LinearGradientBrush(
                                //new Point(0, 10),
                                //new Point(y+x+sizeRect, 10),
                                new Rectangle(x, y, sizeRect, sizeRect),
                                Color.FromArgb(255, 0, 150, 0),
                                Color.FromArgb(255, 0, 120, 0),
                                LinearGradientMode.ForwardDiagonal);
                            //e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(game.fieldColors[0], game.fieldColors[1], game.fieldColors[2], game.fieldColors[3])), x, y, sizeRect, sizeRect);
                            e.Graphics.FillRectangle(linGrBrush, x, y, sizeRect, sizeRect);
                            if(game.getField(stepR,stepC)==Game.field.White)
                            {
                                LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                                    new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                                    Color.FromArgb(255, 255, 255, 255),
                                    Color.FromArgb(255, 255, 210, 255),
                                    LinearGradientMode.ForwardDiagonal);
                                e.Graphics.FillEllipse(linGrBrushEll, x+minusSizeEll, y+minusSizeEll, sizeRect-minusSizeEll*2, sizeRect-minusSizeEll*2);
                            } else if (game.getField(stepR, stepC) == Game.field.Black)
                            {
                                int frm = 12;
                                int to = 30;
                                LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                                    new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                                    Color.FromArgb(255, frm, frm,frm),
                                    Color.FromArgb(255, to, to, to),
                                    LinearGradientMode.ForwardDiagonal);
                                e.Graphics.FillEllipse(linGrBrushEll, x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2);
                            } else if (game.getField(stepR, stepC) == Game.field.CanGo)
                            {
                                LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                                    new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                                    Color.FromArgb(255, 190, 0, 0),
                                    Color.FromArgb(255, 153, 0, 0),
                                    LinearGradientMode.ForwardDiagonal);
                                e.Graphics.FillRectangle(linGrBrushEll, x, y, sizeRect, sizeRect);
                            }
                            //e.Graphics.FillEllipse(new SolidBrush(Color.Red), x, y, sizeRect, sizeRect);
                        }
                }
                game.startGame();
            }
                else
                {
                    int size = game.getSize();
                    Pen penLine = new Pen(new SolidBrush(Color.FromArgb(penColor[0], penColor[1], penColor[2], penColor[3])), sizeBrush);
                    for (int step = 0; step <= size; step++)
                    {
                        int coord = 1 + sizeBrush * step + sizeRect * step;
                        e.Graphics.DrawLine(penLine, 1, coord, this.Width, coord);
                        e.Graphics.DrawLine(penLine, coord, 1, coord, this.Height);
                    }
                }          
            //MessageBox.Show("123");           
            //e.Graphics.DrawLine(Pens.Red, 1, 1, this.Width, 1);
        }

        private void buttonTwoPlayers_Click(object sender, EventArgs e)
        {
            startGame(Game.TypeGame.PlayerVsPlayer);
        }

        private void buttonPlayerVsPC_Click(object sender, EventArgs e)
        {
            startGame(Game.TypeGame.PlayerVsComputer);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sizeRect = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString();
            this.Invalidate();
        }

        private Point lastDrawed = new Point(-1, -1);
        private Point DrawOnUp = new Point(-1, -1);

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (game != null)
            if (DrawOnUp.X == -1 || DrawOnUp.Y == -1)
            if (game.getStatusReady())
            {
               Point mouse = this.PointToClient(Cursor.Position);
                    int xPos = -1, yPos = -1;
                    for (int x = 0; x < coordsPos.Length-1; x++)
                    {                        
                        if (mouse.X >= coordsPos[x] && mouse.X <= coordsPos[x + 1])
                        {                            
                            xPos = x / 2;
                            break;
                        }
                    }
                    for (int y = 0; y < coordsPos.Length-1; y++)
                    {
                        if (mouse.Y >= coordsPos[y] && mouse.Y <= coordsPos[y + 1])
                        {
                            yPos = y / 2;
                            break;
                        }
                    }
                    if (yPos == -1) xPos = -1;
                    else if (xPos == -1) yPos = -1;

                    if(yPos!=-1 && xPos != -1)
                    {
                        if(xPos!=lastDrawed.X || yPos != lastDrawed.Y)
                        {
                            drawField(lastDrawed);
                            lastDrawed.X = xPos;
                            lastDrawed.Y = yPos;
                            highlightFieldOnMove(lastDrawed);
                        }
                    }                    
                    //labelCoords.Text = xPos.ToString() + " : " + yPos.ToString();
                    //labelCoords.Text = mouse.X.ToString() + " : " + mouse.Y.ToString();
                }            
        }
        
        private void highlightFieldOnMove(Point field)
        {
            int stepR = field.Y;
            int stepC = field.X;
            int size = -1;
            if (game != null) size = game.getSize();                    
            if (stepR >= 0 && stepR < size && stepC >= 0 && stepC < size)
            {
                if (game.getField(stepR, stepC) == Game.field.CanGo)
                {
                    int y = 1 + sizeBrush * (stepR + 1) + sizeRect * stepR;
                    int x = 1 + sizeBrush * (stepC + 1) + sizeRect * stepC;
                    Graphics g = this.CreateGraphics();
                    LinearGradientBrush linGrBrushRect = new LinearGradientBrush(
                        new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                        Color.FromArgb(255, 230, 150, 0),
                        Color.FromArgb(255, 190, 0, 0),
                        LinearGradientMode.ForwardDiagonal);
                    g.FillRectangle(linGrBrushRect, x, y, sizeRect, sizeRect);

                    if (game.whoNext() == Game.Player.color.White)
                    {
                        LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                            new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                            Color.FromArgb(255, 255, 255, 255),
                            Color.FromArgb(255, 255, 210, 255),
                            LinearGradientMode.ForwardDiagonal);
                        g.FillEllipse(linGrBrushEll, x + minusSizeEll*8, y + minusSizeEll*8, sizeRect - minusSizeEll * 16, sizeRect - minusSizeEll * 16);
                    }
                    else if (game.whoNext() == Game.Player.color.Black)
                    {
                        int frm = 12;
                        int to = 30;
                        LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                            new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                            Color.FromArgb(255, frm, frm, frm),
                            Color.FromArgb(255, to, to, to),
                            LinearGradientMode.ForwardDiagonal);
                        g.FillEllipse(linGrBrushEll, x + minusSizeEll*8, y + minusSizeEll*8, sizeRect - minusSizeEll * 16, sizeRect - minusSizeEll * 16);
                    }
                }              
            }
        }

        private void highlightFieldOnClickDown(Point field)
        {
            int stepR = field.Y;
            int stepC = field.X;
            int size = -1;
            if (game != null) size = game.getSize();
            if (stepR >= 0 && stepR < size && stepC >= 0 && stepC < size)
            {
                if (game.getField(stepR, stepC) == Game.field.CanGo)
                {
                    int y = 1 + sizeBrush * (stepR + 1) + sizeRect * stepR;
                    int x = 1 + sizeBrush * (stepC + 1) + sizeRect * stepC;
                    Graphics g = this.CreateGraphics();
                    LinearGradientBrush linGrBrushRect = new LinearGradientBrush(
                        new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                        Color.FromArgb(255, 230, 150, 0),
                        Color.FromArgb(255, 190, 0, 0),
                        LinearGradientMode.ForwardDiagonal);
                    g.FillRectangle(linGrBrushRect, x, y, sizeRect, sizeRect);

                    if (game.whoNext() == Game.Player.color.White)
                    {
                        LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                            new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                            Color.FromArgb(255, 255, 255, 255),
                            Color.FromArgb(255, 255, 210, 255),
                            LinearGradientMode.ForwardDiagonal);
                        g.FillEllipse(linGrBrushEll, x + minusSizeEll * 4, y + minusSizeEll * 4, sizeRect - minusSizeEll * 8, sizeRect - minusSizeEll * 8);
                    }
                    else if (game.whoNext() == Game.Player.color.Black)
                    {
                        int frm = 12;
                        int to = 30;
                        LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                            new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                            Color.FromArgb(255, frm, frm, frm),
                            Color.FromArgb(255, to, to, to),
                            LinearGradientMode.ForwardDiagonal);
                        g.FillEllipse(linGrBrushEll, x + minusSizeEll * 4, y + minusSizeEll * 4, sizeRect - minusSizeEll * 8, sizeRect - minusSizeEll * 8);
                    }
                }
            }
        }

        private void drawField(Point field,int smallerTo = 1)
        {            
            int stepR = field.Y;
            int stepC = field.X;
            int size = -1;
            if (game != null) size = game.getSize();            
            if (stepR >= 0 && stepR < size && stepC >= 0 && stepC < size)
            {
                int y = 1 + sizeBrush * (stepR + 1) + sizeRect * stepR;
                int x = 1 + sizeBrush * (stepC + 1) + sizeRect * stepC;
                Graphics g = this.CreateGraphics();
                LinearGradientBrush linGrBrush = new LinearGradientBrush(
                                //new Point(0, 10),
                                //new Point(y+x+sizeRect, 10),
                                new Rectangle(x, y, sizeRect, sizeRect),
                                Color.FromArgb(255, 0, 150, 0),
                                Color.FromArgb(255, 0, 120, 0),
                                LinearGradientMode.ForwardDiagonal);
                //e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(game.fieldColors[0], game.fieldColors[1], game.fieldColors[2], game.fieldColors[3])), x, y, sizeRect, sizeRect);
                g.FillRectangle(linGrBrush, x, y, sizeRect, sizeRect);
                if (game.getField(stepR, stepC) == Game.field.White)
                {
                    LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                        new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                        Color.FromArgb(255, 255, 255, 255),
                        Color.FromArgb(255, 255, 210, 255),
                        LinearGradientMode.ForwardDiagonal);
                    g.FillEllipse(linGrBrushEll, x + minusSizeEll * smallerTo, y + minusSizeEll * smallerTo, sizeRect - minusSizeEll * 2*smallerTo, sizeRect - minusSizeEll * 2 * smallerTo);
                }
                else if (game.getField(stepR, stepC) == Game.field.Black)
                {
                    int frm = 12;
                    int to = 30;
                    LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                        new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                        Color.FromArgb(255, frm, frm, frm),
                        Color.FromArgb(255, to, to, to),
                        LinearGradientMode.ForwardDiagonal);
                    g.FillEllipse(linGrBrushEll, x + minusSizeEll * smallerTo, y + minusSizeEll * smallerTo, sizeRect - minusSizeEll * 2 * smallerTo, sizeRect - minusSizeEll * 2*smallerTo);
                }
                else if (game.getField(stepR, stepC) == Game.field.CanGo)
                {
                    LinearGradientBrush linGrBrushEll = new LinearGradientBrush(
                        new Rectangle(x + minusSizeEll, y + minusSizeEll, sizeRect - minusSizeEll * 2, sizeRect - minusSizeEll * 2),
                        Color.FromArgb(255, 190, 0, 0),
                        Color.FromArgb(255, 153, 0, 0),
                        LinearGradientMode.ForwardDiagonal);
                    g.FillRectangle(linGrBrushEll, x, y, sizeRect, sizeRect);
                }
            }
        }        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (game != null)
                if (game.getStatusReady())
                {
                    Point mouse = this.PointToClient(Cursor.Position);
                    int xPos = -1, yPos = -1;
                    for (int x = 0; x < coordsPos.Length - 1; x++)
                    {
                        if (mouse.X >= coordsPos[x] && mouse.X <= coordsPos[x + 1])
                        {
                            xPos = x / 2;
                            break;
                        }
                    }
                    for (int y = 0; y < coordsPos.Length - 1; y++)
                    {
                        if (mouse.Y >= coordsPos[y] && mouse.Y <= coordsPos[y + 1])
                        {
                            yPos = y / 2;
                            break;
                        }
                    }
                    if (yPos == -1) xPos = -1;
                    else if (xPos == -1) yPos = -1;

                    if (yPos != -1 && xPos != -1)
                    {
                            //MessageBox.Show("Clicked");         
                            DrawOnUp = lastDrawed;
                            highlightFieldOnClickDown(lastDrawed);                            
                        }
                }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {                
                if (game != null)
                    if (game.getStatusReady())
                    {                        
                        Point mouse = this.PointToClient(Cursor.Position);
                        int xPos = -1, yPos = -1;
                        for (int x = 0; x < coordsPos.Length - 1; x++)
                        {
                            if (mouse.X >= coordsPos[x] && mouse.X <= coordsPos[x + 1])
                            {
                                xPos = x / 2;
                                break;
                            }
                        }
                        for (int y = 0; y < coordsPos.Length - 1; y++)
                        {
                            if (mouse.Y >= coordsPos[y] && mouse.Y <= coordsPos[y + 1])
                            {
                                yPos = y / 2;
                                break;
                            }
                        }
                        if (yPos == -1) xPos = -1;
                        else if (xPos == -1) yPos = -1;

                        if (yPos != -1 && xPos != -1)
                        {
                            if(game.getField(yPos,xPos)==Game.field.CanGo)
                            if (yPos == lastDrawed.Y && xPos == lastDrawed.X)
                            {
                                game.playerDoStep(DrawOnUp);
                                    bool nextComputer = false;
                                    bool foundedCanGo = false;
                                    for (int r = 0; r < game.getSize(); r++)
                                        for (int c = 0; c < game.getSize(); c++)
                                        {
                                            Point p = new Point(c, r);
                                            if (game.changedPos(p))
                                            {
                                                drawField(p);
                                            }                                            
                                            if(game.getField(r,c)==Game.field.CanGoComputer)
                                            {
                                                foundedCanGo = true;
                                                nextComputer = true;                                                
                                            }
                                            if (game.getField(r, c) == Game.field.CanGo)
                                            {
                                                foundedCanGo = true;
                                            }
                                        }
                                    if (nextComputer)
                                    {
                                        foundedCanGo = false;
                                        game.computerDoStep();                                        
                                        for (int r = 0; r < game.getSize(); r++)
                                            for (int c = 0; c < game.getSize(); c++)
                                            {
                                                Point p = new Point(c, r);
                                                if (game.changedPos(p))
                                                {
                                                    drawField(p);
                                                }                    
                                            }
                                    }
                                    if(!foundedCanGo)
                                    {                                        
                                        int b = game.getBlacks();
                                        int w = game.getWhites();
                                        String s = "Белых фишек: "+w.ToString()+"\nЧёрных фишек: "+b.ToString()+"\n";
                                        if (b == w) { s = s + " Ничья"; }
                                        else if( b > w) { s = s + "победил игрок с чёрными фишками"; }
                                        else if (b < w) { s = s + "победил игрок с белыми фишками"; }
                                        MessageBox.Show(s);
                                        this.MaximumSize = new Size(panelStartGame.Width+14, panelStartGame.Height+36);
                                        this.MinimumSize = new Size(panelStartGame.Width+14, panelStartGame.Height+36);
                                        panelStartGame.Left = 0;
                                        panelStartGame.Top = 0;
                                        panelStartGame.Visible = true;
                                        
                                        this.CenterToScreen();
                                    }
                                    //this.Invalidate();
                                    //drawField(DrawOnUp);                                
                                    //MessageBox.Show("Поставил фишку");
                                }
                        }
                        DrawOnUp = new Point(-1, -1);
                    }
            }
        }
    }
}
