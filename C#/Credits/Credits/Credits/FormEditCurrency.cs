using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Credits
{
    public partial class FormEditCurrency : Form
    {
        public FormEditCurrency()
        {
            InitializeComponent();
        }

        private void FormEditCurrency_Load(object sender, EventArgs e)
        {
            //Загружаем данные из БД
            this.валютыTableAdapter.Fill(this.кредитыDataSet.Валюты);
            //Делаем размер объектов чуть больше
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }

        //Кнопка для загрузки изображения
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                изображениеPictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        //Сохранение изменённых данных после закрытия формы
        private void FormEditCurrency_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.валютыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.кредитыDataSet);
        }

        //Разрешение на ввод только цифр в поле для числового кода
        private void код_числовойTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var k = e.KeyChar;
            if (k<'0' || k>'9')
            {
                if(k != 8)
                    e.KeyChar = '\0';
            }
        }
    }
}
