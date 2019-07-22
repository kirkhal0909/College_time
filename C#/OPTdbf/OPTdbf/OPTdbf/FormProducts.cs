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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            //Загружаем данные
            this.складTableAdapter.Fill(this.oPTDataSet.Склад);
            //Меняем шрифт
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
            //Нажимаем кнопку - добавить товар, если товаров в базе 0;
            if (складBindingSource.Count == 0) bindingNavigatorAddNewItem.PerformClick();
        }

        //Кнопка найти; поиск по тексту
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxText.SelectedIndex != -1)
            {
                складBindingSource.Position = складBindingSource.Find("ИД_товара", comboBoxText.SelectedValue.ToString());
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        //Разрешаем вводить только цифры, использовать BackSpace и Enter
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 13) buttonFindByID.PerformClick();
            if ((c<'0' || c>'9') && (c != 8))
                e.KeyChar = '\0';
        }

        //Кнопка поиск по ИД
        private void buttonFindByID_Click(object sender, EventArgs e)
        {
            if (textBoxID.TextLength > 0)
            {
                if (складBindingSource.Find("ИД_товара", textBoxID.Text) != -1)
                {
                    складBindingSource.Position = складBindingSource.Find("ИД_товара", textBoxID.Text);
                }
                else { MessageBox.Show("Товар с ИД - "+ textBoxID.Text+" не найден!"); }
            }
        }

        //Кнопка загрузить картинку; открытие файлового диалога
        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                изображение_товараPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        //Кнопка удалить картинку
        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            изображение_товараPictureBox.Image = null;
        }

        //Автоматическое сохранение данных во время закрытия формы
        private void FormProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.складBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oPTDataSet);
        }

        //Разрешаем вводить только цифры и использовать BackSpace
        private void количествоTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;            
            if ((c < '0' || c > '9') && (c != 8))
                e.KeyChar = '\0';
        }

        //Разрешаем вводить только цифры, точку, запятую и использовать BackSpace
        private void стоимостьTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == '.') { c = ','; e.KeyChar = ','; }
            if ((стоимостьTextBox.Text.IndexOf(",") != -1) && (c==',')) { e.KeyChar = '\0'; }
            if ((c < '0' || c > '9') && (c != 8) && (c != ','))
                e.KeyChar = '\0';
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        //Кнопка удалить; если осталось 0 товаров, то нажать автоматически - добавить товар
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (складBindingSource.Count == 0) bindingNavigatorAddNewItem.PerformClick();
        }
    }
}
