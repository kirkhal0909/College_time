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
    public partial class Form_Clients : Form
    {
        public Form_Clients()
        {
            InitializeComponent();
        }
        //Сохранение таблицы клиентов в базу данных
        private void saveClientsTable()
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ordersDataSet);

        }
        //Загрузка данных из базы данных при открытии формы
        private void Form_Clients_Load(object sender, EventArgs e)
        {            
            this.клиентыTableAdapter.Fill(this.ordersDataSet.Клиенты);
        }
        //Кнопка - Удалить клиента
        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {            
            //категорииDataGridView.Rows.RemoveAt(категорииDataGridView.SelectedRows[0].Index);
            if (клиентыBindingSource.Position >= 0)
            {                
                    int position_client_remove = клиентыBindingSource.Position;
                    this.клиентыTableAdapter.Fill(this.ordersDataSet.Клиенты);
                    клиентыBindingSource.RemoveAt(position_client_remove);
                    try
                    {
                        saveClientsTable();
                    }
                    catch
                    {
                        this.клиентыTableAdapter.Fill(this.ordersDataSet.Клиенты);
                        MessageBox.Show("Невозможно удалить из-за связей");                        
                    }
            }                                   
        }
        //Добавление/редактирование клиента
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string input_FIO = textBoxClientFIO.Text;
            string input_address = textBoxClientAddress.Text;
            string input_phone = textBoxClientPhone.Text;
            if (input_FIO.Length == 0)
            {
                MessageBox.Show("Введите фамилию, имя и отчество клиента");
            }            
            else
            {
                if (editNowClient)
                {                    
                        this.клиентыTableAdapter.Fill(this.ordersDataSet.Клиенты);

                        клиентыDataGridView.Rows[editNowClientPosition].Cells[dataGridViewTextBoxColumnClientFIO.DisplayIndex].Value = input_FIO;
                        клиентыDataGridView.Rows[editNowClientPosition].Cells[dataGridViewTextBoxColumnClientAddress.DisplayIndex].Value = input_address;
                        клиентыDataGridView.Rows[editNowClientPosition].Cells[dataGridViewTextBoxColumnClientPhone.DisplayIndex].Value = input_phone;
                    
                        saveClientsTable();
                        editClient();                    
                }
                else
                {
                    клиентыBindingSource.AddNew();
                    клиентыDataGridView.Rows[клиентыDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnClientFIO.DisplayIndex].Value = input_FIO;
                    клиентыDataGridView.Rows[клиентыDataGridView.RowCount - 1].Cells[dataGridViewTextBoxColumnClientAddress.DisplayIndex].Value = input_address;
                    клиентыDataGridView.Rows[клиентыDataGridView.RowCount-1].Cells[dataGridViewTextBoxColumnClientPhone.DisplayIndex].Value = input_phone;

                    saveClientsTable();
                    textBoxClientFIO.Text = "";
                    textBoxClientAddress.Text = "";
                    textBoxClientPhone.Text = "";
                }
            }
        }


        private bool editNowClient = false;
        private int editNowClientPosition = -1;

        //Переключатель кнопок для редактирования клиента
        private void editClient()
        {
            if (buttonEditClient.Enabled)
            {
                buttonAddClient.Text = "Редактировать";
                editNowClientPosition = клиентыBindingSource.Position;
                textBoxClientFIO.Text = клиентыDataGridView.Rows[editNowClientPosition].Cells[dataGridViewTextBoxColumnClientFIO.DisplayIndex].Value.ToString();
                textBoxClientAddress.Text = клиентыDataGridView.Rows[editNowClientPosition].Cells[dataGridViewTextBoxColumnClientAddress.DisplayIndex].Value.ToString();
                textBoxClientPhone.Text = клиентыDataGridView.Rows[editNowClientPosition].Cells[dataGridViewTextBoxColumnClientPhone.DisplayIndex].Value.ToString();
                editNowClient = true;
            }
            else
            {
                buttonAddClient.Text = "Добавить клиента";
                textBoxClientFIO.Text = "";
                textBoxClientAddress.Text = "";
                textBoxClientPhone.Text = "";
                editNowClient = false;
                editNowClientPosition = -1;
            }

            buttonEditClient.Enabled = !buttonEditClient.Enabled;
            buttonRemoveClient.Enabled = !buttonRemoveClient.Enabled;
        }
        //Кнопка - Редактировать клиента
        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (клиентыBindingSource.Count>0)
            {
                editClient();
            }
        }
    }
}
