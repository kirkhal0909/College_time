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
    public partial class Form_Orders : Form
    {
        public Form_Orders()
        {
            InitializeComponent();
        }

        //Загрузка данных из базы данных при загрузке формы
        private void Form_Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersDataSet.Запрос_элементы_заказа". При необходимости она может быть перемещена или удалена.
            this.запрос_элементы_заказаTableAdapter.Fill(this.ordersDataSet.Запрос_элементы_заказа);
            this.запрос_элементы_заказаTableAdapter.Fill(this.ordersDataSet.Запрос_элементы_заказа);         
            this.запрос_заказ_клиентTableAdapter.Fill(this.ordersDataSet.Запрос_заказ_клиент);            
            this.заказыTableAdapter.Fill(this.ordersDataSet.Заказы);

            if (заказыBindingSource.Count > 0)
            {
                try
                {
                    заказыBindingSource_CurrentItemChanged(null, null);
                }
                catch { }
            }
        }

        //Поиск клиента и элементов связанных с заказом и вычисление полной стоимости
        private void заказыBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {            
            string order = "";            
            try
            {
                order = заказыDataGridView.Rows[заказыBindingSource.Position].Cells[dataGridViewTextBoxColumnНомерЗаказа.DisplayIndex].Value.ToString();                
            }
            catch { }
            if (order.Length > 0)
            {
                //MessageBox.Show(заказыDataGridView.Rows[заказыBindingSource.Position].Cells[dataGridViewTextBoxColumnИдКлиента.DisplayIndex].Value.ToString());
                запрос_заказ_клиентBindingSource.Filter = "ИД_клиента=" + заказыDataGridView.Rows[заказыBindingSource.Position].Cells[dataGridViewTextBoxColumnИдКлиента.DisplayIndex].Value.ToString();
                запрос_элементы_заказаBindingSource.Filter = "Номер_заказа=" + order;

                int sum = 0;
                for (int r = 0; r < запрос_элементы_заказаDataGridView.RowCount; r++)
                {
                    sum += (int.Parse(запрос_элементы_заказаDataGridView.Rows[r].Cells[dataGridViewTextBoxColumnКоличество.DisplayIndex].Value.ToString()) * int.Parse(запрос_элементы_заказаDataGridView.Rows[r].Cells[dataGridViewTextBoxColumnЦена.DisplayIndex].Value.ToString()));
                }

                
                labelInfo.Text = "ИД клиента: "+запрос_заказ_клиентDataGridView.Rows[0].Cells[dataGridViewTextBoxColumnИдКлиента.DisplayIndex].Value
                    +"\nКлиент: " + запрос_заказ_клиентDataGridView.Rows[0].Cells[dataGridViewTextBoxColumnИнфоФИО.DisplayIndex].Value
                    + "\nАдрес: " + запрос_заказ_клиентDataGridView.Rows[0].Cells[dataGridViewTextBoxColumnИнфоАдрес.DisplayIndex].Value
                    + "\nТелефон: " + запрос_заказ_клиентDataGridView.Rows[0].Cells[dataGridViewTextBoxColumnИнфоНомер.DisplayIndex].Value
                    + "\nСумма заказа: "+sum.ToString();
                //MessageBox.Show(s);
            }
        }
    }
}
