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
    public partial class FormEditCredits : Form
    {
        public FormEditCredits()
        {
            InitializeComponent();
        }

        private void FormEditCredits_Load(object sender, EventArgs e)
        {
            //Загрузка данных из БД
            this.валютыTableAdapter.Fill(this.кредитыDataSet1.Валюты);           
            this.валютыTableAdapter.Fill(this.кредитыDataSet.Валюты);           
            this.кредитыTableAdapter.Fill(this.кредитыDataSet.Кредиты);
            //Делаем размер объектов чуть больше
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }

        //Функция сохранения в БД
        private void кредитыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.кредитыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.кредитыDataSet);

            int pos = кредитыBindingSource.Position;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кредитыDataSet1.Валюты". При необходимости она может быть перемещена или удалена.
            this.валютыTableAdapter.Fill(this.кредитыDataSet1.Валюты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кредитыDataSet.Валюты". При необходимости она может быть перемещена или удалена.
            this.валютыTableAdapter.Fill(this.кредитыDataSet.Валюты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кредитыDataSet.Кредиты". При необходимости она может быть перемещена или удалена.
            this.кредитыTableAdapter.Fill(this.кредитыDataSet.Кредиты);
            кредитыBindingSource.Position = pos;

        }

        //Поиск шаблона по названию, по первому символу
        private void кредитыDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Проходим по всем строчкам
            for(int r = 0;r<кредитыDataGridView.RowCount;r++)
            {   //Если значение в ячейке не пустое(во избежание программной ошибки!)
                if (кредитыDataGridView[DataGrid_название_кредита.DisplayIndex, r].Value != null)
                {   //и если первый символ совпал с нажатой клавишей
                    if(кредитыDataGridView[DataGrid_название_кредита.DisplayIndex, r].Value.ToString()[0] == e.KeyChar)
                    {   //Переводим выделение на найденную строку
                        кредитыBindingSource.Position = r;
                        break;
                    }
                }
            }
        }

        private void название_кредитаLabel_Click(object sender, EventArgs e)
        {

        }

        //Кнопка для добавления нового шаблона
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Активируем кнопку редактирования
            buttonEditCredit.Enabled = true;
            //Выполняем код, события данной кнопки
            buttonEditCredit.PerformClick();
        }

        //Кнопка - Редактор валют
        private void button1_Click(object sender, EventArgs e)
        {
            //Инициализируем новую форму
            FormEditCurrency FEC = new FormEditCurrency();
            //Прячем текущую форму
            this.Hide();
            //Открываем форму с редактором валют
            //И останавливаем выполнение последующих команд, до закрытия новой формы.
            FEC.ShowDialog();
            //После закрытия формы показываем основной редактор с кредитами
            this.Show();
            //Обновляем данные в основном редакторе
            this.валютыTableAdapter.Fill(this.кредитыDataSet1.Валюты);
            this.валютыTableAdapter.Fill(this.кредитыDataSet.Валюты);
            //int pos = кредитыBindingSource.Position;

        }

        //Кнопка удалить
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {       
            //Заблокировать правую часть, если она была разблокирована    
            panelEdit.Enabled = false;
            //Разблокировать кнопку редактировать, таблицу и кнопку для добавления шаблона
            if (кредитыBindingSource.Count>0)
                buttonEditCredit.Enabled = true;
            кредитыDataGridView.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            //кредитыBindingNavigatorSaveItem_Click(this, null);
        }

        //Кнопка - Редактировать выбранный кредит
        private void buttonEditCredit_Click(object sender, EventArgs e)
        {
            //Если есть шаблоны
            if (кредитыBindingSource.Count > 0)
            {   //Разрешаем редактировать пользователю в правой части формы
                panelEdit.Enabled = true;
                //Блокируем кнопку - Редактировать, таблицу и блокируем кнопку для добавления нового шаблона
                buttonEditCredit.Enabled = false;
                кредитыDataGridView.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            } else
            {   //Если шаблонов нет, то выводим сообщение пользователю
                MessageBox.Show("Нечего редактировать!");
            }
        }

        //Кнопка - Сохранить изменения
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Boolean next = true;
            string errorMsg = "";
            //Формируем сообщение ошибки, если пользователь ввёл не все данные, или ввёл их не корректно
            if(название_кредитаTextBox.Text.Length<1)
            {
                errorMsg = errorMsg + "Необходимо ввести название!\n";
                next = false;
            }

            if (процентная_ставкаTextBox.Text.Length < 1)
            {
                errorMsg = errorMsg + "Необходимо ввести процентную ставку!\n";
                next = false;
            } else
            {
                float пр_ст = float.Parse(процентная_ставкаTextBox.Text);
                if ((пр_ст < 0) || (пр_ст > 100))
                {
                    errorMsg = errorMsg + "Процентная ставка не может быть больше 100%!\n";
                    next = false;
                }
            }

            if (минимальный_срокTextBox.Text.Length < 1)
            {
                errorMsg = errorMsg + "Необходимо ввести минимальный срок!\n";
                next = false;
            }

            if (максимальный_срокTextBox.Text.Length < 1)
            {
                errorMsg = errorMsg + "Необходимо ввести максимальный срок!\n";
                next = false;
            } else
            {                
                if (минимальный_срокTextBox.Text.Length > 0)
                    if (int.Parse(минимальный_срокTextBox.Text) > int.Parse(максимальный_срокTextBox.Text))
                    {
                        errorMsg = errorMsg + "Минимальный срок должен быть меньше максимального срока, либо равен ему!\n";
                        next = false;
                    }
            }

            if (минимальная_суммаTextBox.Text.Length < 1)
            {
                errorMsg = errorMsg + "Необходимо ввести минимальную сумму!\n";
                next = false;
            }

            if (максимальная_суммаTextBox.Text.Length < 1)
            {
                errorMsg = errorMsg + "Необходимо ввести максимальную сумму!\n";
                next = false;
            }
            else
            {
                if (минимальная_суммаTextBox.Text.Length > 0)
                    if (int.Parse(минимальная_суммаTextBox.Text) > int.Parse(максимальная_суммаTextBox.Text))
                    {
                        errorMsg = errorMsg + "Минимальная сумма должна быть меньше максимальной суммы, либо равна ей!\n";
                        next = false;
                    }
            }

            if (валютаComboBox.SelectedIndex <0)
            {
                errorMsg = errorMsg + "Необходимо выбрать валюту!\n";
                next = false;
            }

            if (единовременная_комиссияTextBox.Text.Length < 1)
            {
                единовременная_комиссияTextBox.Text = "0";
            }
            else
            {
                float пр_ст = float.Parse(единовременная_комиссияTextBox.Text);
                if ((пр_ст < 0) || (пр_ст > 100))
                {
                    errorMsg = errorMsg + "Разовая комиссия не может быть больше 100%!\n";
                    next = false;
                }
            }

            if (ежемесячная_комиссияTextBox.Text.Length < 1)
            {
                ежемесячная_комиссияTextBox.Text = "0";
            }
            else
            {
                float пр_ст = float.Parse(ежемесячная_комиссияTextBox.Text);
                if ((пр_ст < 0) || (пр_ст > 100))
                {
                    errorMsg = errorMsg + "Ежемесячная комиссия не может быть больше 100%!\n";
                    next = false;
                }
            }

            //Если пользователь ввёл всё правильно, то сохраняем изменения и меняем блокировку объектов
            if (next)
            {
                panelEdit.Enabled = false;
                if (кредитыBindingSource.Count > 0)
                    buttonEditCredit.Enabled = true;
                кредитыDataGridView.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                кредитыBindingNavigatorSaveItem_Click(this, null);
            }
            else
            {   //Если пользователь ввёл что-то не так, то выводим ошибку
                MessageBox.Show(errorMsg);
            }
            /*this.Validate();
            this.кредитыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.кредитыDataSet);        

            int pos = кредитыBindingSource.Position;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кредитыDataSet1.Валюты". При необходимости она может быть перемещена или удалена.
            this.валютыTableAdapter.Fill(this.кредитыDataSet1.Валюты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кредитыDataSet.Валюты". При необходимости она может быть перемещена или удалена.
            this.валютыTableAdapter.Fill(this.кредитыDataSet.Валюты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "кредитыDataSet.Кредиты". При необходимости она может быть перемещена или удалена.
            this.кредитыTableAdapter.Fill(this.кредитыDataSet.Кредиты);
            кредитыBindingSource.Position = pos;*/
            
        }

        //Запрет закрытия формы, если пользователь редактирует кредит
        //Иначе делает сохранения, если некоторые записи были удаленны
        private void FormEditCredits_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (panelEdit.Enabled)
            {
                MessageBox.Show("Чтобы закрыть форму, необходимо сохранить изменения или удалить текущий кредит!");
                e.Cancel = true;
            } else { кредитыBindingNavigatorSaveItem_Click(this, null); }
        }

        //Разрешение на ввод только цифр, точки и запятой в поле процентной ставки
        private void процентная_ставкаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var k = e.KeyChar;
            if(k<'0' || k>'9')
            {
                if (k == '.') e.KeyChar = ',';
                if ((k != 8) && (k != '.') && (k != ','))
                    e.KeyChar = '\0';
                //if(k)
            }
        }

        //Разрешение на ввод только цифр в поле минимальной суммы
        private void минимальная_суммаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var k = e.KeyChar;
            if (k < '0' || k > '9')
            {
                if ((k != 8))
                    e.KeyChar = '\0';
                //if(k)
            }
        }
    }
}
