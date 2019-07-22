using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Hidder
{
    class Hidder
    {
        private String inpFile;
        private String outFile;
        private String outMainFolder = "Extracted"; //папка распаковки
        private String pathHide;
        private String pass = "Hidd3r Appl1cation"; //Пароль по умолчанию
        private byte[] md5Pass = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
        //Начальные/конечные байты, по которым программа прячет файлы и извлекает
        private byte[] startBytes = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 33, 72, 105, 100, 100, 101, 114, 95, 115, 116, 97, 114, 116, 33 };
        private byte[] endBytes = { 33, 72, 105, 100, 100, 101, 114, 95, 101, 110, 100, 33, 9, 10, 11, 12, 0, 13, 14, 15, 16 };

        private byte[] startPath = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 33, 112, 97, 116, 104, 95, 115, 116, 97, 114, 116, 33 };
        private byte[] endPath = { 33, 112, 97, 116, 104, 95, 101, 110, 100, 33, 9, 10, 11, 12, 0, 13, 14, 15, 16 };

        //Конструктор упаковщика/распоковщика
        public Hidder(String inputFile, String outputFile = "encrypted", String pathToHide = "")
        {
            md5Pass = CalculateMD5Hash(pass);
            inpFile = inputFile;
            outFile = outputFile;
            pathHide = pathToHide;
        }

        //Методы получения и установления параметров объекта
        public void setInputFile(String pathToFile)
        {
            inpFile = pathToFile;
        }

        public String getInputFile()
        {
            return inpFile;
        }

        public void setOutputFile(String pathToOutput)
        {
            outFile = pathToOutput;
        }

        public String getOutputFile()
        {
            return outFile;
        }

        public void setPathToHide(String pathToHide)
        {
            pathHide = pathToHide;
        }

        public String getPathToHide()
        {
            return pathHide;
        }

        public void setPassword(String password)
        {            
            pass = password;
            md5Pass = CalculateMD5Hash(pass);
        }

        //Проверка наличия файлов на жёстком диске
        private bool validFilesToHide(bool isDirectory = false)
        {
            bool valid = false;
            if (System.IO.File.Exists(inpFile))
            {
                if (((!isDirectory) && (System.IO.File.Exists(pathHide)))
                    || ((isDirectory) && (System.IO.Directory.Exists(pathHide))))
                {
                    valid = true;
                }
            }
            return valid;
        }

        //Функция шифрования байтов
        private byte[] enc(byte[] bytes, int startFrom = 0)
        {
            int k = startFrom;
            for (long i = 0; i < bytes.LongLength; i++)
            {
                int xor = pass[(k++) % pass.Length];
                //Debug.WriteLine(xor);
                if (bytes[i] > 0 && bytes[i] != xor)
                    bytes[i] = (byte)((int)bytes[i] ^ xor);
            }
            return bytes;
        }

        private byte[] CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            /*StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }*/
            return hash;//sb.ToString();
        }

        public bool HidingStatus()
        {
            return HidingNow;
        }

        public int getCountFilesToHide()
        {
            return countFilesToHide;
        }

        public int getHidedSuccess()
        {
            return hidedSuccess;
        }

        public string getLastHiding()
        {
            return pathOfFileToHide;
        }

        //Получения прогресса упаковщика в процентах
        public int getHidingProgress()
        {
            int progress = 0;
            if (countFilesToHide != 0)
                progress = (int)(((float)hidedSuccess / countFilesToHide) * 100);
            return progress;
        }

        private int countFilesToHide = 0;
        private int hidedSuccess = 0;
        private bool HidingNow = false;
        private string pathOfFileToHide = "";

        //Запуск упаковщика в новом потоке
        public void hideFilesAtNewThread(bool isDirectory = false)
        {
            Thread threadHideFiles = new Thread(() => hideFiles(isDirectory));
            threadHideFiles.IsBackground = true;

            threadHideFiles.Start();
        }

        //Упаковщик
        public bool hideFiles(bool isDirectory = false)
        {
            //Debug.WriteLine(CalculateMD5Hash(pass));
            bool status = false;
            HidingNow = true;
            hidedSuccess = 0;
            //Если файлы надены на диске
            if (validFilesToHide(isDirectory))
            {
                byte[] fileBytes = File.ReadAllBytes(inpFile);
                //Debug.WriteLine(fileBytes[0].ToString());
                //Копируем основной файл
                System.IO.File.WriteAllBytes(outFile, fileBytes);
                //Упаковываем файл/директорию
                using (var stream = new FileStream(outFile, FileMode.Append))
                {   //Если выбран файл
                    if (!isDirectory)
                    {
                        countFilesToHide = 1;
                        pathOfFileToHide = pathHide;
                        //Вписываем начальные байты
                        stream.Write(startBytes, 0, startBytes.Length);
                        stream.Write(md5Pass, 0, md5Pass.Length);                        
                        stream.Write(startPath, 0, startPath.Length);
                        //Шифруем название файла
                        byte[] encPath = enc(System.Text.Encoding.Default.GetBytes(Path.GetFileName(pathHide)));
                        //Дописываем зашифрованное название и добавляем закрывающие байты
                        stream.Write(encPath, 0, encPath.Length);
                        stream.Write(endPath, 0, endPath.Length);
                        //Открываем файл, который необходимо спрятать
                        fileBytes = File.ReadAllBytes(pathHide);
                        //Шифруем его
                        fileBytes = enc(fileBytes);
                        //Дописываем
                        stream.Write(fileBytes, 0, fileBytes.Length);
                        stream.Write(endBytes, 0, endBytes.Length);
                        hidedSuccess = 1;
                    }
                    else  //Если пользователь прячет директорию
                    {
                        //Получаем список всех файлов
                        string[] files = Directory.GetFiles(pathHide, "*", SearchOption.AllDirectories);
                        countFilesToHide = files.Length;
                        for (int i = 0; i < files.Length; i++)
                        {
                            pathOfFileToHide = files[i];
                            //Записываем по циклу каждый новый файл в зашифрованном виде
                            stream.Write(startBytes, 0, startBytes.Length);
                            stream.Write(startPath, 0, startPath.Length);
                            string pathToFile = files[i].Replace(pathHide + "\\", "");
                            byte[] encPath = System.Text.Encoding.UTF8.GetBytes(pathToFile);
                            encPath = enc(encPath);
                            stream.Write(encPath, 0, encPath.Length);
                            stream.Write(endPath, 0, endPath.Length);

                            fileBytes = File.ReadAllBytes(files[i]);
                            fileBytes = enc(fileBytes);
                            stream.Write(fileBytes, 0, fileBytes.Length);
                            stream.Write(endBytes, 0, endBytes.Length);
                            hidedSuccess++;
                        }
                    }
                }
                HidingNow = false;
                status = true;
            }
            return status;
        }

        private int hidedFiles = 0;
        //Вычисляем количество спрятанных файлов
        private void findCountHidedFiles()
        {
            hidedFiles = 0;
            byte[] fileBytes = File.ReadAllBytes(inpFile);
            int pos = 0;
            for (long i = 0; i < fileBytes.LongLength; i++)
            {
                if (fileBytes[i] == startBytes[pos])
                {
                    pos++;
                    if (pos == startBytes.Length)
                    {
                        hidedFiles++;
                        pos = 0;
                    }
                }
                else pos = 0;
            }
        }

        public int getCountHidedFiles()
        {
            return hidedFiles;
        }

        public int getExtractedFiles()
        {
            return extractedFiles;
        }
        //Создания потоков, для распаковки
        public void unhideFilesAtNewThread(string extractTo)
        {
            //Поток который вычисляет количество спрятанных файлов
            Thread threadDoCount = new Thread(findCountHidedFiles);
            threadDoCount.IsBackground = true;
            //Поток распаковщика
            Thread threadUnhideFiles = new Thread(() => unhideFiles(extractTo));
            threadUnhideFiles.IsBackground = true;

            threadUnhideFiles.Start();
            System.Threading.Thread.Sleep(50);
            threadDoCount.Start();
        }
        //Получения прогресса распаковщика в процентах
        public int getExtractingProgress()
        {
            int progress = 0;
            if (hidedFiles != 0)
                progress = (int)(((float)extractedFiles / hidedFiles) * 100);
            return progress;
        }

        public bool ExtractingStatus()
        {
            return ExtractingNow;
        }

        private int extractedFiles = 0;
        private bool ExtractingNow = false;
        private string outDirectory = "";

        public string getOutDirectory()
        {
            return outDirectory;
        }

        //Распаковщик
        public void unhideFiles(string extractTo)
        {
            md5Pass = CalculateMD5Hash(pass);
            ExtractingNow = true;
            extractedFiles = 0;
            try
            {
                //bool status = false;
                bool newFile = false, getPath = false, getData = false;
                byte[] path = { };
                Int64 pos = 0;
                Int64 posStartCopy = 0;
                Int64 filePosition = -1;
                //Читаем файл. Максимум 2 гигабайта!!!
                byte[] fileBytes = File.ReadAllBytes(inpFile);
                string filePath = "";
                if (extractTo.Length == 0) extractTo = Directory.GetCurrentDirectory();
                else if (extractTo[extractTo.Length - 1] == '\\') extractTo.Remove(extractTo.Length - 1);
                outDirectory = extractTo + outMainFolder;
                //Проходим по каждому байту файла
                for (Int64 i = filePosition + 1; i < fileBytes.Length; i++)
                {
                    if (!newFile)   //Если не найден новый зашифрованный файл, то ищем его
                    {
                        //Int64 codeNow = fileBytes[i];
                        if (fileBytes[i] == startBytes[pos])
                        {
                            pos++;
                            if (pos == startBytes.Length)
                            {
                                newFile = true;
                                byte[] md5Bytes = File.ReadAllBytes(inpFile).Skip((int)i+1).Take(16).ToArray();
                                bool access = true;
                                for (int j = 0; j < md5Bytes.Length; j++)
                                    //Debug.WriteLine(md5Bytes[j]);
                                    if (md5Bytes[j]!=md5Pass[j])
                                    {
                                        int z = 0;
                                        j = 0/z;
                                    }
                                    //Debug.WriteLine(md5Bytes[j].ToString()+" "+md5Pass[j].ToString());
                                //Debug.WriteLine(md5Bytes == md5Pass);
                                pos = 0;
                            }
                        }
                        else pos = 0;
                    }
                    else
                    {   //Если нашли, то ищем его путь например: папка\папка\файл.txt
                        if (!getPath && !getData)
                        {
                            if (fileBytes[i] == startPath[pos])
                            {
                                pos++;
                                if (pos == startPath.Length)
                                {
                                    getPath = true;
                                    posStartCopy = i + 1;
                                    pos = 0;
                                }
                            }
                            else pos = 0;
                        }
                        else
                        {   //Находим закрывающие байты пути
                            if (getPath)
                            {
                                if (fileBytes[i] == endPath[pos])
                                {
                                    pos++;
                                    if (pos == endPath.Length)
                                    {
                                        getPath = false;
                                        getData = true;

                                        //Берём путь в виде байт
                                        byte[] pathBytes = File.ReadAllBytes(inpFile).Skip((int)posStartCopy).Take((int)(i - endBytes.LongLength + 3 - posStartCopy)).ToArray();
                                        //Делаем расшифровку(XOR) по паролю
                                        pathBytes = enc(pathBytes);
                                        //Переводим байты в строчку
                                        string getedPath = System.Text.Encoding.Default.GetString(pathBytes);

                                        //int k = 0;
                                        //StringBuilder getedPath = new StringBuilder("");
                                        //Debug.WriteLine("");
                                        /*for(long pthI = posStartCopy;pthI< i - endPath.LongLength+1;pthI++)
                                        {
                                            byte[] pathByte = {fileBytes[pthI]};
                                            pathByte = enc(pathByte,k);
                                            k++;
                                            k = k % pass.Length;
                                            //Debug.Write(pathByte[0].ToString() + " ");
                                            //getedPath = new StringBuilder(getedPath.ToString() + ((char)pathByte[0]).ToString());
                                            getedPath.Append((char)pathByte[0]);
                                        }*/
                                        posStartCopy = i + 1;
                                        //getedPath = new StringBuilder("test\\test\\test3");
                                        //string directory = Path.GetDirectoryName(getedPath.ToString());
                                        //string fileName = Path.GetFileName(getedPath.ToString());    

                                        string directory = Path.GetDirectoryName(getedPath);
                                        string fileName = Path.GetFileName(getedPath);
                                        string folderToCreate = extractTo + "\\" + outMainFolder + "\\" + directory;
                                        //Создаёем директорию/директории для файла, если упакована была папка с файлами
                                        Directory.CreateDirectory(@folderToCreate);

                                        filePath = folderToCreate + "\\" + fileName;
                                        //Debug.WriteLine(filePath);
                                        //Debug.WriteLine("\n\nPATH: " + Directory.GetCurrentDirectory()+"\\"+outMainFolder+"\\"+directory);
                                        //Array.Copy(fileBytes,i-endPath.LongLength-posStartCopy-1,)

                                        pos = 0;
                                    }
                                }
                                else pos = 0;
                            }
                            else
                            {   //Ищем конечные байты файла
                                if (fileBytes[i] == endBytes[pos])
                                {
                                    pos++;
                                    if (pos == endBytes.Length) //Если нашли
                                    {
                                        extractedFiles++;
                                        getData = false;
                                        newFile = false;
                                        //status = true;
                                        pos = 0;
                                        //int k = 0;
                                        //StringBuilder getedFile = new StringBuilder("");
                                        //System.IO.File.WriteAllBytes(outFile,fileBytes);                                    

                                        //Читаем байты файла
                                        byte[] dataBytes = File.ReadAllBytes(inpFile).Skip((int)posStartCopy).Take((int)(i - endBytes.LongLength + 1 - posStartCopy)).ToArray();
                                        //Расшифровываем
                                        dataBytes = enc(dataBytes);
                                        //Записываем файл из памяти в файл, по расшифрованному пути из прошлого блока
                                        System.IO.File.WriteAllBytes(filePath, dataBytes);

                                        /*byte[] dataByte = { fileBytes[posStartCopy] };
                                        dataByte = enc(dataByte, k);
                                        k++;
                                        k = k % pass.Length;
                                        System.IO.File.WriteAllBytes(filePath, dataByte);

                                        for (long dataI = posStartCopy+1; dataI < i - endBytes.LongLength + 1; dataI++)
                                        {
                                            dataByte = new byte[]{ fileBytes[dataI] };
                                            dataByte = enc(dataByte, k);
                                            k++;
                                            k = k % pass.Length;
                                            using (var stream = new FileStream(filePath, FileMode.Append))
                                            {
                                                stream.Write(dataByte, 0, dataByte.Length);
                                            }
                                            //Debug.Write(dataByte[0].ToString() + " ");
                                            //getedPath = new StringBuilder(getedPath.ToString() + ((char)pathByte[0]).ToString());
                                            //getedFile.Append((char)dataByte[0]);
                                        }*/
                                    }
                                }
                                else pos = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { }
            ExtractingNow = false;
            //return status;
        }
    }
}
