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
    public partial class Form_Add_order : Form
    {
        public Form_Add_order()
        {
            InitializeComponent();
        }
        //Загрузка данных из базы данных при загрузке формы
        private void Form_Add_order_Load(object sender, EventArgs e)
        {            
            this.мебельTableAdapter.Fill(this.ordersDataSet.Мебель);            
            this.категорииTableAdapter.Fill(this.ordersDataSet.Категории);
        }


        int sum = 0;
        //Кнопка добавления мебели в заказ
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (мебельBindingSource.Position>=0)
            {
                int n;
                bool isNumeric = int.TryParse(textBoxCount.Text, out n);
                if (!isNumeric)
                {
                    textBoxCount.Text = "1";
                }
                else if (textBoxCount.Text.Length == 0)
                {
                    textBoxCount.Text = "1";
                }

                int furnitureRow = мебельBindingSource.Position;
                bool itemInTable = false;
                //var furnitureID = мебельDataGridView.Rows[furnitureRow].Cells[dataGridViewTextBoxColumnНомерМебели.DisplayIndex].Value;
                int r = -1;                
                for (r = 0; r < dataGridViewItems.RowCount; r++)
                {
                    //MessageBox.Show(dataGridViewItems.Rows[r].Cells[ColumnOrderНомерМебели.DisplayIndex].Value.ToString() + " " + мебельDataGridView.Rows[furnitureRow].Cells[dataGridViewTextBoxColumnНомерМебели.DisplayIndex].Value.ToString());
                    if (dataGridViewItems.Rows[r].Cells[ColumnOrderНомерМебели.DisplayIndex].Value.ToString()== мебельDataGridView.Rows[furnitureRow].Cells[dataGridViewTextBoxColumnНомерМебели.DisplayIndex].Value.ToString())
                    {                           
                        itemInTable = true;
                        break;
                    }
                }
                if (itemInTable)
                {
                    dataGridViewItems.Rows[r].Cells[ColumnКоличество.DisplayIndex].Value = (int.Parse(dataGridViewItems.Rows[r].Cells[ColumnКоличество.DisplayIndex].Value.ToString())+ int.Parse(textBoxCount.Text)).ToString();
                    sum+= (int.Parse(textBoxCount.Text)* int.Parse(dataGridViewItems.Rows[r].Cells[ColumnЦенаЗаЕдиницу.DisplayIndex].Value.ToString()));                    
                }
                else
                {


                    int lastRow = dataGridViewItems.RowCount;
                    dataGridViewItems.RowCount += 1;

                    dataGridViewItems.Rows[lastRow].Cells[ColumnOrderНомерМебели.DisplayIndex].Value = мебельDataGridView.Rows[furnitureRow].Cells[dataGridViewTextBoxColumnНомерМебели.DisplayIndex].Value;
                    dataGridViewItems.Rows[lastRow].Cells[ColumnНазваниеМебели.DisplayIndex].Value = мебельDataGridView.Rows[furnitureRow].Cells[dataGridViewTextBoxColumnНазвание.DisplayIndex].Value;
                    dataGridViewItems.Rows[lastRow].Cells[ColumnЦенаЗаЕдиницу.DisplayIndex].Value = мебельDataGridView.Rows[furnitureRow].Cells[dataGridViewTextBoxColumnЦенаЗаЕдиницу.DisplayIndex].Value;

                    
                    dataGridViewItems.Rows[lastRow].Cells[ColumnКоличество.DisplayIndex].Value = textBoxCount.Text;
                    sum += (int.Parse(dataGridViewItems.Rows[lastRow].Cells[ColumnКоличество.DisplayIndex].Value.ToString())
                        * int.Parse(dataGridViewItems.Rows[lastRow].Cells[ColumnЦенаЗаЕдиницу.DisplayIndex].Value.ToString()));                    
                }
                labelSum.Text = "Сумма заказа: " + sum.ToString() + " р.";
            }
            else
            {
                MessageBox.Show("Необходимо выбрать мебель");
            }
        }

        //Функция удаления мебели из заказа
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int row = -1;
            try
            {
                row = dataGridViewItems.CurrentCell.RowIndex;
            }
            catch { }
            if (row >= 0)
            {
                //MessageBox.Show(row.ToString());
                sum -= (int.Parse(dataGridViewItems.Rows[row].Cells[ColumnКоличество.DisplayIndex].Value.ToString())
                        * int.Parse(dataGridViewItems.Rows[row].Cells[ColumnЦенаЗаЕдиницу.DisplayIndex].Value.ToString()));
                labelSum.Text = "Сумма заказа: " + sum.ToString() + " р.";
                dataGridViewItems.Rows.RemoveAt(row);
            }
        }

        //Открытие новой формы для выбора клиента
        //и передача данных (мебель, количество, цена; номера столбцов)
        private void buttonDoOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.RowCount > 0)
            {
                Form_Add_Order_Enter_Client form_add_order_enter_client = new Form_Add_Order_Enter_Client(dataGridViewItems.Rows, ColumnOrderНомерМебели.DisplayIndex, ColumnНазваниеМебели.DisplayIndex, ColumnЦенаЗаЕдиницу.DisplayIndex, ColumnКоличество.DisplayIndex);
                form_add_order_enter_client.ShowDialog();
                if (form_add_order_enter_client.orderAdded)
                {
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Перед оформлением необхожимо выбрать мебель");
            }
        }
    }
}
