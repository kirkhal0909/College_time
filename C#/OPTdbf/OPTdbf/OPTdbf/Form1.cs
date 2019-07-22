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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Загружаем данные
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.oPTDataSet.Склад);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.oPTDataSet.Склад);
            //Меняем шрифт объектов
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
            //Меняем положение формы
            this.Left = (SystemInformation.VirtualScreen.Width - this.Width) / 2;
            this.Top = (SystemInformation.VirtualScreen.Height - this.Height) / 2;// -100;
        }

        private void редактироватьТоварыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Генерируем форму для редактирования продуктов
            FormProducts fp = new FormProducts();
            //Сохраняем текущую позицию в таблице
            int pos = складBindingSource.Position;
            //Прячем основную форму
            this.Hide();
            //Открываем форму
            fp.ShowDialog();
            //После закрытия второй формы, снова показываем основную
            this.Show();
            //После закрытия обновляем данные в таблице
            this.складTableAdapter.Fill(this.oPTDataSet.Склад);
            //И возвращаем нашу выделенную позицию
            if (pos + 1 > складBindingSource.Count)
                pos = складBindingSource.Count - 1;
            складBindingSource.Position = pos;
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            //Генерируем форму заказов   
            FormOrders fo = new FormOrders();
            //Сохраняем текущую позицию в таблице
            int pos = складBindingSource.Position;
            //Прячем основную форму
            this.Hide();
            //Открываем форму
            fo.ShowDialog();
            //После закрытия второй формы, снова показываем основную
            this.Show();
            //После закрытия обновляем данные в таблице
            this.складTableAdapter.Fill(this.oPTDataSet.Склад);
            //И возвращаем нашу выделенную позицию
            складBindingSource.Position = pos;
        }
    }
}
