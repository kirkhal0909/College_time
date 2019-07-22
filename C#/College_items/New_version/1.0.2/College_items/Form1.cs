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
    public partial class Form1 : Form
    {
        //Функция по умолчанию созданная средой MVS
        //создана для инициализации объекта - форма
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка сохранить
        private void аудиторииBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {   //Сохранить изменения в БД
                this.Validate();
                this.аудиторииBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.oborudovanieDataSet);
            }
            catch (System.Data.OleDb.OleDbException ex)
            {   //Если не удалось сохранить, выводим информативное сообщение сообщение
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.ErrorCode);
                string msg = "Не удалось сохранить таблицу!\n";
                bool lastPartMsg = true;
                if (ex.Message.IndexOf("includes related records") >= 0)
                {
                    msg = msg + "Некоторые записи используются в других таблицах.\n";
                } else if(ex.Message.IndexOf("related record is required")>=0)
                {
                    lastPartMsg = false;
                    msg = msg + "Не найдены коды объектов";
                }
                if (lastPartMsg)
                    msg = msg + "Таблица будет возвращена к исходному состоянию";
                MessageBox.Show(msg);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Загрузка данных из БД при загрузке формы            
            this.аудиторииTableAdapter.Fill(this.oborudovanieDataSet.Аудитории);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {           
            //Сохранение изменений в БД после закрытия формы 
            аудиторииBindingNavigatorSaveItem.PerformClick();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Открыть форму сотрудники
            FormPersonal fp = new FormPersonal();
            fp.Show();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Открыть форму оборудование
            Form_Items fi = new Form_Items();
            fi.Show();
        }

        private void аудиторииDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {   //Вывести ошибку при вводе неправильного типа данных
            //Например: ввод текста, когда поле числового типа;
            //  Или ввод числа, когда поле типа - дата
            MessageBox.Show("Неправильный формат!");
        }
    }
}
