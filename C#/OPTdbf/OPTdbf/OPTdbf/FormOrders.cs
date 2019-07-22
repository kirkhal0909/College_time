using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OPTdbf
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            //Загружаем данные
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.oPTDataSet.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Элементы_заказов". При необходимости она может быть перемещена или удалена.
            this.элементы_заказовTableAdapter.Fill(this.oPTDataSet.Элементы_заказов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.oPTDataSet.Заказы);
            //Меняем шрифт
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }

        //Открываем форму и загружаем товары заказа
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxID.TextLength > 0)
            {
                if (заказыBindingSource.Find("ИД_заказа", textBoxID.Text) != -1)
                {
                    FormOrderMore fom = new FormOrderMore(textBoxID.Text);
                    fom.ShowDialog();
                    //заказыBindingSource.Position = заказыBindingSource.Find("ИД_товара", textBoxID.Text);
                }
                else { MessageBox.Show("Заказ с ИД - " + textBoxID.Text + " не найден!"); }
            }

            /*if (заказыBindingSource.Count>0)
            {
                FormOrderMore fom = new FormOrderMore(заказыDataGridView.CurrentRow.Cells[ИД_заказа.DisplayIndex].Value.ToString());
                fom.ShowDialog();
            }*/
        }

        //Открываем форму для добавления заказа и после закрытия формы
        //обновляем данные в таблице и возвращаем позицию выделенной ячейки
        private void button2_Click(object sender, EventArgs e)
        {
            FormOrderAdd foa = new FormOrderAdd();
            int pos = заказыBindingSource.Position;        
            foa.ShowDialog();       
            this.заказыTableAdapter.Fill(this.oPTDataSet.Заказы);
            this.элементы_заказовTableAdapter.Fill(this.oPTDataSet.Элементы_заказов);
            this.складTableAdapter.Fill(this.oPTDataSet.Склад);
            заказыBindingSource.Position = pos;
        }

        //Разрешаем вводить только цифры и BackSpace
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 13) buttonLookItems.PerformClick();
            if ((c < '0' || c > '9') && (c != 8))
                e.KeyChar = '\0';
        }

        private void заказыDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //При выделении ячейки в таблице, подставляем ID в поле ввода
        private void заказыDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = заказыDataGridView[ИД_заказа.DisplayIndex, заказыDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }

        //Кнопка удалить заказ
        private void buttonDelete_Click(object sender, EventArgs e)
        {            
            if (textBoxID.TextLength > 0)
            {
                if (заказыBindingSource.Find("ИД_заказа", textBoxID.Text) != -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить заказ №"+ textBoxID.Text+" ?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        элементы_заказовBindingSource.Filter = "ИД_заказа=" + textBoxID.Text;
                        for(int r= элементы_заказовBindingSource.Count-1; r>=0;r--)
                        {   //Удаляем товары из таблицы и заносим количество обратно в склад
                            элементы_заказовBindingSource.Position = r;
                            string id_item = элементы_заказовDataGridView.CurrentRow.Cells[ИД_товара_элемент.DisplayIndex].Value.ToString();
                            int count_item = int.Parse(элементы_заказовDataGridView.CurrentRow.Cells[Количество_элемент.DisplayIndex].Value.ToString());
                            int pos_item = складBindingSource.Find("ИД_товара", элементы_заказовDataGridView[ИД_товара_элемент.DisplayIndex,r].Value.ToString());
                            if (pos_item != -1)
                            {
                                int full_items = int.Parse(складDataGridView[Количество_склад.DisplayIndex, pos_item].Value.ToString())+count_item;

                                складDataGridView[Количество_склад.DisplayIndex, pos_item].Value = full_items.ToString();
                                
                            }
                            элементы_заказовBindingSource.RemoveCurrent();
                        }
                        //Удаляем запись заказа из таблицы заказы
                        заказыBindingSource.RemoveAt(заказыBindingSource.Find("ИД_заказа", textBoxID.Text));
                        //Сохраняем данные
                        this.Validate();
                        this.заказыBindingSource.EndEdit();
                        this.элементы_заказовBindingSource.EndEdit();
                        this.складBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.oPTDataSet);

                        //Обновляем данные
                        this.складTableAdapter.Fill(this.oPTDataSet.Склад);
                        this.элементы_заказовTableAdapter.Fill(this.oPTDataSet.Элементы_заказов);
                        this.заказыTableAdapter.Fill(this.oPTDataSet.Заказы);
                    }
                }
                else { MessageBox.Show("Заказ с ИД - " + textBoxID.Text + " не найден!"); }
            }
        }
    }
}
