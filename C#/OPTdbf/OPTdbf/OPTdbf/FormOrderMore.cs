using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OPTdbf
{
    public partial class FormOrderMore : Form
    {
        string ID_order="0";
        public FormOrderMore(string ID_ord)
        {
            ID_order = ID_ord;
            InitializeComponent();
        }

        float Pr = 0; //Сумма стоимости товаров
        //Функция для вычисления стоимости
        private void GetPrice()
        {
            Pr = 0;
            for(int i =0;i<запрос_Элементы_заказовDataGridView.RowCount;i++)
            {
                Pr = Pr + float.Parse(запрос_Элементы_заказовDataGridView[цена.DisplayIndex, i].Value.ToString());
            }
        }

        private void FormOrderMore_Load(object sender, EventArgs e)
        {
            //Загружаем данные
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.oPTDataSet.Заказы);            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oPTDataSet.Запрос_Элементы_заказов". При необходимости она может быть перемещена или удалена.
            this.запрос_Элементы_заказовTableAdapter.Fill(this.oPTDataSet.Запрос_Элементы_заказов);
            //Меняем шрифт
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
            //Загружаем товары только в выделенном заказе
            запрос_Элементы_заказовBindingSource.Filter = "ИД_заказа=" +ID_order;
            this.Text = "Заказ №" + ID_order;
            //Вычисляем сумму
            GetPrice();
            //Информируем пользователя
            labelOrder.Text = "Заказ №"+ID_order+" на сумму "+Pr.ToString();
            заказыBindingSource.Filter = "ИД_заказа=" + ID_order;
        }

        //Кнопка сохранить в файл
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Делаем файловый диалог
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.Filter = "Заказ|*.txt";
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {   //Записываем всю информацию о заказе
                string filename = saveFileDialog.FileName;
                //MessageBox.Show(filename);                
                string phone = заказыDataGridView[телефон.DisplayIndex, 0].Value.ToString();
                string e_mail = заказыDataGridView[email.DisplayIndex, 0].Value.ToString();
                string address = заказыDataGridView[адрес.DisplayIndex, 0].Value.ToString();
                string date = заказыDataGridView[дата.DisplayIndex, 0].Value.ToString();
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine("\tЗаказ №"+ID_order);
                    if (phone.Length > 0) writer.WriteLine("Телефон:\t\t"+phone);
                    if (e_mail.Length > 0) writer.WriteLine("E-mail:\t\t\t" + e_mail);
                    if (address.Length > 0) writer.WriteLine("Адрес:\t\t\t" + address);
                    if (date.Length > 0) writer.WriteLine("Дата и время заказа:\t" + date);                    
                    writer.WriteLine("Стоимость товаров:\t"+Pr.ToString());
                    writer.WriteLine();
                    writer.WriteLine(ИД_товара.HeaderText+"; "+Товар.HeaderText + "; " +количество.HeaderText + "; " +цена.HeaderText);

                    for(int r = 0;r<запрос_Элементы_заказовDataGridView.RowCount;r++)
                    {
                        string ID_item = запрос_Элементы_заказовDataGridView[ИД_товара.DisplayIndex, r].Value.ToString();
                        string item_name = запрос_Элементы_заказовDataGridView[Товар.DisplayIndex, r].Value.ToString();
                        string count = запрос_Элементы_заказовDataGridView[количество.DisplayIndex, r].Value.ToString();
                        string price = запрос_Элементы_заказовDataGridView[цена.DisplayIndex, r].Value.ToString();
                        writer.WriteLine(ID_item+";"+item_name + ";" +count + ";" +price);
                    }
                }
                //save file using stream.
            }
        }
    }
}
