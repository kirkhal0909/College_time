using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            /*Products FormProducts = new Products();
            FormProducts.StartPosition = FormStartPosition.Manual;
            FormProducts.Left = this.Left-FormProducts.Width/5;
            FormProducts.Top = this.Top;// - FormProducts.Height / 4;
            FormProducts.ShowDialog();*/
        }

        //Открываем форму Блюда
        private void button2_Click(object sender, EventArgs e)
        {
            Dishes FormDishes = new Dishes();
            FormDishes.ShowDialog();
        }

        //Открываем форму редактирования блюд
        private void button3_Click(object sender, EventArgs e)
        {
            EditDishes formEditDishes = new EditDishes();
            formEditDishes.ShowDialog();
        }
    }
}
