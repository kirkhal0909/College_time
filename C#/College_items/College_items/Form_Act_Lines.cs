using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace College_items
{
    public partial class Form_Act_Lines : Form
    {
        public Form_Act_Lines()
        {
            InitializeComponent();
        }

        private void строкаАктаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try { 
                this.Validate();
                this.строкаАктаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.oborudovanieDataSet);
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.ErrorCode);
                string msg = "Не удалось сохранить таблицу!\n";
                bool lastPartMsg = true;
                if (ex.Message.IndexOf("includes related records") >= 0)
                {
                    msg = msg + "Некоторые записи используются в других таблицах.\n";
                }
                else if (ex.Message.IndexOf("related record is required") >= 0)
                {
                    lastPartMsg = false;
                    msg = msg + "Не найдены коды объектов";
                }
                if (lastPartMsg)
                    msg = msg + "Таблица будет возвращена к исходному состоянию";
                MessageBox.Show(msg);
            }
        }

        private void Form_Act_Lines_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborudovanieDataSet.СтрокаАкта". При необходимости она может быть перемещена или удалена.
            this.строкаАктаTableAdapter.Fill(this.oborudovanieDataSet.СтрокаАкта);

        }

        private void актыКомплектацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Equipmnet_Acts fea = new Form_Equipmnet_Acts();
            fea.Show();
        }

        private void Form_Act_Lines_FormClosing(object sender, FormClosingEventArgs e)
        {
            строкаАктаBindingNavigatorSaveItem.PerformClick();
        }

        private void строкаАктаDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильный формат!");
        }
    }
}
