using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reversi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                       
        }
        Reversi game;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Создаём игровое поле: игрок против игрока
            //и инициализируем игру
            game = new Reversi(getSize(),Reversi.TypeGame.PlayerVsPlayer);            
        }
        //Функция которая возвращает размер поля, в зависимости от выбора пользователя
        private byte getSize()
        {   //Задаём размер по умолчанию
            byte size = 8;
            //Если пользователь выбрал 10x10, то меняем размер
            if (radioButton10x10.Checked)
                size = 10;
            //Иначе если пользователь выбрал 12x12, то меняем размер
            else if (radioButton12x12.Checked)
                size = 12;
            return size;
        }

        private void buttonStartVsComputer_Click(object sender, EventArgs e)
        {
            //Создаём игровое поле: игрок против компьютера
            //и инициализируем игру
            game = new Reversi(getSize(),Reversi.TypeGame.PlayerVsComputer);
        }

        //Функция которая позваляет спрятать/показать панель с кнопками
        //Вызывается из класса Reversi в файле Reversi.cs
        //Там же все функции(в Reversi.cs) работы игры
        public void hidePanel(bool hide = true)
        {
            panel1.Visible = !hide;
        }
    }
}
