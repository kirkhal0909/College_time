using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace РасходТоплива
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
            this.записиTableAdapter.Fill(this.расход_топливаDataSet.Записи);			
            this.Font = new Font("Tahoma", 10, FontStyle.Regular);
			//В DataPicker ставим дату, которая сегодня
            dateTimePicker1.Value = DateTime.Now;
			//Делаем рассчёт из заданных параметров пользователем
            doSum();
        }

		//Функция сохранения данных
        private void записиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.записиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.расход_топливаDataSet);

        }

        private void записиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.записиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.расход_топливаDataSet);

        }

        Boolean block = false;
        
		//Событие на изменение текста в "Путь в городе"
        private void путь_в_городеTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!block)
            if (путь_в_городеTextBox.TextLength>0) //Если в поле есть текст
            {              
				//Блокируем событие в поле ввода "Путь на трассе"
                block = true;
                int s = int.Parse(путь_в_городеTextBox.Text);
					//Вычисляем проценты во втором поле
                    if (s < 100)
                        путь_на_трассеTextBox.Text = (100 - s).ToString();
                    else
                    {
                        путь_на_трассеTextBox.Text = "0";
                        (sender as TextBox).Text = "100";
                        (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                        s = 100;
                    }
            }
			//Разблокириуем события для дальнейшего изменения процента в противоположном поле ввода
            block = false;
			//Делаем рассчёт из заданных параметров пользователем
            doSum();         
        }

		//Такое же событие на изменение текста только в поле ввода "Путь на трассе"
        private void путь_на_трассеTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!block)
            if (путь_на_трассеTextBox.TextLength > 0)
            {
				//Блокируем событие в поле ввода "Путь в городе"
                block = true;
                int s = int.Parse(путь_на_трассеTextBox.Text);
					//Вычисляем проценты в другом поле
                    if (s < 100)
                        путь_в_городеTextBox.Text = (100 - s).ToString();
                    else
                    {
                        путь_в_городеTextBox.Text = "0";
                        (sender as TextBox).Text = "100";
                        (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                        s = 100;                        
                    }
            }
            //Разблокириуем события для дальнейшего изменения процента в противоположном поле ввода
            block = false;
			//Делаем рассчёт из заданных параметров пользователем
            doSum();
        }

		//Событие на нажатие клавиши
		//Разрешает вводить только числа(целые и дробные)
        private void км_в_путиTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (k < '0' || k > '9')
                if (k != 8)
                    if (k == '.')
                        e.KeyChar = ',';
                    else if (k != ',')
                        e.KeyChar = '\0';
                    
        }

		//Событие на нажатие клавиши
		//Разрешает вводить только целые числа
        private void путь_в_городеTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char k = e.KeyChar;
            if (k < '0' || k > '9')
                if (k != 8)
                        e.KeyChar = '\0';
        }

        private void км_в_путиTextBox_TextChanged(object sender, EventArgs e)
        {
			//Делаем рассчёт из заданных параметров пользователем
            doSum();
        }

        float path = 0;
        float rub = 0;
        float RashodGorod = 0;
        float RashodTrassa = 0;
        int PutTrassa = 0;
        int PutGorod = 0;

        double ToplivoGorod = 0;
        double ToplivoTrassa = 0;
        double KmGorod = 0;
        double KmTrassa = 0;

        double vsegoRub = 0;
        double vsegoTopliva = 0;
		
		//Рассчёт из заданных параметров пользователем
        private void doSum()
        {
            if (км_в_путиTextBox.TextLength > 0)
                path = float.Parse(км_в_путиTextBox.Text);
            else path = 0;

            if (руб_лTextBox.TextLength > 0)
                rub = float.Parse(руб_лTextBox.Text);
            else rub = 0;

            if (л_100км_в_городеTextBox.TextLength > 0)
                RashodGorod = float.Parse(л_100км_в_городеTextBox.Text);
            else RashodGorod = 0;

            if (л_100км_на_трассеTextBox.TextLength > 0)
                RashodTrassa = float.Parse(л_100км_на_трассеTextBox.Text);
            else RashodTrassa = 0;
            
            if (путь_на_трассеTextBox.TextLength > 0)
                PutTrassa = int.Parse(путь_на_трассеTextBox.Text);
            else PutTrassa = 0;
            
            if (путь_в_городеTextBox.TextLength > 0)
                PutGorod = int.Parse(путь_в_городеTextBox.Text);
            else PutGorod = 0;

            KmGorod = Math.Round((double)PutGorod / 100 * path,1);
            KmTrassa = path - KmGorod;

            ПроцентВГороде.Text = "% = " + KmGorod.ToString() + " км.";
            ПроцентНаТрассе.Text = "% = " + KmTrassa.ToString() + " км.";
            vsegoTopliva = Math.Round((RashodGorod / 100 * KmGorod) + (RashodTrassa / 100 * KmTrassa), 1);
            vsegoRub = Math.Round(rub*vsegoTopliva,2);

            labelVsego.Text = "Рассчёт: расход "+ vsegoTopliva.ToString() +" л. затраты "+ vsegoRub.ToString() +" руб.";
            //MessageBox.Show(path.ToString() + " = " + KmGorod.ToString() + "+" + KmTrassa.ToString());
            //MessageBox.Show(path.ToString() + " " + rub.ToString() + " " + RashodGorod.ToString() + " " + RashodTrassa.ToString() + " " + PutTrassa.ToString() + " " + PutGorod.ToString());
        }

		//Кнопка - Добавить рассчёт
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Добавляем новую запись
            записиBindingSource.AddNew();
            
			//Заносим данные в таблицу
            записиDataGridView[Дата.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = dateTimePicker1.Value.Date.ToString();
            записиDataGridView[Километров.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = path.ToString(); //+ " км."
            записиDataGridView[КилометровНаПоказ.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = path.ToString() + " км.";
            записиDataGridView[ЗатратыВгороде.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = RashodGorod.ToString();
            записиDataGridView[ЗатратыВгородеНаПоказ.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = RashodGorod.ToString() + " л. / 100 км.";
            записиDataGridView[затратыНаТрассе.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = RashodTrassa.ToString();
            записиDataGridView[затратыНаТрассеНаПоказ.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = RashodTrassa.ToString() + " л. / 100 км.";
            записиDataGridView[ПутьВГороде.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = PutGorod.ToString();// + " км.";
            записиDataGridView[ПутьВГородеНаПоказ.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = KmGorod.ToString() + " км.";// + " л. / 100 км.";
            записиDataGridView[ПутьНаТрассе.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = PutTrassa.ToString();// + " км.";
            записиDataGridView[ПутьНаТрассеНаПоказ.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = KmTrassa.ToString() + " км.";// + " л. / 100 км.";            
            записиDataGridView[Стоимость.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = rub.ToString();
            записиDataGridView[СтоимостьНаПоказ.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = rub.ToString() + " руб.";
            записиDataGridView[Цена.DisplayIndex, записиDataGridView.CurrentRow.Index].Value = vsegoRub.ToString()+" руб. / "+vsegoTopliva.ToString()+" л.";
        }

		//Сохраняем изменения в БД, после закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            записиBindingNavigatorSaveItem.PerformClick();
        }

		//Кнопка - Удалить все записи
        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (записиDataGridView.RowCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить все записи?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int r = записиDataGridView.RowCount - 1; r >= 0; r--)
                    {
                        записиBindingSource.RemoveAt(r);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }      
        }

        private void записиDataGridView_Sorted(object sender, EventArgs e)
        {
            //MessageBox.Show("Sort");
        }

        private void записиBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(записиBindingSource.Position.ToString());
        }        
		
		//Функция вычисления и добавления в таблице постфиксов: км. л. и так далее
        private void ShowInfo()
        {
            double sumC = 0, sumToplivoC = 0;
            for(int r = 0; r < записиDataGridView.RowCount;r++)
            {
                double kilom = 0;
                if (записиDataGridView[Километров.DisplayIndex, r].Value != null)
                {
                    kilom = double.Parse(записиDataGridView[Километров.DisplayIndex, r].Value.ToString());
                    записиDataGridView[КилометровНаПоказ.DisplayIndex, r].Value = записиDataGridView[Километров.DisplayIndex, r].Value.ToString() + " км.";
                }
                else записиDataGridView[КилометровНаПоказ.DisplayIndex, r].Value = "0 км.";

                if (записиDataGridView[ЗатратыВгороде.DisplayIndex, r].Value != null)
                    записиDataGridView[ЗатратыВгородеНаПоказ.DisplayIndex, r].Value = записиDataGridView[ЗатратыВгороде.DisplayIndex, r].Value.ToString() + " л. / 100 км.";
                else записиDataGridView[ЗатратыВгородеНаПоказ.DisplayIndex, r].Value = "0 л. / 100 км.";

                if (записиDataGridView[затратыНаТрассе.DisplayIndex, r].Value != null)
                    записиDataGridView[затратыНаТрассеНаПоказ.DisplayIndex, r].Value = записиDataGridView[затратыНаТрассе.DisplayIndex, r].Value.ToString() + " л. / 100 км.";
                else записиDataGridView[затратыНаТрассеНаПоказ.DisplayIndex, r].Value =  "0 л. / 100 км.";

                double put1 = 0, put2 = 0;
                if (записиDataGridView[ПутьВГороде.DisplayIndex, r].Value != null)
                {
                    put1 = Math.Round(Double.Parse(записиDataGridView[ПутьВГороде.DisplayIndex, r].Value.ToString()) / 100 * kilom,1);
                    put2 = kilom-put1;
                    записиDataGridView[ПутьВГородеНаПоказ.DisplayIndex, r].Value = put1.ToString() +" км.";
                }
                else записиDataGridView[ПутьВГородеНаПоказ.DisplayIndex, r].Value = "0 км.";// + " л. / 100 км.";

                if (записиDataGridView[ПутьНаТрассе.DisplayIndex, r].Value != null)
                {
                    if (put2 == 0) { put2 = Math.Round(Double.Parse(записиDataGridView[ПутьНаТрассе.DisplayIndex, r].Value.ToString()) / 100 * kilom,1); }
                    записиDataGridView[ПутьНаТрассеНаПоказ.DisplayIndex, r].Value = put2.ToString() + " км.";// + " л. / 100 км.";            
                }
                else записиDataGridView[ПутьНаТрассеНаПоказ.DisplayIndex, r].Value = "0 км.";// + " л. / 100 км.";

                if (записиDataGridView[Стоимость.DisplayIndex, r].Value != null)
                    записиDataGridView[СтоимостьНаПоказ.DisplayIndex, r].Value = записиDataGridView[Стоимость.DisplayIndex, r].Value.ToString() + " руб.";
                else записиDataGridView[СтоимостьНаПоказ.DisplayIndex, r].Value = "0 руб.";

                double KG = 0;
                KG = 0;
                if (записиDataGridView[ПутьВГороде.DisplayIndex, r].Value != null)
                    KG = double.Parse(записиDataGridView[ПутьВГороде.DisplayIndex, r].Value.ToString());
                double KT = 0;
                KT = 0;
                if (записиDataGridView[ПутьНаТрассе.DisplayIndex, r].Value != null)
                    KT = double.Parse(записиDataGridView[ПутьНаТрассе.DisplayIndex, r].Value.ToString());

                double RT = 0;
                RT = 0;
                if (записиDataGridView[затратыНаТрассе.DisplayIndex, r].Value != null)
                    RT = double.Parse(записиDataGridView[затратыНаТрассе.DisplayIndex, r].Value.ToString());

                double RG = 0;
                RG = 0;
                if (записиDataGridView[ЗатратыВгороде.DisplayIndex, r].Value != null)
                    RG = double.Parse(записиDataGridView[ЗатратыВгороде.DisplayIndex, r].Value.ToString());

                double Topliva, Rub;
                Topliva = Math.Round((RG / 100 * put1) + (RT / 100 * put2), 1);
                Rub = Math.Round(rub * Topliva, 2);
                sumC = sumC + Rub;
                sumToplivoC = sumToplivoC + Topliva;                

                записиDataGridView[Цена.DisplayIndex, r].Value = Rub.ToString() + " руб. / " + Topliva.ToString() + " л.";
            }
            labelCount.Text = "Всего расход " + sumToplivoC.ToString() + " л. затраты " + sumC.ToString() + " р.";
        }

        private void записиBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {            
            //MessageBox.Show(записиBindingSource.Position.ToString());
        }

        private void записиDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {            
        }

        private void записиDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            ShowInfo();
        }

		//Кнопка - Удалить выбранную запись
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(записиDataGridView.RowCount>0)
                записиBindingSource.RemoveCurrent();
        }
    }
}
