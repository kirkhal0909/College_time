using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Credits
{
    public partial class FormCalculator : Form
    {
        public FormCalculator(int term,int sum,float interestRate, float firstCommision, float everyMonth, Boolean isAnnuity, string credit, string currency, DateTime dateStart)
        {            
            InitializeComponent();   
            //Загружаем данные в форму         
            labelCredit.Text = "Кредит: " + credit;
            globalCredit = credit;
            globalTerm = term;
            globalSum = sum;
            globalInterestRate = interestRate;
            globalFirstCommision = firstCommision;
            globalEveryMonth = everyMonth;
            globalIsAnnuity = isAnnuity;
            globalCurrency = currency;
            globaldateStart = dateStart;
        }

        string globalCredit = "Индивидуально";
        int globalTerm = 0;
        int globalSum = 0;
        float globalInterestRate = 0;
        float globalFirstCommision = 0;
        float globalEveryMonth = 0;
        Boolean globalIsAnnuity = true;
        string globalCurrency = "у. е.";
        DateTime globaldateStart = DateTime.Now;

        //Функция для выполнения рассчётов и вывода информации
        private void FormCalculator_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Tahoma", 12, FontStyle.Regular);
            double i = globalInterestRate / 12 / 100;
            int n = globalTerm;
            int S = globalSum;
            double K = (i * Math.Pow(1 + i, n))/(Math.Pow(1+i,n)-1);
            double A = Math.Round(K * S,1);
            double first = Math.Round((globalFirstCommision /100) * globalSum + (globalEveryMonth / 100) * globalSum + A,1);
            double following = Math.Round((globalEveryMonth / 100) * globalSum + A,1);
            double debt = (following * (globalTerm - 1));

            string formatedSum = globalSum.ToString();
            int minPoint = formatedSum.Length % 3;
            StringBuilder sum = new StringBuilder(formatedSum[0].ToString());
            for (int j = 1; j < formatedSum.Length; j++)
            {
                if (j != formatedSum.Length - 1)
                {
                    if ((j - minPoint) % 3 == 0)
                        sum = new StringBuilder(sum + ",");
                }
                sum = new StringBuilder(sum + formatedSum[j].ToString());
            }
            formatedSum = sum.ToString();


            labelInfo.Text = "Срок кредита:              " + globalTerm.ToString() + " мес." + "\r\nСумма кредита:            " + formatedSum + " " + globalCurrency + "\r\nПроцентная ставка:      " + globalInterestRate.ToString() + "%"+"\r\nРазовая комиссия:        "+ globalFirstCommision.ToString()+"%" +"\r\nЕжемесечная комиссия: "+ globalEveryMonth+"%" +"\r\n\r\n" ;
            if (globalIsAnnuity)
            {
                if (globalFirstCommision == 0)
                {
                    debt = debt + following;
                    labelInfo.Text = labelInfo.Text + "Ежемесячный платёж: " + Math.Round(following).ToString() + " " + globalCurrency;
                }
                else
                {
                    debt = debt + first;
                    labelInfo.Text = labelInfo.Text + "Платёж в первом месяце: " + Math.Round(first).ToString() + " " + globalCurrency + "\r\nПлатёж в последующих месяцах: " + Math.Round(following).ToString() + " " + globalCurrency;
                }
                labelInfo.Text = labelInfo.Text + "\r\nВсего необходимо вернуть: " + Math.Round(debt).ToString() + " " + globalCurrency;

                this.Width = labelInfo.Width + 20;
                this.Height = labelInfo.Top + labelInfo.Height + 50;
            } else
            {
                dataGridViewInfo.Visible = true;
                float tmp = globalSum / globalTerm;
                int body = (int)Math.Round(tmp);
                int monthCalc = globaldateStart.Month;                
                int yearCalc = globaldateStart.Year;
                int sumCalc = globalSum;
                double tmpSum = 0;
                //double full = 0;
                for (int m = 1;m<=globalTerm;m++)
                {
                    dataGridViewInfo.RowCount = dataGridViewInfo.RowCount + 1;
                    //string fullMonthName = CultureInfoConverter.
                    //DateTimeFormatInfo.CurrentInfo.MonthNames[index];
                    string monthInfo = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthCalc) +", " + yearCalc.ToString();
                    string Payment = Math.Round((body + (globalEveryMonth / 100) * globalSum + (sumCalc * (globalInterestRate / 100) / 365 * System.DateTime.DaysInMonth(yearCalc, monthCalc)))).ToString();
                    if (m == 1)
                        Payment = Math.Round(float.Parse(Payment) + Math.Round((globalFirstCommision / 100) * globalSum)).ToString();
                    tmpSum += double.Parse(Payment);
                    //full = full + double.Parse(Payment) / Math.Pow(1 + (globalInterestRate/100), globalTerm-m+1);

                    minPoint = Payment.Length % 3;
                    sum = new StringBuilder(Payment[0].ToString());
                    for (int j = 1; j < Payment.Length; j++)
                    {
                        if (j != Payment.Length - 1)
                        {
                            if ((j - minPoint) % 3 == 0)
                                sum = new StringBuilder(sum + ",");
                        }
                        sum = new StringBuilder(sum + Payment[j].ToString());
                    }
                    //MessageBox.Show(sum.ToString());
                    sum = new StringBuilder(sum + " " + globalCurrency);
                    Payment = sum.ToString();

                    sumCalc -= body;                    
                    dataGridViewInfo[Месяц.DisplayIndex, dataGridViewInfo.RowCount - 1].Value = monthInfo;
                    dataGridViewInfo[Сумма_платежа.DisplayIndex, dataGridViewInfo.RowCount - 1].Value = Payment;
                    monthCalc = monthCalc + 1;
                    if(monthCalc>12)
                    {
                        monthCalc = 1;
                        yearCalc += 1;
                    }
                }
                //MessageBox.Show(full.ToString());
                labelInfo.Text = labelInfo.Text + "Всего необходимо вернуть: " + tmpSum.ToString() + " " + globalCurrency;

                if(labelInfo.Width + 20>this.Width)
                {
                    this.Width = labelInfo.Width + 20;
                }
                if(labelCredit.Width +20 > this.Width)
                {
                    this.Width = labelCredit.Width + 20;
                }
                //MessageBox.Show(tmpSum.ToString());
                //while(S>0)
            }
            
           // labelInfo.Text = ""
            //MessageBox.Show((A*n).ToString());
        }

        //Экспорт данных
        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Кредит "+globalCredit+".txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(save.FileName);
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.WriteLine(labelCredit.Text);
                    writer.Write(labelInfo.Text);                    
                    if(dataGridViewInfo.Visible)
                    {
                        string tmp = "";
                        writer.Write("\r\n\r\nМесяц; Сумма платежа");
                        for(int r = 0;r<dataGridViewInfo.RowCount;r++)
                        {
                            tmp = "\r\n";
                            tmp = tmp + dataGridViewInfo[Месяц.DisplayIndex, r].Value.ToString();
                            tmp = tmp + "; ";
                            tmp = tmp + dataGridViewInfo[Сумма_платежа.DisplayIndex, r].Value.ToString();
                            writer.Write(tmp);                          
                        }
                    }
                    writer.Close();
                    //writer.Write("test1\ntest2\ntest3");
                }
            }
        }
    }
}
