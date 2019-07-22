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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;            
            //Загружаем данные из БД
            this.валютыTableAdapter.Fill(this.кредитыDataSet.Валюты);                                    
            this.кредитыTableAdapter.Fill(this.кредитыDataSet.Кредиты);
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
            comboBoxChangeCredit.SelectedIndex = comboBoxChangeCredit.Items.Count-1;
            comboBoxPaymentType.SelectedIndex = 1;
            //comboBoxPaymentType.Width = textBoxEveryMonth.Width;
        }

        //Кнопка - Редактор
        private void редакторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Инициализируем новую форму
            FormEditCredits FEC = new FormEditCredits();
            //Прячем главную форму
            this.Hide();            
            int pos = кредитыBindingSource.Position;
            //Показываем новую форму и до её закрытия останавливаем выполнение кода в данной функции
            FEC.ShowDialog();            
            //После закрытия формы обновляем данные
            this.кредитыTableAdapter.Fill(this.кредитыDataSet.Кредиты);
            //MessageBox.Show(кредитыBindingSource.Count.ToString());
            if (кредитыBindingSource.Count-1>= pos)
                comboBoxChangeCredit.SelectedIndex = pos;
            else comboBoxChangeCredit.SelectedIndex = кредитыBindingSource.Count - 1;
            
            //Показываем главную форму             
            this.Show();
        }

        float interestRate = 0;
        int minSum = 0;
        int maxSum = 0;
        int minTerm = 0;
        int maxTerm = 0;
        float firstCommision = 0;
        float everyMonth = 0;

        //Загрузка шаблона. Функция для форматированного вывода информации об шаблоне
        private void comboBoxChangeCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Changed selecteditem");
            if (!closing)
            {
                кредитыBindingSource.Position = comboBoxChangeCredit.SelectedIndex;
                if (иД_валютыLabel1.Text.Length > 0)
                {
                    валютыBindingSource.Filter = "ИД_валюты=" + иД_валютыLabel1.Text;


                    //labelCurrency.BackColor = System.Drawing.Color.Transparent;
                    labelCurrency.Text = "Валюта:                        " + валютаLabel1.Text + " (" + код_буквенныйLabel1.Text + "-" + код_числовойLabel1.Text + ")";
                    String minSumStr = минимальная_суммаLabel1.Text;
                    String maxSumStr = максимальная_суммаLabel1.Text;
                    int minPoint = minSumStr.Length % 3;
                    StringBuilder sum = new StringBuilder("Допустимая сумма:        " + minSumStr[0]);
                    for (int i = 1; i < minSumStr.Length; i++)
                    {
                        if (i != minSumStr.Length - 1)
                        {
                            if ((i - minPoint) % 3 == 0)
                                sum = new StringBuilder(sum + ",");
                        }
                        sum = new StringBuilder(sum + minSumStr[i].ToString());
                    }
                    sum = new StringBuilder(sum + " " + код_буквенныйLabel1.Text + " - ");
                    int maxPoint = maxSumStr.Length % 3;
                    sum = new StringBuilder(sum + maxSumStr[0].ToString());
                    for (int i = 1; i < maxSumStr.Length; i++)
                    {
                        if (i != maxSumStr.Length - 1)
                        {
                            if ((i - maxPoint) % 3 == 0)
                                sum = new StringBuilder(sum + ",");
                        }
                        sum = new StringBuilder(sum + maxSumStr[i].ToString());
                    }
                    sum = new StringBuilder(sum + " " + код_буквенныйLabel1.Text);
                    labelAllowalablePrice.Text = sum.ToString();

                    labelAllowalableTerm.Text = "Доступный срок:           " + минимальный_срокLabel1.Text + " - " + максимальный_срокLabel1.Text + " мес.";

                    labelInterestRate.Text = "Процентная ставка:       " + процентная_ставкаLabel2.Text + "%";

                    labelFirstCommission.Text = "Разовая комиссия:         " + единовременная_комиссияLabel1.Text + "%";
                    labelEveryMonth.Text = "Ежемесячная комиссия:  " + ежемесячная_комиссияLabel1.Text + "%";

                    interestRate = float.Parse(процентная_ставкаLabel2.Text);
                    minSum = int.Parse(минимальная_суммаLabel1.Text);
                    maxSum = int.Parse(максимальная_суммаLabel1.Text);
                    minTerm = int.Parse(минимальный_срокLabel1.Text);
                    maxTerm = int.Parse(максимальный_срокLabel1.Text);
                    firstCommision = float.Parse(единовременная_комиссияLabel1.Text);
                    everyMonth = float.Parse(ежемесячная_комиссияLabel1.Text);

                    textBoxEditTerm.Text = минимальный_срокLabel1.Text;
                    textBoxEditSum.Text = минимальная_суммаLabel1.Text;
                    labelCalcCurrency.Text = код_буквенныйLabel1.Text;
                    textBoxInterestRate.Text = процентная_ставкаLabel2.Text;
                    textBoxFirstCommision.Text = единовременная_комиссияLabel1.Text;
                    textBoxEveryMonth.Text = ежемесячная_комиссияLabel1.Text;
                    
                }
            }
        }

        Boolean closing = false;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
        }

        //Проверка совпадения срока кредита с шаблоном
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length>0)
            {
                try
                {
                    int Term = int.Parse(textBoxEditTerm.Text);
                    if (Term<minTerm || Term>maxTerm)
                    {
                        labelAllowalableTerm.ForeColor = Color.Red;
                    } else { labelAllowalableTerm.ForeColor = Color.Black; }
                } catch(Exception ex)
                {

                }
            }
        }

        //Разрешение на ввод только цифр
        private void textBoxEditTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            var k = e.KeyChar;
            if (k < '0' || k > '9')
                if (k != 8)
                    e.KeyChar = '\0';
        }

        //Проверка совпадения суммы с шаблоном
        private void textBoxEditSum_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                try
                {
                    int sum = int.Parse(textBoxEditSum.Text);
                    if (sum < minSum || sum > maxSum)
                    {
                        labelAllowalablePrice.ForeColor = Color.Red;
                    }
                    else { labelAllowalablePrice.ForeColor = Color.Black; }
                }
                catch (Exception ex)
                {

                }
            }
        }

        //Разрешение ввода только чисел, точку и запятую
        private void textBoxInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            var k = e.KeyChar;
            if (k < '0' || k > '9')
            {
                if (k == '.') e.KeyChar = ',';
                if ((k != 8) && (k != '.') && (k != ','))
                    e.KeyChar = '\0';
                //if(k)
            }
        }

        //Проверка совпадения орцентной ставки с шаблоном
        private void textBoxInterestRate_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                try
                {
                    float rate = float.Parse(textBoxInterestRate.Text);
                    if (rate != interestRate)
                    {
                        labelInterestRate.ForeColor = Color.Red;
                    }
                    else { labelInterestRate.ForeColor = Color.Black; }
                }
                catch (Exception ex)
                {

                }
            }
        }

        //Проверка совпадения разовой комиссии с шаблоном
        private void textBoxFirstCommision_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                try
                {
                    float fc = float.Parse((sender as TextBox).Text);
                    if (fc != firstCommision)
                    {
                        labelFirstCommission.ForeColor = Color.Red;
                    }
                    else { labelFirstCommission.ForeColor = Color.Black; }
                }
                catch (Exception ex)
                {

                }
            }
        }

        //Проверка совпадения ежемесячной комиссии с шаблоном
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                try
                {
                    float em = float.Parse((sender as TextBox).Text);
                    if (em != everyMonth)
                    {
                        labelEveryMonth.ForeColor = Color.Red;
                    }
                    else { labelEveryMonth.ForeColor = Color.Black; }
                }
                catch (Exception ex)
                {

                }
            }
        }

        //Кнопка - Рассчитать
        private void buttonCalculate_Click(object sender, EventArgs e)
        {            
            Boolean isAnnuity = false;
            if (comboBoxPaymentType.SelectedIndex == 1)
                isAnnuity = true;
            //int term,int sum,float interestRate, float firstCommision, float everyMonth, Boolean isAnnuity

            /*float interestRate = 0;
        int minSum = 0;
        int maxSum = 0;
        int minTerm = 0;
        int maxTerm = 0;
        float firstCommision = 0;
        float everyMonth = 0;*/

            if (textBoxEditTerm.Text.Length < 1)
                if(minTerm == 0)
                    textBoxEditTerm.Text = "1";
                else
                    textBoxEditTerm.Text = minTerm.ToString();

            if (textBoxEditSum.Text.Length < 1)
                textBoxEditSum.Text = minSum.ToString();

            if (textBoxInterestRate.Text.Length < 1)
                textBoxInterestRate.Text = interestRate.ToString();

            if (textBoxFirstCommision.Text.Length < 1)
                textBoxFirstCommision.Text = firstCommision.ToString();

            if (textBoxEveryMonth.Text.Length < 1)
                textBoxEveryMonth.Text = everyMonth.ToString();

            int term = int.Parse(textBoxEditTerm.Text);
            int sum = int.Parse(textBoxEditSum.Text);
            float IR = float.Parse(textBoxInterestRate.Text);
            float FirstC = float.Parse(textBoxFirstCommision.Text);
            float everyM = float.Parse(textBoxEveryMonth.Text);
            string credit = comboBoxChangeCredit.SelectedValue.ToString();

            if (labelAllowalablePrice.ForeColor == Color.Red || labelAllowalableTerm.ForeColor == Color.Red
                || labelInterestRate.ForeColor == Color.Red || labelFirstCommission.ForeColor == Color.Red
                || labelEveryMonth.ForeColor == Color.Red)
                credit = "Индивидуальный";
            if (IR > 100 || FirstC > 100 || everyM > 100)
            {
                MessageBox.Show("Процентная ставка и комиссия не может быть больше 100%");
            }
            else
            {
                //Инициализируем новую форму и передаём значения из калькулятора            
                FormCalculator FC = new FormCalculator(term, sum, IR, FirstC, everyM, isAnnuity, credit, код_буквенныйLabel1.Text, dateTimePicker1.Value);
                //Открываем новую форму
                FC.Show();
            }
        }

        //Блокировка/разблокировка выбора даты
        private void comboBoxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as ComboBox).SelectedIndex==1)
            {
                label11.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                label11.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
        }
    }
}
