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
    public partial class FormOrderAdd : Form
    {
        public FormOrderAdd()
        {
            InitializeComponent();
        }

        private void FormOrderAdd_Load(object sender, EventArgs e)
        {
            //Загружаем данные
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Элементы_заказов". При необходимости она может быть перемещена или удалена.
            this.элементы_заказовTableAdapter.Fill(this.oPTDataSet.Элементы_заказов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Элементы_заказов". При необходимости она может быть перемещена или удалена.
            this.элементы_заказовTableAdapter.Fill(this.oPTDataSet.Элементы_заказов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.oPTDataSet.Заказы);            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.oPTDataSet.Склад);
            //Меняем шрифт
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
            //Добавляем новый заказ
            заказыBindingSource.AddNew();
        }

        //Разрешаем вводить в некоторых полях только цифры и BackSpace
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c < '0' || c > '9') && (c != 8))
                e.KeyChar = '\0';
        }
        //Сумма стоимость товаров
        float sum = 0;

        //Кнопка добавить
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxID.TextLength > 0)
            {   //Если ИД существует
                if (складBindingSource.Find("ИД_товара", textBoxID.Text) != -1)
                {   //Добавляем товар в другую таблицу                                     
                    int pos_item = складBindingSource.Find("ИД_товара", textBoxID.Text);
                    int countItems = int.Parse(складDataGridView[Количество.DisplayIndex, pos_item].Value.ToString());
                    if(textBoxCount.Text.Length>0)
                    if (countItems - int.Parse(textBoxCount.Text) >= 0)
                    {
                        float sum_item = float.Parse(складDataGridView[Стоимость.DisplayIndex, pos_item].Value.ToString()) * float.Parse(textBoxCount.Text);
                        sum += sum_item;
                        labelSum.Text = "Полная стоимость товаров: " + sum.ToString();

                        bool added = false;
                        int pos_added = -1;
                            //Проверяем есть ли товар уже во второй таблице
                        for(int r = 0;r<заказDataGridView.RowCount;r++)
                        {
                            if (заказDataGridView[ИД_товара_заказ.DisplayIndex,r].Value.ToString() == складDataGridView[ИД_товара.DisplayIndex, pos_item].Value.ToString())
                            {
                                added = true;
                                pos_added = r;                               
                                break;
                            }
                        }

                            складDataGridView[Количество.DisplayIndex, pos_item].Value = (countItems - int.Parse(textBoxCount.Text)).ToString();
                            //Если есть, то просто добавляем количество и меняем стоимость
                            if (added)
                            {
                                заказDataGridView[Количество_заказ.DisplayIndex, pos_added].Value = (int.Parse(заказDataGridView[Количество_заказ.DisplayIndex, pos_added].Value.ToString()) + int.Parse(textBoxCount.Text.ToString())).ToString();
                                заказDataGridView[Стоимость_заказ.DisplayIndex, заказDataGridView.RowCount - 1].Value = (int.Parse(заказDataGridView[Стоимость_заказ.DisplayIndex, заказDataGridView.RowCount - 1].Value.ToString()) +sum_item).ToString();
                            }
                        else
                        {   //Иначе добавляем новую строку
                            заказDataGridView.RowCount += 1;                            
                            заказDataGridView[ИД_товара_заказ.DisplayIndex, заказDataGridView.RowCount - 1].Value = складDataGridView[ИД_товара.DisplayIndex, pos_item].Value;
                            заказDataGridView[Товар_заказ.DisplayIndex, заказDataGridView.RowCount - 1].Value = складDataGridView[Товар.DisplayIndex, pos_item].Value;
                            заказDataGridView[Количество_заказ.DisplayIndex, заказDataGridView.RowCount - 1].Value = textBoxCount.Text;
                            
                            заказDataGridView[Стоимость_заказ.DisplayIndex, заказDataGridView.RowCount - 1].Value = (sum_item).ToString();

                        }
                    }
                    else if (countItems == 0) { MessageBox.Show("Товара нет на складе"); } else MessageBox.Show("Товара доступно только "+countItems.ToString());
                    //складBindingSource.Position = складBindingSource.Find("ИД_товара", textBoxID.Text);
                }
                else { MessageBox.Show("Товар с ИД - " + textBoxID.Text + " не найден!"); }
            }
        }

        //Меняем в поле ID при нажатии на ячейку в таблице
        private void складDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Text = складDataGridView[ИД_товара.DisplayIndex, складDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }

        //Кнопка удалить
        private void buttonDel_Click(object sender, EventArgs e)
        {
            bool inList = false;
            int pos_item = -1;
            if (textBoxIDRemove.TextLength > 0)
            {   //Ищем в таблице товар по ИД
                for (int r = 0; r < заказDataGridView.RowCount; r++)
                {   
                    if (заказDataGridView[ИД_товара_заказ.DisplayIndex, r].Value.ToString() == textBoxIDRemove.Text)
                    {
                        inList = true;
                        pos_item = r;
                        break;
                    }
                }
                if (inList) 
                {   //Если нашли, то удаляем, а количество обратно возвращаем на склад
                    float sum_delete = float.Parse(заказDataGridView[Стоимость_заказ.DisplayIndex,pos_item].Value.ToString());
                    int pos_in_storage = int.Parse(складBindingSource.Find("ИД_товара", заказDataGridView[ИД_товара_заказ.DisplayIndex, pos_item].Value.ToString()).ToString());
                    if (pos_in_storage != -1)
                        складDataGridView[Количество.DisplayIndex, pos_in_storage].Value = (int.Parse(складDataGridView[Количество.DisplayIndex, pos_in_storage].Value.ToString()) +int.Parse(заказDataGridView[Количество_заказ.DisplayIndex, pos_item].Value.ToString())).ToString();
                    заказDataGridView.Rows.RemoveAt(pos_item);
                    sum -= sum_delete;
                    labelSum.Text = "Полная стоимость товаров: " + sum.ToString();
                }
                else MessageBox.Show("Товар с ИД - " + textBoxIDRemove.Text + " не найден!");
            }
        }

        //Кнопка сохранить заказ
        private void button1_Click(object sender, EventArgs e)
        {
            if (заказDataGridView.RowCount < 1) { MessageBox.Show("Сначало необходимо добавить хотя бы один товар!"); }
            else
            {  
                дата_заказаTextBox.Text = DateTime.Now.ToString();
                //Сохраняем таблицы, чтобы получить ИД нового заказа
                this.Validate();
                this.заказыBindingSource.EndEdit();
                this.складBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.oPTDataSet);
                this.заказыTableAdapter.Fill(this.oPTDataSet.Заказы);
                int pos_last = 0;
                int max = 0;
                //Ищем ИД нового заказа
                for(int pos = 0;pos<заказыBindingSource.Count;pos++)
                {
                    заказыBindingSource.Position = pos;
                    if(int.Parse(иД_заказаTextBox.Text)>max)
                    {
                        max = int.Parse(иД_заказаTextBox.Text);
                        pos_last = pos;
                    }
                }
                заказыBindingSource.Position = pos_last;
                
                //Заносим выбранные продукты в базу данных
                for (int r = 0; r < заказDataGridView.RowCount; r++)
                {
                    элементы_заказовBindingSource.AddNew();
                    иД_заказаTextBox1.Text = max.ToString();
                    иД_товараTextBox.Text = заказDataGridView[ИД_товара_заказ.DisplayIndex, r].Value.ToString();
                    количествоTextBox.Text = заказDataGridView[Количество_заказ.DisplayIndex, r].Value.ToString();

                    int pos_item = складBindingSource.Find("ИД_товара", иД_товараTextBox.Text);

                    стоимостьTextBox.Text = складDataGridView[Стоимость.DisplayIndex, pos_item].Value.ToString();
                    товарTextBox.Text = заказDataGridView[Товар_заказ.DisplayIndex, r].Value.ToString();
                }
                //Сохраняем
                this.элементы_заказовBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.oPTDataSet);

                MessageBox.Show("Заказ сохранён под номером №" + иД_заказаTextBox.Text + "\n" + labelSum.Text);
                this.Close();
            }

        }

        //Меняем в поле ID при нажатии на ячейку в таблице
        private void заказDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxIDRemove.Text = заказDataGridView[ИД_товара_заказ.DisplayIndex, заказDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch { }
        }
    }
}
