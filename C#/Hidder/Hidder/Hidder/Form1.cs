using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Hidder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ParamsSaver ps = new ParamsSaver();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Если есть доступ к файлам, то загружаем последние данные пользователя
            if (ps.getAccessStatus())
            {
                tabControlMain.SelectTab(ps.getEnteredPage());
                textBoxMainPath.Text = ps.getFileWhereHide();
                radioButtonHideFolder.Checked = ps.getEnteredHideDirectory();
                textBoxHideFiles.Text = ps.getPathToHide();
                checkBoxHideWithPassword.Checked = ps.getSelectedUserPasswordToHide();
                textBoxPasswordToHide.Text = ps.getUserPasswordToHide();

                textBoxFile.Text = ps.getFileWhereHided();
                textBoxPathExtract.Text = ps.getPathToExtract();
                checkBoxExtractWithPassword.Checked = ps.getSelectedUserPasswordToExtract();
                textBoxPasswordToExtract.Text = ps.getUserPasswordToExtract();
            }
            //Visual Studio имеет некоторые баги с размерами
            //Поэтому меняем размер и позицию некоторых объектов
            buttonChangeMainPath.Height = textBoxMainPath.Height + 2;
            buttonChangeMainPath.Top--;
            buttonChangeHidePath.Height = textBoxHideFiles.Height + 2;
            buttonChangeHidePath.Top--;
            buttonPathToFile.Height = textBoxFile.Height + 2;
            buttonPathToFile.Top--;
            buttonWhereExtract.Height = textBoxPathExtract.Height + 2;
            buttonWhereExtract.Top--;
            textBoxPasswordToHide.Width = checkBoxHideWithPassword.Width;
            textBoxPasswordToExtract.Width = checkBoxExtractWithPassword.Width;

            //textBoxPasswordToHide.Top = chec
        }

        //Кнопка - выбрать файл, где спрятать другие файлы/файл
        private void buttonChangeMainPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "В каком файле спрятать файлы?";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxMainPath.Text = dialog.FileName;
                textBoxMainPath.Select(textBoxMainPath.Text.Length, 0);
                //MessageBox.Show(dialog.FileName);
                //Encrypt the selected file. I'll do this later. :)
            }
        }

        //Кнопка - выбрать файл/папку, которую необходимо спрятать
        private void buttonChangeHidePath_Click(object sender, EventArgs e)
        {   //Если пользователь выбрал, что будет прятать файл
            //то открываем OpenFileDialog
            if (radioButtonHideFile.Checked)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Какой файл спрятать?";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxHideFiles.Text = dialog.FileName;
                    textBoxHideFiles.Select(textBoxHideFiles.Text.Length, 0);
                    //MessageBox.Show(dialog.FileName);
                    //Encrypt the selected file. I'll do this later. :)
                }
            } //Иначе если папку, то открываем FolderBrowserDialog
            else
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK)// && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        textBoxHideFiles.Text = fbd.SelectedPath;
                        /*string[] files = Directory.GetFiles(fbd.SelectedPath);
                        for (int s = 0; s < files.Length; s++)
                        {
                            MessageBox.Show(files[s]);
                        }
                        System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");*/
                    }
                }
            }
        }

        private void radioButtonHideFolder_CheckedChanged(object sender, EventArgs e)
        {
            //textBoxHideFiles.Text = "";
        }


        string outPath = "";
        //Кнопка - Спрятать.
        private void buttonProcessHide_Click(object sender, EventArgs e)
        {
            //Если пользователь указал все данные
            if (textBoxMainPath.TextLength > 0 && textBoxHideFiles.TextLength > 0)
            {
                outPath = Path.GetDirectoryName(textBoxMainPath.Text) + "\\" + Path.GetFileNameWithoutExtension(textBoxMainPath.Text) + " (hidder)" + Path.GetExtension(textBoxMainPath.Text);
                //MessageBox.Show(outPath);

                //то инициализируем упаковщик
                Hidder hidder = new Hidder(textBoxMainPath.Text, outPath, textBoxHideFiles.Text);
                if (checkBoxHideWithPassword.Checked)
                    hidder.setPassword(textBoxPasswordToHide.Text);
                //и запускаем его
                hidder.hideFilesAtNewThread(radioButtonHideFolder.Checked);

                //так же запускаем новый (thread)поток, который будет информировать о процессе упаковки
                Thread thrdGetInfo = new Thread(() => threadGetInfoHide(hidder));
                thrdGetInfo.IsBackground = true;
                thrdGetInfo.Start();
                /*if (hidder.hideFiles(radioButtonHideFolder.Checked))
                {
                    MessageBox.Show("Успешно спрятано в новом файле "+outPath);
                } else
                {
                    MessageBox.Show("Не удалось спрятать!");
                }*/
            }
            //MessageBox.Show(((char)65).ToString());
        }

        bool hiding = false;
        //Поток информирования об упаковке
        private void threadGetInfoHide(Hidder hidder)
        {
            hiding = true;
            long time = 0;
            //Блокируем объекты
            panelHide.BeginInvoke(
                ((Action)(() => panelHide.Enabled = false)));
            panelStatusHide.BeginInvoke(
                ((Action)(() => panelStatusHide.Enabled = true)));
            /*labelStatusHide.BeginInvoke(
                     ((Action)(() => labelStatusHide.Text = "поиск файлов")));*/
            //Делаем состояния объектов по умолчания            
            labelStatusHide.BeginInvoke(
                     ((Action)(() => labelStatusHide.ForeColor = Color.Black)));
            progressBarHide.BeginInvoke(
                     ((Action)(() => progressBarHide.Value = 0)));
            System.Threading.Thread.Sleep(100);
            //Пока идёт упаковка         
            while (hidder.HidingStatus())
            {
                int toHide = hidder.getCountFilesToHide();
                int hided = hidder.getHidedSuccess();
                //Обновляем пользователю статус
                labelStatusHide.BeginInvoke(
                     ((Action)(() => labelStatusHide.Text = "спрятано " + hided.ToString() + " из " + toHide.ToString())));
                progressBarHide.BeginInvoke(
                     ((Action)(() => progressBarHide.Value = hidder.getHidingProgress())));
                //Делаем задержку 1 секунду
                System.Threading.Thread.Sleep(1000);
                time++;
                //Debug.WriteLine(extracted.ToString() + "  " + hided.ToString());
                //Debug.WriteLine(progress);
            }
            progressBarHide.BeginInvoke(
                     ((Action)(() => progressBarHide.Value = hidder.getHidingProgress())));
            string statusMsg;
            Color msgColor = Color.Red;
            //Инициализируем пользователю окончательное сообщение
            if (hidder.getCountFilesToHide() > 0)
            {
                StringBuilder hh = new StringBuilder(((int)((time - (time % 3600)) / 3600)).ToString());
                if (hh.Length == 1) hh = new StringBuilder("0" + hh);
                StringBuilder mm = new StringBuilder(((int)(((time % 3600)) / 60)).ToString());
                if (mm.Length == 1) mm = new StringBuilder("0" + mm);
                StringBuilder ss = new StringBuilder(((int)(((time % 3600)) % 60)).ToString());
                if (ss.Length == 1) ss = new StringBuilder("0" + ss);
                string sTime = hh.ToString() + ":" + mm.ToString() + ":" + ss.ToString();
                statusMsg = "спрятано файлов - " + hidder.getHidedSuccess().ToString() + "    за " + sTime;
                msgColor = Color.DarkGreen;
                if (hidder.getCountFilesToHide() != hidder.getHidedSuccess())
                    msgColor = Color.Red;
                if (hidder.getHidedSuccess() == 0)
                    statusMsg = "неудалось спрятать!";                
            }
            else statusMsg = "папка не может быть пустой!";

            //Выводим сообщение и разблокируем объекты
            labelStatusHide.BeginInvoke(
                     ((Action)(() => labelStatusHide.Text = statusMsg)));
            labelStatusHide.BeginInvoke(
                     ((Action)(() => labelStatusHide.ForeColor = msgColor)));
            /*panelStatusHide.BeginInvoke(
                ((Action)(() => panelStatusHide.Enabled = false)));*/
            panelHide.BeginInvoke(
                ((Action)(() => panelHide.Enabled = true)));
            hiding = false;

            if (hidder.getHidedSuccess() != 0)
                MessageBox.Show("исходный файл - " + outPath);
        }

        //Если пользователю подтверждает ввод своего пароля активируя галочку
        //то, разблокируем поле ввода для пароля
        private void checkBoxHideWithPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPasswordToHide.Enabled = (sender as CheckBox).Checked;
        }

        //Кнопка - выбрать файл, в котором спрятанны другие файлы
        private void buttonPathToFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Выберите файл со спрятанными файлами?";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = dialog.FileName;
                textBoxFile.Select(textBoxFile.Text.Length, 0);
            }
        }

        //Кнопка - выбрать папку, куда распаковать файлы
        private void buttonWhereExtract_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBoxPathExtract.Text = fbd.SelectedPath;
                }
            }
        }

        //Кнопка - распаковать
        private void buttonExtract_Click(object sender, EventArgs e)
        {
            //инициализируем распаковщик
            Hidder hidder = new Hidder(textBoxFile.Text);
            if (checkBoxExtractWithPassword.Checked)
                hidder.setPassword(textBoxPasswordToExtract.Text);
            //Включаем поток распаковки
            hidder.unhideFilesAtNewThread(textBoxPathExtract.Text);
            //Включаем поток вывода информации об распаковки пользователю
            Thread thrdGetInfo = new Thread(() => threadGetInfoExtract(hidder));
            thrdGetInfo.IsBackground = true;
            thrdGetInfo.Start();
            //tabControlMain.Enabled = false;            
        }

        bool extracting = false;

        //Поток распаковки
        private void threadGetInfoExtract(Hidder hidder)
        {
            extracting = true;
            long time = 0;
            panelExtract.BeginInvoke(
                ((Action)(() => panelExtract.Enabled = false)));
            panelStatusExtract.BeginInvoke(
                ((Action)(() => panelStatusExtract.Enabled = true)));
            labelStatus.BeginInvoke(
                     ((Action)(() => labelStatus.Text = "поиск файлов")));
            labelStatus.BeginInvoke(
                     ((Action)(() => labelStatus.ForeColor = Color.Black)));
            progressBarExtract.BeginInvoke(
                     ((Action)(() => progressBarExtract.Value = 0)));
            System.Threading.Thread.Sleep(2000);
            time++; time++;
            while (hidder.ExtractingStatus())
            {
                int hided = hidder.getCountHidedFiles();
                int extracted = hidder.getExtractedFiles();
                labelStatus.BeginInvoke(
                     ((Action)(() => labelStatus.Text = "спрятано - " + hidder.getCountHidedFiles().ToString() + "; извлечено - " + hidder.getExtractedFiles().ToString())));
                progressBarExtract.BeginInvoke(
                     ((Action)(() => progressBarExtract.Value = hidder.getExtractingProgress())));
                System.Threading.Thread.Sleep(1000);
                time++;
            }
            progressBarExtract.BeginInvoke(
                     ((Action)(() => progressBarExtract.Value = hidder.getExtractingProgress())));
            string statusMsg;
            Color msgColor = Color.Red;
            if (hidder.getCountHidedFiles() > 0)
            {
                StringBuilder hh = new StringBuilder(((int)((time - (time % 3600)) / 3600)).ToString());
                if (hh.Length == 1) hh = new StringBuilder("0" + hh);
                StringBuilder mm = new StringBuilder(((int)(((time % 3600)) / 60)).ToString());
                if (mm.Length == 1) mm = new StringBuilder("0" + mm);
                StringBuilder ss = new StringBuilder(((int)(((time % 3600)) % 60)).ToString());
                if (ss.Length == 1) ss = new StringBuilder("0" + ss);
                string sTime = hh.ToString() + ":" + mm.ToString() + ":" + ss.ToString();
                statusMsg = "извлечено файлов - " + hidder.getExtractedFiles().ToString() + "    за " + sTime;
                msgColor = Color.DarkGreen;
                if (hidder.getCountHidedFiles() != hidder.getExtractedFiles())
                    msgColor = Color.Red;
                if (hidder.getExtractedFiles() == 0)
                    statusMsg = "неправильный пароль!";
            }
            else statusMsg = "ничего не найдено!";
            labelStatus.BeginInvoke(
                     ((Action)(() => labelStatus.Text = statusMsg)));
            labelStatus.BeginInvoke(
                     ((Action)(() => labelStatus.ForeColor = msgColor)));
            /*panelStatusExtract.BeginInvoke(
                ((Action)(() => panelStatusExtract.Enabled = false)));*/
            panelExtract.BeginInvoke(
                ((Action)(() => panelExtract.Enabled = true)));
            extracting = false;

            if (hidder.getExtractedFiles() == 1)
            { MessageBox.Show("Файл извлечён в папку " + hidder.getOutDirectory()); }
            else if (hidder.getExtractedFiles() > 1)
            { MessageBox.Show("Файлы извлечены в папку " + hidder.getOutDirectory()); }
        }

        private void checkBoxExtractWithPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPasswordToExtract.Enabled = (sender as CheckBox).Checked;
        }

        //При закрытии формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool closeForm = true;
            //Если идёт упаковка/распаковка
            if (extracting || hiding)
            {   //Напоминаем пользователю об этом и спрашиваем
                //остановить упаковку/распаковку и закрыть программу или продолжить
                DialogResult dialogResult = MessageBox.Show("Программа не закончила процесс.\nВсё равно закрыть программу?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                    closeForm = false;
                }
            }
            //Если форма закрывается, то сохраняем вводные данные пользователя в файлы
            if (closeForm)
                if (ps.getAccessStatus())
                {
                    ps.setEnteredPage(tabControlMain.SelectedIndex);
                    ps.setFileWhereHide(textBoxMainPath.Text);
                    ps.setEnteredHideDirectory(radioButtonHideFolder.Checked);
                    ps.setPathToHide(textBoxHideFiles.Text);
                    ps.setSelectedUserPasswordToHide(checkBoxHideWithPassword.Checked);
                    ps.setUserPasswordToHide(textBoxPasswordToHide.Text);

                    ps.setFileWhereHided(textBoxFile.Text);
                    ps.setPathToExtract(textBoxPathExtract.Text);
                    ps.setSelectedUserPasswordToExtract(checkBoxExtractWithPassword.Checked);
                    ps.setUserPasswordToExtract(textBoxPasswordToExtract.Text);

                    ps.saveParamsToFiles();
                    //MessageBox.Show(ps.getUserPasswordToHide());
                }
        }

        private void tabPageHide_Click(object sender, EventArgs e)
        {

        }
    }
}
