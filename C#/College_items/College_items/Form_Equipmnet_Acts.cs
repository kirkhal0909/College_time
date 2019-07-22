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
    public partial class Form_Equipmnet_Acts : Form
    {
        public Form_Equipmnet_Acts()
        {
            InitializeComponent();
        }

        private void актКомплектацииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try { 
                this.Validate();
                this.актКомплектацииBindingSource.EndEdit();
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

        private void Form_Equipmnet_Acts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborudovanieDataSet.АктКомплектации". При необходимости она может быть перемещена или удалена.
            this.актКомплектацииTableAdapter.Fill(this.oborudovanieDataSet.АктКомплектации);

        }

        private void Form_Equipmnet_Acts_FormClosing(object sender, FormClosingEventArgs e)
        {
            актКомплектацииBindingNavigatorSaveItem.PerformClick();
        }

        private void актКомплектацииDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильный формат!");
        }
    }
}
