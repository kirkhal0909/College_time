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
        private String outMainFolder = "\\Extracted"; //папка распаковки
        private String pathHide;
        private String pass = "hidd3r appl1cation"; //Пароль по умолчанию
        private String passSalt = "hidd3r appl1cation"; //Кусок, который добавляется к паролю пользователя
        //private byte[] md5Pass;// = { 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
        //Начальные/конечные байты, по которым программа прячет файлы и извлекает
            private byte[] startBytes = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 33, 72, 105, 100, 100, 101, 114, 95, 115, 116, 97, 114, 116, 33 };
        private byte[] endBytes = { 33, 72, 105, 100, 100, 101, 114, 95, 101, 110, 100, 33, 9, 10, 11, 12, 0, 13, 14, 15, 16 };

        private byte[] startPath = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 33, 112, 97, 116, 104, 95, 115, 116, 97, 114, 116, 33 };
        private byte[] endPath = { 33, 112, 97, 116, 104, 95, 101, 110, 100, 33, 9, 10, 11, 12, 0, 13, 14, 15, 16 };

        //private byte[] DirectoryFind = { 0 };
        private byte[] DirectoryStart = { 1, 2, 3, 4, 0, 5, 6, 7, 8, 33, 104, 105, 100, 100, 101, 114, 95, 100, 105, 114, 101, 99, 116, 111, 114, 121, 33 };
        private byte[] DirectoryEnd = { 33, 104, 105, 100, 100, 101, 114, 95, 100, 105, 114, 101, 99, 116, 111, 114, 121, 95, 101, 110, 100, 33, 9, 10, 11, 12, 0, 13, 14, 15, 16 };
        //private byte[] endBlock = { 0,0 };

        //Конструктор упаковщика/распоковщика
        public Hidder(String inputFile, String outputFile = "encrypted", String pathToHide = "")
        {
            //md5Pass = CalculateMD5Hash(pass);
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
            pass = @passSalt+" "+ @password.ToLower();
            //Debug.WriteLine(pass);
            //md5Pass = CalculateMD5Hash(pass);
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
                byte xor = Convert.ToByte(pass[(k++) % pass.Length]);
                //Debug.WriteLine(xor);
                if (bytes[i] > 0 && bytes[i] != xor)
                    bytes[i] = Convert.ToByte(bytes[i]^xor);//(byte)((int)bytes[i] ^ xor);
            }
            return bytes;
        }

        private byte[] CalculateMD5Hash(string input)
        {
            // Вычисляем байты хэша MD5 от пароля 
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // convert byte array to hex string
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

        public int getHidedFoldersSuccess()
        {
            return hidedFoldersSuccess;
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
            if (progress == 100 && HidingNow)
                progress = 99;
            return progress;
        }

        private int countFilesToHide = 0;
        private int hidedSuccess = 0;
        private int hidedFoldersSuccess = 0;
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
            byte[] md5Pass = CalculateMD5Hash(pass);
            bool status = false;
            HidingNow = true;
            hidedSuccess = 0;
            hidedFoldersSuccess = 0;
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
                        //string[] directories = new string[files.Length];
                        //List<String> directories = GetDirectories(pathHide);
                        //Получаем список всех папок
                        string[] directories = System.IO.Directory.GetDirectories(@pathHide, "*", System.IO.SearchOption.AllDirectories);
                        int countDirectories = 0;
                        countFilesToHide = files.Length;
                        for (int i = 0; i < files.Length; i++)
                        {
                            pathOfFileToHide = files[i];                                                      
                            //Debug.WriteLine(directories.Contains("test").ToString());
                            //Записываем по циклу каждый новый файл в зашифрованном виде
                            stream.Write(startBytes, 0, startBytes.Length);
                            stream.Write(md5Pass, 0, md5Pass.Length);
                            stream.Write(startPath, 0, startPath.Length);
                            //Debug.WriteLine(Path.GetDirectoryName(pathHide));
                            //Debug.WriteLine(files[i].Replace(Path.GetDirectoryName(pathHide), ""));
                            //string pathToFile = files[i].Replace(pathHide + "\\", "");
                            string pathToFile = files[i].Replace(Path.GetDirectoryName(pathHide), "");
                            //Debug.WriteLine(pathToFile);
                            string pathToDirectory = Path.GetDirectoryName(pathToFile);                            
                            /*if (!directories.Contains(pathToDirectory) && (pathToDirectory.Length>0))
                            {
                                directories[countDirectories++] = pathToDirectory;                                
                            }*/
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
                        /*for(int i = 0; i < directories.Length;i++)
                        {
                            Debug.WriteLine(directories[i]);
                        }        */
                        /*if (directories.Length > 0)
                            stream.Write(DirectoryStart, 0, DirectoryStart.Length);*/
                        //Прячем папки в файле и шифруем их названия
                        for (int i = 0; i < directories.Length; i++)
                        {
                            byte[] encPathDir = System.Text.Encoding.UTF8.GetBytes(directories[i].Replace(Path.GetDirectoryName(pathHide), ""));
                            //if (encPathDir[0] == 0) { Debug.WriteLine(directories[i]); }
                            encPathDir = enc(encPathDir);
                            //stream.Write(DirectoryFind, 0, DirectoryFind.Length);
                            stream.Write(DirectoryStart, 0, DirectoryStart.Length);
                            stream.Write(encPathDir, 0, encPathDir.Length);
                            stream.Write(DirectoryEnd, 0, DirectoryEnd.Length);
                            hidedFoldersSuccess++;
                            //Debug.WriteLine(directories[i]);
                        }
                       // stream.Write(DirectoryFind, 0, DirectoryFind.Length);
                    }
                    //stream.Write(endBlock, 0, endBlock.Length);
                }
                HidingNow = false;
                status = true;
            }
            return status;
        }

        private int hidedFiles = 0;
        private int hidedFolders = 0;
        //Вычисляем количество спрятанных файлов и папок
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

            pos = 0;
            for (long i = 0; i < fileBytes.LongLength; i++)
            {
                if (fileBytes[i] == DirectoryStart[pos])
                {
                    pos++;
                    if (pos == DirectoryStart.Length)
                    {
                        hidedFolders++;
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

        public int getCountHidedFolders()
        {
            return hidedFolders;
        }

        public int getExtractedFiles()
        {
            return extractedFiles;
        }

        private int ExtractedFolders = 0;
        public int getExtractedFolders()
        {
            return ExtractedFolders;
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
            if (progress == 100 && ExtractingNow)
                progress = 99;
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
        //Поиск байтов в файле
        private long findPos(byte[] fileBytes, byte[] findBytes, bool firstOccurrence = true, long fromPos=0)
        {
            long foundedPos = -1;
            long pos = 0;
            long i;
            /*if (!reversed)
            {*/if (fromPos>=0)
                for (i = fromPos; i < fileBytes.LongLength; i++)
                {
                    if (fileBytes[i] == findBytes[pos])
                    {
                        pos++;
                        if (pos == findBytes.LongLength)
                        {
                            if (firstOccurrence)
                            { foundedPos = i - findBytes.Length + 1; }
                            else { foundedPos = i + 1; }
                            pos = 0;
                            break;
                        }
                    }
                    else pos = 0;
                }
            /*}
            else
            {
                pos = findBytes.Length-1;
                for (i = fileBytes.LongLength - fromPos; i >=0; i--)
                {
                    if (fileBytes[i] == findBytes[pos])
                    {
                        pos--;
                        if (pos == 0)
                        {
                            if (firstOccurrence)
                            { foundedPos = i; }
                            else { foundedPos = i + findBytes.Length; }
                            pos = findBytes.Length - 1;
                            break;
                        }
                    }
                    else pos = findBytes.Length - 1;
                }
            }*/
            return foundedPos;
        }        

        //Распаковщик
        public void unhideFiles(string extractTo)
        {
            byte[] md5Pass = CalculateMD5Hash(pass);
            ExtractingNow = true;
            extractedFiles = 0;
            ExtractedFolders = 0;
            try
            {                
                //bool status = false;
                bool newFile = false, getPath = false, getData = false;
                bool newDirectory = false, endBlockFounded = false;
                byte[] path = { };
                Int64 pos = 0;
                Int64 posStartCopy = 0;
                Int64 filePosition = -1;
                //Читаем файл. Максимум 2 гигабайта!!!
                byte[] fileBytes = File.ReadAllBytes(inpFile);
                //long dirPos = findPos(fileBytes, DirectoryStart, true, true);
                //for (long j = dirPos; j < dirPos + DirectoryStart.Length; j++)
                //    Debug.Write(fileBytes[j].ToString() + " ");
                string filePath = "";
                if (extractTo.Length == 0) extractTo = Directory.GetCurrentDirectory();
                else if (extractTo[extractTo.Length - 1] == '\\') extractTo.Remove(extractTo.Length - 1);
                outDirectory = extractTo + outMainFolder;
                //Проходим по каждому байту файла
                Int64 i;
                for (i = filePosition + 1; i < fileBytes.LongLength; i++)
                {
                    break;
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
                                        //Debug.WriteLine(j.ToString()+":   "+md5Bytes[j].ToString() + " " + md5Pass[j].ToString());
                                        int z = 0;
                                        j = 0/z;
                                    }
                                //break;
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
                                        if(!Directory.Exists(folderToCreate))
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
                                        //byte[] dataBytes = File.ReadAllBytes(inpFile).Skip((int)posStartCopy).Take((int)(i - endBytes.LongLength + 1 - posStartCopy)).ToArray();
                                        byte[] dataBytes = fileBytes.Skip((int)posStartCopy).Take((int)(i - endBytes.LongLength + 1 - posStartCopy)).ToArray();
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

                                        /*if (fileBytes[i + 1] == endBytes[0] && fileBytes[i + 2] == endBytes[1])
                                        { endBlockFounded = true; break; }
                                        else
                                        if(fileBytes[i+1]==DirectoryFind[0])
                                        {
                                            newDirectory = true;
                                            break;
                                        }*/
                                    }
                                }                                
                                else pos = 0;
                            }
                        }
                    }
                }                

                pos = 0;                
                i = 0;
                int passPos = 0;           
                string directoryPath = "";
                //Распаковка папок
                while(i!=-1 && i<fileBytes.LongLength)
                {
                    i = findPos(fileBytes, DirectoryStart, false, i);
                    passPos = 0;
                    directoryPath = "";
                    //Debug.WriteLine(i);
                    //Debug.WriteLine(findPos(fileBytes, DirectoryEnd, true, i));
                    if(i!=-1)
                    for (long lenPath = i; lenPath < findPos(fileBytes, DirectoryEnd, true, i); lenPath++)
                    {
                        byte[] dirByte = { fileBytes[lenPath] };
                        dirByte = enc(dirByte, passPos);
                        //Debug.WriteLine(dirByte[0]);
                        passPos = (passPos + 1) % pass.Length;
                        directoryPath = directoryPath + (char)(dirByte[0]);                                                                      
                    }
                    string folderToCreate = extractTo + outMainFolder + "\\" + directoryPath;
                    //Debug.WriteLine(folderToCreate + " ");
                    if (!Directory.Exists(folderToCreate))
                    {
                        Directory.CreateDirectory(@folderToCreate);
                        ExtractedFolders++;
                    }
                }

                //Распаковка файлов
                pos = 0;
                i = 0;
                passPos = 0;
                while (i != -1 && i < fileBytes.LongLength)
                {
                    bool truePass = false;
                    while (i != -1 && i < fileBytes.LongLength && !truePass)
                    {
                        i = findPos(fileBytes, startBytes, false, i);
                        long end = findPos(fileBytes, startPath, true, i);
                        //Debug.WriteLine(i.ToString() + " " + end.ToString());
                        byte[] data = fileBytes.Skip((int)i).Take((int)(end - i)).ToArray();
                        truePass = true;
                        for (int j = 0; j < data.Length; j++)
                        {
                            if (data[j] != md5Pass[j])
                            {
                                truePass = false;
                                //Debug.WriteLine("Bad password");
                            }
                        }
                    }
                    if (i != -1 && truePass)
                    {
                        i = findPos(fileBytes, startPath, false, i);
                        long end = findPos(fileBytes, endPath, true, i);
                        byte[] data = fileBytes.Skip((int)i).Take((int)(end - i)).ToArray();
                        data = enc(data);
                        string getedPath = System.Text.Encoding.Default.GetString(data);
                        filePath = extractTo + outMainFolder + "\\" + getedPath;
                        //Debug.WriteLine(filePath);
                        i = findPos(fileBytes, endPath, false, i);
                        end = findPos(fileBytes, endBytes, true, i);
                        try
                        {
                            byte[] dataFile = fileBytes.Skip((int)i).Take((int)(end - i)).ToArray();
                            dataFile = enc(dataFile);
                            System.IO.File.WriteAllBytes(filePath, dataFile);
                            extractedFiles++;
                        }
                        catch (Exception ex) { };
                    }
                }

                while (newDirectory)
                {
                    /*i++;
                    if (fileBytes[i] == endBlock[pos])
                    {
                        pos++;
                        string folderToCreate = extractTo + outMainFolder + "\\" + directoryPath;
                        Debug.WriteLine(folderToCreate + " ");
                        if (!Directory.Exists(folderToCreate))
                            Directory.CreateDirectory(@folderToCreate);                        
                        directoryPath = "";
                        passPos = 0;
                        if (pos == endBlock.Length)
                        {
                            endBlockFounded = true;
                            newDirectory = false;
                        }
                    }
                    else
                    {                        
                        byte[] dirByte = { fileBytes[i] };
                        dirByte = enc(dirByte, passPos);
                        Debug.WriteLine(dirByte[0]);
                        passPos = (passPos + 1) % pass.Length;
                        directoryPath = directoryPath + (char)(dirByte[0]);
                        //Debug.Write((char)(fileBytes[i]));
                        pos = 0;
                    }*/
                }               
            }
            catch (Exception ex) { Debug.WriteLine(ex); }
            ExtractingNow = false;
            //return status;
        }
    }
}
