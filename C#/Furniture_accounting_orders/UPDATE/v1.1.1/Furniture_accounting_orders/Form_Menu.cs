using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Furniture_accounting_orders
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }
        //Открыть форму - Редактор мебели
        private void buttonEditFurniture_Click(object sender, EventArgs e)
        {
            Form1 form_furniture = new Form1();
            form_furniture.ShowDialog();
        }
        //Открыть форму - Клиенты
        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form_Clients form_clients = new Form_Clients();
            form_clients.ShowDialog();
        }
        //Открыть форму - Заказы
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            bool opened = false;
            while (!opened)
            {
                try
                {
                    Form_Orders form_orders = new Form_Orders();
                    //System.Threading.Thread.Sleep(100);
                    form_orders.ShowDialog();
                    opened = true;                                        
                }
                catch(System.InvalidOperationException ex)
                {      //При возникновении проблемы с открытием, попробовать снова через 0.15 секунды  
                    System.Threading.Thread.Sleep(150);
                    //MessageBox.Show("Error");                    
                }
            }
        }
        //Открыть форму - добавить заказ
        private void buttonOrderAdd_Click(object sender, EventArgs e)
        {
            Form_Add_order form_add_order = new Form_Add_order();
            form_add_order.ShowDialog();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
