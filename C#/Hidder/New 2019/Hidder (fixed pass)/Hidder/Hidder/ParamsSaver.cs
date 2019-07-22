using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hidder
{
    //Класс для сохранения и загрузки данных, заданных пользователем
    class ParamsSaver
    {
        private string ParamsFolder;
        private bool accessToFiles = true;

        private string passwordEncrypt = "ParamsSaver passw0rd";
        private string Encrypt(string text, bool plus = true)
        {
            StringBuilder t = new StringBuilder("");
            for (int i = 0; i < text.Length; i++)
            {
                /*int xor = passwordEncrypt[i % passwordEncrypt.Length];
                int enc = text[i] ^ xor;*/
                int change = ((int)passwordEncrypt[i % passwordEncrypt.Length]);
                if (!plus) change *= -1;
                int code = ((int)(text[i])) + change;
                t.Append((char)code);
            }
            return t.ToString();
        }

        private int enteredPage = 0;

        public void setEnteredPage(int entPage)
        {
            enteredPage = entPage;
        }

        public int getEnteredPage()
        {
            return enteredPage;
        }

        private string fileWhereHide = "";
        private bool hideDirectory = false;
        private string pathToHide = "";
        private bool selfPasswordToHide = false;
        private string PasswordToHide = "";

        //Методы для взятия и установки параметров/переменных объекта
        public void setFileWhereHide(string fWhereHide)
        {
            fileWhereHide = fWhereHide;
        }

        public string getFileWhereHide()
        {
            return fileWhereHide;
        }

        public void setEnteredHideDirectory(bool ent)
        {
            hideDirectory = ent;
        }

        public bool getEnteredHideDirectory()
        {
            return hideDirectory;
        }

        public void setPathToHide(string pth)
        {
            pathToHide = pth;
        }

        public string getPathToHide()
        {
            return pathToHide;
        }

        public void setSelectedUserPasswordToHide(bool sel)
        {
            selfPasswordToHide = sel;
        }

        public bool getSelectedUserPasswordToHide()
        {
            return selfPasswordToHide;
        }

        public void setUserPasswordToHide(string pass)
        {
            PasswordToHide = Encrypt(pass);
        }

        public string getUserPasswordToHide()
        {
            return Encrypt(PasswordToHide, false);
        }

        private string fileWhereHided = "";
        private string pathToExtract = "";
        private bool selfPasswordToExtract = false;
        private string PasswordToExtract = "";

        public void setFileWhereHided(string fWhereHided)
        {
            fileWhereHided = fWhereHided;
        }

        public string getFileWhereHided()
        {
            return fileWhereHided;
        }

        public void setPathToExtract(string pthToExtract)
        {
            pathToExtract = pthToExtract;
        }

        public string getPathToExtract()
        {
            return pathToExtract;
        }

        public void setSelectedUserPasswordToExtract(bool sel)
        {
            selfPasswordToExtract = sel;
        }

        public bool getSelectedUserPasswordToExtract()
        {
            return selfPasswordToExtract;
        }

        public void setUserPasswordToExtract(string pass)
        {
            PasswordToExtract = Encrypt(pass);
        }

        public string getUserPasswordToExtract()
        {
            return Encrypt(PasswordToExtract, false);
        }

        //Конструктор объекта, который пытается создать папку, для сохранения данных пользователя
        public ParamsSaver()
        {
            try
            {
                ParamsFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Hidder";
                Directory.CreateDirectory(@ParamsFolder);
            }
            catch (Exception ex)
            {
                try
                {
                    ParamsFolder = "HidderParams";
                    Directory.CreateDirectory(ParamsFolder);
                }
                catch (Exception ex2)
                {
                    accessToFiles = false;
                }
            }
            if (accessToFiles) getParamsFromFiles();
        }

        public bool getAccessStatus()
        {
            return accessToFiles;
        }

        //Функция сохранения данных в файлы
        public void saveParamsToFiles()
        {
            if (accessToFiles)
            {
                try
                {
                    System.IO.File.WriteAllText(ParamsFolder + "\\enteredPage", enteredPage.ToString());
                    System.IO.File.WriteAllText(ParamsFolder + "\\fileWhereHide", fileWhereHide);
                    System.IO.File.WriteAllText(ParamsFolder + "\\hideDirectory", hideDirectory.ToString());
                    System.IO.File.WriteAllText(ParamsFolder + "\\pathToHide", pathToHide);
                    System.IO.File.WriteAllText(ParamsFolder + "\\selfPasswordToHide", selfPasswordToHide.ToString());
                    System.IO.File.WriteAllText(ParamsFolder + "\\passwordToHide", PasswordToHide);

                    System.IO.File.WriteAllText(ParamsFolder + "\\fileWhereHided", fileWhereHided);
                    System.IO.File.WriteAllText(ParamsFolder + "\\pathToExtract", pathToExtract);
                    System.IO.File.WriteAllText(ParamsFolder + "\\selfPasswordToExtract", selfPasswordToExtract.ToString());
                    System.IO.File.WriteAllText(ParamsFolder + "\\passwordToExtract", PasswordToExtract);
                    /*private string fileWhereHide = "";
                    private bool hideDirectory = false;
                    private string pathToHide = "";
                    private bool selfPasswordToHide = false;
                    private string PasswordToHide = "";*/
                }
                catch (Exception ex)
                {
                    //accessToFiles = false;
                }
            }
        }

        //Функция загрузки данных
        public void getParamsFromFiles()
        {
            if (accessToFiles)
            {
                try
                {
                    string fls = "False";

                    string Page = System.IO.File.ReadAllText(ParamsFolder + "\\enteredPage");
                    enteredPage = int.Parse(Page);
                    fileWhereHide = System.IO.File.ReadAllText(ParamsFolder + "\\fileWhereHide");
                    string statusHideDirectory = System.IO.File.ReadAllText(ParamsFolder + "\\hideDirectory");
                    if (statusHideDirectory == fls) { hideDirectory = false; } else { hideDirectory = true; }
                    pathToHide = System.IO.File.ReadAllText(ParamsFolder + "\\pathToHide");
                    string statusSelfPasswordToHide = System.IO.File.ReadAllText(ParamsFolder + "\\selfPasswordToHide");
                    if (statusSelfPasswordToHide == fls) { selfPasswordToHide = false; } else { selfPasswordToHide = true; }
                    PasswordToHide = System.IO.File.ReadAllText(ParamsFolder + "\\passwordToHide");

                    fileWhereHided = System.IO.File.ReadAllText(ParamsFolder + "\\fileWhereHided");
                    pathToExtract = System.IO.File.ReadAllText(ParamsFolder + "\\pathToExtract");
                    string statusSelfPasswordToExtract = System.IO.File.ReadAllText(ParamsFolder + "\\selfPasswordToExtract");
                    if (statusSelfPasswordToExtract == fls) { selfPasswordToExtract = false; } else { selfPasswordToExtract = true; }
                    PasswordToExtract = System.IO.File.ReadAllText(ParamsFolder + "\\passwordToExtract");
                }
                catch (Exception ex)
                {
                    //accessToFiles = false;
                }
            }
        }
    }
}

