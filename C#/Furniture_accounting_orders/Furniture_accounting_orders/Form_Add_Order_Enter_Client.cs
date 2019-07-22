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
    public partial class Form_Add_Order_Enter_Client : Form
    {
        public bool orderAdded = false;

        int col_id, col_name, col_price, col_count;
        DataGridViewRowCollection rows;
        //Получение данных с прошлой формы - Оформление заказа(Где был выбор мебели)
        public Form_Add_Order_Enter_Client(DataGridViewRowCollection rows, int col_id, int col_name, int col_price, int col_count)
        {
            InitializeComponent();
            this.rows = rows;
            this.col_id = col_id;
            this.col_count = col_count;
            this.col_name = col_name;
            this.col_price = col_price;
        }

        //Сохранение таблицы заказов в базе данных
        private void ordersSave()
        {
            this.Validate();
            this.заказыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ordersDataSet);

        }

        //Открыть редактор клиентов
        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form_Clients form_clients = new Form_Clients();
            form_clients.ShowDialog();
            this.клиентыTableAdapter.Fill(this.ordersDataSet.Клиенты);            
        }

        //Сохранения списка товаров в мебели в базе данных
        private void elementsOrderSave()
        {
            this.Validate();
            this.элементы_заказовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ordersDataSet);

        }

        //Загрузка данных из базы данных при загрузке формы
        private void Form_Add_Order_Enter_Client_Load(object sender, EventArgs e)
        {            
            this.элементы_заказовTableAdapter.Fill(this.ordersDataSet.Элементы_заказов);         
            this.заказыTableAdapter.Fill(this.ordersDataSet.Заказы);            
            this.клиентыTableAdapter.Fill(this.ordersDataSet.Клиенты);

        }

        //Кнопка - Оформить заказ
        private void buttonDoOrder_Click(object sender, EventArgs e)
        {            
            заказыBindingSource.AddNew();
            заказыDataGridView.Rows[заказыDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnИДКлиента.DisplayIndex].Value = клиентыDataGridView.Rows[клиентыBindingSource.Position].Cells[dataGridViewTextBoxColumnКлиентыИдКлиента.DisplayIndex].Value;
            заказыDataGridView.Rows[заказыDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnДатаЗаказа.DisplayIndex].Value = DateTime.Now.ToString();
            ordersSave();
            this.заказыTableAdapter.Fill(this.ordersDataSet.Заказы);

            //this.элементы_заказовTableAdapter.Fill(this.ordersDataSet.Элементы_заказов);

            for (int r = 0; r < rows.Count; r++)
            {
                элементы_заказовBindingSource.AddNew();
                элементы_заказовDataGridView.Rows[элементы_заказовDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnНомерМебели.DisplayIndex].Value = rows[r].Cells[col_id].Value;
                элементы_заказовDataGridView.Rows[элементы_заказовDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnЦена.DisplayIndex].Value = rows[r].Cells[col_price].Value;
                элементы_заказовDataGridView.Rows[элементы_заказовDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnКоличество.DisplayIndex].Value = rows[r].Cells[col_count].Value;

                элементы_заказовDataGridView.Rows[элементы_заказовDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnЭлементыЗаказовНомерЗаказа.DisplayIndex].Value = заказыDataGridView.Rows[заказыDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnНомерЗаказа.DisplayIndex].Value;
                //MessageBox.Show(элементы_заказовDataGridView.Rows[заказыDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnНомерЗаказа.DisplayIndex].Value.ToString());
            }

            elementsOrderSave();

            orderAdded = true;
            MessageBox.Show("Заказ оформен");
            this.Close();
        }
    }
}
