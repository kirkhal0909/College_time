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
    public partial class Form_Add_Item : Form
    {
        public Form_Add_Item()
        {
            InitializeComponent();
        }

        private void оборудованиеBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.оборудованиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oborudovanieDataSet);

        }

        private void Form_Add_Item_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborudovanieDataSet1.ТипОбор". При необходимости она может быть перемещена или удалена.
            this.типОборTableAdapter.Fill(this.oborudovanieDataSet1.ТипОбор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborudovanieDataSet1.Аудитории". При необходимости она может быть перемещена или удалена.
            this.аудиторииTableAdapter.Fill(this.oborudovanieDataSet1.Аудитории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oborudovanieDataSet.Оборудование". При необходимости она может быть перемещена или удалена.
            this.оборудованиеTableAdapter.Fill(this.oborudovanieDataSet.Оборудование);
            оборудованиеBindingSource.AddNew();
            //comboBoxAuditory.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            кодАудитTextBox.Text = comboBoxAuditory.SelectedValue.ToString();
            кодТипОборTextBox.Text = comboBoxItem.SelectedValue.ToString();
            оборудованиеBindingNavigatorSaveItem_Click_1(null,null);
            this.Close();
            MessageBox.Show("Оборудование добавлено");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.оборудованиеTableAdapter.FillBy(this.oborudovanieDataSet.Оборудование);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxAuditory_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxAuditory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                кодАудитTextBox.Text = comboBoxAuditory.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void кодТипОборLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAuditory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void кодАудитLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
